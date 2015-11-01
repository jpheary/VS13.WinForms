using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VS13.Windows;

namespace VS13 {
    //
    public partial class frmMain:Form {
        //Members
        private TrayIcon mTrayIcon = null;

        //Interface
        public frmMain() {
            //Constructor
            try {
                InitializeComponent();
                this.mTrayIcon = new TrayIcon("VS13",this.Icon);
                this.mTrayIcon.Visible = true;
                this.mTrayIcon.HideWhenMinimizedChanged += new EventHandler(OnTrayIconHideWhenMinimizedChanged);
                this.mTrayIcon.Unhide += new EventHandler(OnTrayIconUnhide);
                this.mTrayIcon.TrayIconBalloonTipClicked += new BalloonTipEventHandler(OnTrayIconBalloonTipClicked);
                this.mTrayIcon.TrayIconError += new TrayIconErrorEventHandler(OnTrayIconError);
            }
            catch (Exception ex) { throw new ApplicationException(ex.Message,ex); }
        }

        private void OnFormLoad(object sender,System.EventArgs e) {
            //Event handler for form load event
            try {
                //Initialize controls
                this.Visible = true;
                Application.DoEvents();

                //Add custom menu items to the tray icon
                this.mTrayIcon.ContextMenu.MenuItems.Add(new MenuItem("-"));
                this.mTrayIcon.ContextMenu.MenuItems.Add(new MenuItem("Custom Item 1",new System.EventHandler(this.OnItemClick)));
            }
            catch (Exception ex) { App.ReportError(ex,true); }
        }
        private void OnFormClosing(object sender,FormClosingEventArgs e) {
            //Event handler for form closing event
            try {
                if (!e.Cancel) this.mTrayIcon.Visible = false;
            }
            catch (Exception ex) { App.ReportError(ex,false); }
        }
        private void OnFormResize(object sender,System.EventArgs e) {
            //Event handler for form resized event
            //Hide this form if HideWhenMinimized is on
            if (this.WindowState == FormWindowState.Minimized) this.Visible = !this.mTrayIcon.HideWhenMinimized;
        }
        private void OnFormClick(object sender,EventArgs e) {
            //Event handler for form click event
            //Post a simple alert
            string tipText = "The current date and time is: " + DateTime.Now.ToUniversalTime();
            this.mTrayIcon.ShowBalloonTip(5000,"Title",tipText,ToolTipIcon.Info);
        }
        private void OnItemClick(object sender,System.EventArgs e) {
            //Menu services
            try {
                MenuItem item = (MenuItem)sender;
                switch (item.Text) {
                    case "Custom Item 1":
                        MessageBox.Show("Custom Item 1 clicked.","TrayIcon",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                        break;
                }
            }
            catch (Exception ex) { App.ReportError(ex,true); }
        }

        private void OnTrayIconHideWhenMinimizedChanged(object sender,EventArgs e) {
            //Event handler for tray icon HideWhenMinimizedChanged event
            //If the form is minimized set its taskbar visibility per HideWhenMinimized
            if (this.WindowState == FormWindowState.Minimized) this.Visible = !this.mTrayIcon.HideWhenMinimized;
        }
        private void OnTrayIconUnhide(object sender,EventArgs e) {
            //Event handler for tray icon Unhide event
            //Show this application in a maximized state
            this.WindowState = FormWindowState.Maximized;
            this.Visible = true;
            this.Activate();
        }
        private void OnTrayIconBalloonTipClicked(object sender,BalloonTipEventArgs e) {
            //Event handler for tray icon BalloonTipClicked event
            MessageBox.Show(e.Text,e.Title,MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
        }
        private void OnTrayIconError(object sender,TrayIconErrorEventArgs e) { App.ReportError(e.Exception,true); }
    }
}
