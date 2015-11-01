using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;

namespace VS13.Windows {
    //
    public class TrayIcon {
        //Members
        private NotifyIcon mNotifyIcon = null;

        private const string MNU_SHOWDESKTOPALERT = "Show Desktop Alert";
        private const string MNU_HIDEWHENMINIMIZED = "Hide When Minimized";
        private const string MNU_SHOW = "Open";

        public event EventHandler ShowDesktopAlertChanged = null;
        public event EventHandler HideWhenMinimizedChanged = null;
        public event EventHandler Unhide = null;
        public event BalloonTipEventHandler TrayIconBalloonTipClicked = null;
        public event TrayIconErrorEventHandler TrayIconError = null;

        //Interface
        public TrayIcon(string iconText,Icon icon) {
            //Constructor
            try {
                this.mNotifyIcon = new NotifyIcon();
                this.mNotifyIcon.Text = iconText;
                this.mNotifyIcon.Icon = icon;
                this.mNotifyIcon.Visible = true;
                MenuItem ctxAlert = new MenuItem(MNU_SHOWDESKTOPALERT,new System.EventHandler(this.onTrayIconItemClick));
                ctxAlert.Index = 0;
                ctxAlert.Checked = true;
                MenuItem ctxSep1 = new MenuItem("-");
                ctxSep1.Index = 1;
                MenuItem ctxHide = new MenuItem(MNU_HIDEWHENMINIMIZED,new System.EventHandler(this.onTrayIconItemClick));
                ctxHide.Index = 2;
                ctxHide.Checked = true;
                MenuItem ctxShow = new MenuItem(MNU_SHOW,new System.EventHandler(this.onTrayIconItemClick));
                ctxShow.Index = 3;
                ctxShow.DefaultItem = true;
                this.mNotifyIcon.ContextMenu = new ContextMenu(new MenuItem[] { ctxAlert,ctxSep1,ctxHide,ctxShow });
                this.mNotifyIcon.DoubleClick += new System.EventHandler(onTrayIconDoubleClick);
                this.mNotifyIcon.BalloonTipClicked += new EventHandler(onTrayIconBalloonTipClick);
            }
            catch(Exception ex) { if (this.TrayIconError != null) TrayIconError(this,new TrayIconErrorEventArgs(ex)); }
        }
        public void Dispose() { this.mNotifyIcon.Dispose(); }

        public string Text { get { return this.mNotifyIcon.Text; } set { this.mNotifyIcon.Text = value; } }
        public ContextMenu ContextMenu { get { return this.mNotifyIcon.ContextMenu; } }
        public bool Visible { get { return this.mNotifyIcon.Visible; } set { this.mNotifyIcon.Visible = value; } }
        public bool ShowDesktopAlerts { get { return this.mNotifyIcon.ContextMenu.MenuItems[0].Checked; } set { this.mNotifyIcon.ContextMenu.MenuItems[0].Checked = value; } }
        public bool HideWhenMinimized { get { return this.mNotifyIcon.ContextMenu.MenuItems[2].Checked; } set { this.mNotifyIcon.ContextMenu.MenuItems[2].Checked = value; } }
        public void ShowBalloonTip(int timeout) { 
            //
            try {
                if (this.ShowDesktopAlerts) this.mNotifyIcon.ShowBalloonTip(timeout); 
            }
            catch (Exception ex) { if (this.TrayIconError != null) TrayIconError(this,new TrayIconErrorEventArgs(ex)); }
        }
        public void ShowBalloonTip(int timeout,string tipTitle,string tipText,ToolTipIcon tipIcon) { 
            //
            try {
                if (this.ShowDesktopAlerts) this.mNotifyIcon.ShowBalloonTip(timeout,tipTitle,tipText,tipIcon);
            }
            catch (Exception ex) { if (this.TrayIconError != null) TrayIconError(this,new TrayIconErrorEventArgs(ex)); }
        }

        private void onTrayIconItemClick(object sender,System.EventArgs e) {
            //Menu itemclicked-apply selected service
            try {
                MenuItem item = (MenuItem)sender;
                switch (item.Text) {
                    case MNU_SHOWDESKTOPALERT:
                        this.mNotifyIcon.ContextMenu.MenuItems[0].Checked = !this.mNotifyIcon.ContextMenu.MenuItems[0].Checked;
                        if (this.ShowDesktopAlertChanged != null) ShowDesktopAlertChanged(this,EventArgs.Empty);
                        break;
                    case MNU_HIDEWHENMINIMIZED:
                        this.mNotifyIcon.ContextMenu.MenuItems[2].Checked = !this.mNotifyIcon.ContextMenu.MenuItems[2].Checked;
                        if (this.HideWhenMinimizedChanged != null) HideWhenMinimizedChanged(this,EventArgs.Empty);
                        break;
                    case MNU_SHOW:
                        if (this.Unhide != null) Unhide(this,EventArgs.Empty);
                        break;
                }
            }
            catch (Exception ex) { if (this.TrayIconError != null) TrayIconError(this,new TrayIconErrorEventArgs(ex)); }
        }
        private void onTrayIconDoubleClick(object Sender,EventArgs e) {
            //Event handler for tray icon double clicked
            try {
                //Invoke the Open menu item
                this.mNotifyIcon.ContextMenu.MenuItems[3].PerformClick();
            }
            catch (Exception ex) { if (this.TrayIconError != null) TrayIconError(this,new TrayIconErrorEventArgs(ex)); }
        }
        private void onTrayIconBalloonTipClick(object sender,EventArgs e) {
            //Event handler for balloon tip clicked
            //Forward to application
            if (this.TrayIconBalloonTipClicked != null) TrayIconBalloonTipClicked(this,new BalloonTipEventArgs(this.mNotifyIcon.BalloonTipTitle,this.mNotifyIcon.BalloonTipText));
        }
    }

    public delegate void BalloonTipEventHandler(object sender,BalloonTipEventArgs e);
    public class BalloonTipEventArgs:EventArgs {
        private string _title = "", _text="";
        public BalloonTipEventArgs(string title,string text) { this._title = title; this._text = text; }
        public string Title { get { return this._title; } set { _title = value; } }
        public string Text { get { return this._text; } set { _text = value; } }
    }

    public delegate void TrayIconErrorEventHandler(object sender,TrayIconErrorEventArgs e);
    public class TrayIconErrorEventArgs:EventArgs {
        private Exception _exception = null;
        public TrayIconErrorEventArgs(Exception exception) { this._exception = exception; }
        public Exception Exception { get { return this._exception; } set { _exception = value; } }
    }
}
