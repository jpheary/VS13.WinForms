using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using VS13.Windows;

namespace VS13 {
    //
    public partial class frmMain:Form {
        //Members
        private MessageManager mMessageMgr = null;

        //Interface
        public frmMain() {
            //Constructor
            try {
                //Required for Windows Form Designer support
                InitializeComponent();
                this.Text = App.Product;
                #region Splash Screen Support
                Splash.Start(App.Product,Assembly.GetExecutingAssembly(),App.Copyright);
                Thread.Sleep(3000);
                #endregion

                //Create data and UI services
                this.mMessageMgr = new MessageManager(this.ssMain.StatusLabel,1000,3000);
            }
            catch (Exception ex) { Splash.Close(); throw new ApplicationException("Startup Failure",ex); }
        }
        private void OnFormLoad(object sender,System.EventArgs e) {
            //Load conditions
            this.Cursor = Cursors.WaitCursor;
            try {
                //Initialize controls
                Splash.Close();
                this.Visible = true;
                this.mMessageMgr.AddMessage("Loading...");
                Application.DoEvents();
                #region Set user preferences
                try {
                    this.WindowState = global::VS13.Properties.Settings.Default.WindowState;
                    switch (this.WindowState) {
                        case FormWindowState.Maximized: break;
                        case FormWindowState.Minimized: break;
                        case FormWindowState.Normal:
                            this.Location = global::VS13.Properties.Settings.Default.Location;
                            this.Size = global::VS13.Properties.Settings.Default.Size;
                            break;
                    }
                    this.Font = this.msMain.Font = this.tsMain.Font = this.ssMain.Font = global::VS13.Properties.Settings.Default.Font;
                    this.msViewToolbar.Checked = this.tsMain.Visible = global::VS13.Properties.Settings.Default.Toolbar;
                    this.msViewStatusBar.Checked = this.ssMain.Visible = global::VS13.Properties.Settings.Default.StatusBar;
                    App.CheckVersion();
                }
                catch (Exception ex) { App.ReportError(ex,true); }
                #endregion

                //Set control defaults
                ServiceInfo si = DataGateway.GetServiceInfo();
                this.ssMain.SetOnlineStatus(OnlineIcon.On,si.Connection);
                this.ssMain.User1Label.Width = 144;
                this.ssMain.User1Label.Text = RoleServiceGateway.GetRoleForCurrentUser();
                this.ssMain.User1Label.ToolTipText = "User role";
            }
            catch (Exception ex) { App.ReportError(ex,true); }
            finally { setUserServices(); this.Cursor = Cursors.Default; }
        }
        private void OnFormClosing(object sender,FormClosingEventArgs e) {
            //Event handler for form closing event
            if (!e.Cancel) {
                //Save settings
                global::VS13.Properties.Settings.Default.WindowState = this.WindowState;
                global::VS13.Properties.Settings.Default.Location = this.Location;
                global::VS13.Properties.Settings.Default.Size = this.Size;
                global::VS13.Properties.Settings.Default.Font = this.Font;
                global::VS13.Properties.Settings.Default.Toolbar = this.msViewToolbar.Checked;
                global::VS13.Properties.Settings.Default.StatusBar = this.msViewStatusBar.Checked;
                global::VS13.Properties.Settings.Default.Save();
            }
        }

        #region User Services: OnItemClick()
        private void OnItemClick(object sender,System.EventArgs e) {
            //Menu services
            try {
                ToolStripItem menu = (ToolStripItem)sender;
                switch (menu.Name) {
                    case "msViewFont":
                    case "tsFont":
                        FontDialog fd = new FontDialog();
                        fd.FontMustExist = true;
                        fd.Font = this.Font;
                        if (fd.ShowDialog() == DialogResult.OK) this.Font = this.msMain.Font = this.tsMain.Font = this.ssMain.Font = fd.Font;
                        break;
                    case "msViewToolbar":
                        this.msViewToolbar.Checked = (!this.msViewToolbar.Checked);
                        this.tsMain.Visible = this.msViewToolbar.Checked;
                        break;
                    case "msViewStatusBar":
                        this.msViewStatusBar.Checked = (!this.msViewStatusBar.Checked);
                        this.ssMain.Visible = this.msViewStatusBar.Checked;
                        break;
                    case "msHelpAbout": 
                        new dlgAbout(App.Description,App.Version,App.Copyright,App.Configuration).ShowDialog(this); 
                        break;
                }
            }
            catch (Exception ex) { App.ReportError(ex,true); }
            finally { setUserServices(); this.Cursor = Cursors.Default; }
        }
        #endregion
        #region Local Services: setUserServices()
        private void setUserServices() {
            //Set user services
            try {
                //Set menu states 
                this.mMessageMgr.AddMessage("Setting services...");
                this.msFileExit.Enabled = true;
                this.msViewFont.Enabled = this.tsFont.Enabled = RoleServiceGateway.IsSalesRep;
                this.msViewToolbar.Enabled = this.msViewStatusBar.Enabled = true;
                this.msHelpAbout.Enabled = true;

                ServiceInfo si = DataGateway.GetServiceInfo();
                this.ssMain.SetOnlineStatus(OnlineIcon.On,si.Connection);
            }
            catch (Exception ex) { App.ReportError(ex,false); }
            finally { Application.DoEvents(); }
        }
        #endregion
    }
}
