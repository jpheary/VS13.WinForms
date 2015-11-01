using System;
using System.Configuration;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace VS13 {
    //
    public partial class Main:Form {
        //Members

        //Interface
        public Main() {
			//Constructor
			try {
                InitializeComponent();
                InitializeToolbox();
            }
            catch(Exception ex) { throw new ApplicationException("Startup Failure",ex); }
        }
        private void OnFormLoad(object sender,EventArgs e) {
            //Event handler for form load event
            this.Cursor = Cursors.WaitCursor;
            try {
                //Initialize controls
                this.Visible = true;
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
                    this.Font = this.msMain.Font = this.tsMain.Font = this.ssMain.Font = this.ssMain.Font = global::VS13.Properties.Settings.Default.Font;
                    this.msViewToolbar.Checked = this.tsMain.Visible = global::VS13.Properties.Settings.Default.Toolbar;
                    this.msViewStatusBar.Checked = this.ssMain.Visible = global::VS13.Properties.Settings.Default.StatusBar;
                }
                catch (Exception ex) { reportError(ex); }
                #endregion

                //Data
                this.msViewRefresh.PerformClick();

                //Toolbox
                OnLeaveToolbox(null,EventArgs.Empty);
            }
            catch(Exception ex) { reportError(ex); }
            finally { this.Cursor = Cursors.Default; }
        }
        private void OnFormClosing(object sender,FormClosingEventArgs e) {
            if(!e.Cancel) {
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
        private void OnItemClick(object sender,EventArgs e) {
            //Event handler for menu/toolbar item clicked
            try {
                ToolStripItem item = (ToolStripItem)sender;
                switch (item.Name) {
                    case "msFileNew":
                    case "tsNew":
                    case "csNew":
                        ChildWindow win = new ChildWindow();
                        win.MdiParent = this;
                        //win.Activated += new EventHandler(OnWindowActivated);
                        //win.Deactivate += new EventHandler(OnWindowDeactivated);
                        //win.FormClosing += new FormClosingEventHandler(OnWindowClosing);
                        //win.FormClosed += new FormClosedEventHandler(OnWindowClosed);
                        win.WindowState = FormWindowState.Maximized; 
                        win.Show();
                        break;
                    case "msFileOpen":
                    case "tsOpen":
                    case "csOpen":
                        break;
                    case "msFileSaveAs":
                        break;
                    case "msFilePageSetup":
                        break;
                    case "msFilePrint":
                        break;
                    case "msFilePrintPreview":
                        break;
                    case "msFileExit":
                        this.Close();
                        break;
                    case "msViewRefresh":
                    case "tsRefresh":
                        DataSet ds = BlogGateway.ViewBlog();
                        this.txtBlog.Clear();
                        for (int i = 0;i < ds.Tables["BlogTable"].Rows.Count;i++) {
                            string _entry = ds.Tables["BlogTable"].Rows[i]["Date"] + " [" + ds.Tables["BlogTable"].Rows[i]["UserID"] + "]\r\n" + ds.Tables["BlogTable"].Rows[i]["Comment"] + "\r\n";
                            this.txtBlog.AppendText(_entry);
                            this.txtBlog.AppendText("\r\n");
                        }
                        break;
                    case "msViewFont":
                        FontDialog fd = new FontDialog();
                        fd.FontMustExist = true;
                        fd.Font = this.Font;
                        if (fd.ShowDialog() == DialogResult.OK)
                            this.Font = this.msMain.Font = this.tsMain.Font = this.ssMain.Font = fd.Font;
                        break;
                    case "msViewToolbar": this.tsMain.Visible = (this.msViewToolbar.Checked = (!this.msViewToolbar.Checked)); break;
                    case "msViewStatusBar": this.ssMain.Visible = (this.msViewStatusBar.Checked = (!this.msViewStatusBar.Checked)); break;
                    case "msToolsConfig": break;
                    case "msWinCascade": this.LayoutMdi(MdiLayout.Cascade); break;
                    case "msWinTileH": this.LayoutMdi(MdiLayout.TileHorizontal); break;
                    case "msWinTileV": this.LayoutMdi(MdiLayout.TileVertical); break;
                    case "msHelpAbout": break;
                }
            }
            catch (Exception ex) { reportError(ex); }
            finally { setUserServices(); this.Cursor = Cursors.Default; }
        }

        #region Toolbox: InitializeToolbox(), OnToolboxResize(), ...
        private const string AUTOHIDE_OFF = "X";
        private const string AUTOHIDE_ON = "-";
        private void InitializeToolbox() {
            //Configure toolbox size, state, and event handlers
            try {
                //Iterate through control heirarchy and set handlers
                foreach (Control ctl1 in this.pnlToolbox.Controls) {
                    System.Diagnostics.Debug.WriteLine(ctl1.Name);
                    ctl1.Enter += new System.EventHandler(this.OnEnterToolbox);
                    ctl1.Leave += new System.EventHandler(this.OnLeaveToolbox);
                    ctl1.MouseEnter += new System.EventHandler(this.OnMouseEnterToolbox);
                    ctl1.MouseLeave += new System.EventHandler(this.OnMouseLeaveToolbox);
                    foreach (Control ctl2 in ctl1.Controls) {
                        System.Diagnostics.Debug.WriteLine("\t" + ctl2.Name);
                        ctl2.Enter += new System.EventHandler(this.OnEnterToolbox);
                        ctl2.Leave += new System.EventHandler(this.OnLeaveToolbox);
                        ctl2.MouseEnter += new System.EventHandler(this.OnMouseEnterToolbox);
                        ctl2.MouseLeave += new System.EventHandler(this.OnMouseLeaveToolbox);
                        foreach (Control ctl3 in ctl2.Controls) {
                            System.Diagnostics.Debug.WriteLine("\t\t" + ctl3.Name);
                            ctl3.Enter += new System.EventHandler(this.OnEnterToolbox);
                            ctl3.Leave += new System.EventHandler(this.OnLeaveToolbox);
                            ctl3.MouseEnter += new System.EventHandler(this.OnMouseEnterToolbox);
                            ctl3.MouseLeave += new System.EventHandler(this.OnMouseLeaveToolbox);
                            foreach (Control ctl4 in ctl3.Controls) {
                                System.Diagnostics.Debug.WriteLine("\t\t\t" + ctl4.Name);
                                ctl4.Enter += new System.EventHandler(this.OnEnterToolbox);
                                ctl4.Leave += new System.EventHandler(this.OnLeaveToolbox);
                                ctl4.MouseEnter += new System.EventHandler(this.OnMouseEnterToolbox);
                                ctl4.MouseLeave += new System.EventHandler(this.OnMouseLeaveToolbox);
                                foreach (Control ctl5 in ctl4.Controls) {
                                    System.Diagnostics.Debug.WriteLine("\t\t\t\t" + ctl5.Name);
                                    ctl5.Enter += new System.EventHandler(this.OnEnterToolbox);
                                    ctl5.Leave += new System.EventHandler(this.OnLeaveToolbox);
                                    ctl5.MouseEnter += new System.EventHandler(this.OnMouseEnterToolbox);
                                    ctl5.MouseLeave += new System.EventHandler(this.OnMouseLeaveToolbox);
                                }
                            }
                        }
                    }
                }

                //Configure auto-hide
                this.pnlToolbox.Width = global::VS13.Properties.Settings.Default.ToolboxWidth;
                this.lblPin.Text = global::VS13.Properties.Settings.Default.ToolboxAutoHide ? AUTOHIDE_ON : AUTOHIDE_OFF;
                this.lblPin.Click += new System.EventHandler(this.OnToggleAutoHide);
                this.tmrAutoHide.Interval = 500;
                this.tmrAutoHide.Tick += new System.EventHandler(this.OnAutoHideToolbox);

                //Show toolbar as inactive
                this.lblToolbox.BackColor = System.Drawing.SystemColors.Control;
                this.lblToolbox.ForeColor = System.Drawing.SystemColors.ControlText;
                this.lblPin.BackColor = System.Drawing.SystemColors.Control;
                this.lblPin.ForeColor = System.Drawing.SystemColors.ControlText;
            }
            catch (Exception ex) { reportError(ex); }
        }
        private void OnEnterToolbox(object sender,System.EventArgs e) {
            //Occurs when the control becomes the active control on the form
            try {
                //Disable auto-hide when active; show toolbar as active
                if (this.tmrAutoHide.Enabled) { this.tmrAutoHide.Stop(); this.tmrAutoHide.Enabled = false; }
                this.lblToolbox.BackColor = this.lblPin.BackColor = SystemColors.ActiveCaption;
                this.lblToolbox.ForeColor = this.lblPin.ForeColor = SystemColors.ActiveCaptionText;
            }
            catch { }
        }
        private void OnLeaveToolbox(object sender,System.EventArgs e) {
            //Occurs when the control is no longer the active control on the form
            try {
                //Enable auto-hide when inactive and not pinned; show toolbar as inactive
                this.lblToolbox.BackColor = this.lblPin.BackColor = System.Drawing.SystemColors.Control;
                this.lblToolbox.ForeColor = this.lblPin.ForeColor = System.Drawing.SystemColors.ControlText;
                if (this.lblPin.Text == AUTOHIDE_ON) { this.tmrAutoHide.Enabled = true; this.tmrAutoHide.Start(); }
            }
            catch { }
        }
        private void OnMouseEnterToolbox(object sender,System.EventArgs e) {
            //Occurs when the mouse enters the visible part of the control
            try {
                //Auto-open if not pinned and toolbar is closed; disable auto-hide if on
                if (this.lblPin.Text == AUTOHIDE_ON && this.pnlToolbox.Width == 25)
                    this.pnlToolbox.Width = global::VS13.Properties.Settings.Default.ToolboxWidth;
                if (this.tmrAutoHide.Enabled) { this.tmrAutoHide.Stop(); this.tmrAutoHide.Enabled = false; }
            }
            catch { }
        }
        private void OnMouseLeaveToolbox(object sender,System.EventArgs e) {
            //Occurs when the mouse leaves the visible part of the control
            try {
                //Enable auto-hide when inactive and unpinned
                if (this.lblToolbox.BackColor == SystemColors.Control && this.lblPin.Text == AUTOHIDE_ON) { this.tmrAutoHide.Enabled = true; this.tmrAutoHide.Start(); }
            }
            catch { }
        }
        private void OnToggleAutoHide(object sender,System.EventArgs e) { this.lblPin.Text = this.lblPin.Text == AUTOHIDE_OFF ? AUTOHIDE_ON : AUTOHIDE_OFF; }
        private void OnAutoHideToolbox(object sender,System.EventArgs e) {
            //Toolbox timer event handler
            try {
                //Auto-close timer
                this.tmrAutoHide.Stop();
                this.tmrAutoHide.Enabled = false;
                global::VS13.Properties.Settings.Default.ToolboxWidth = this.pnlToolbox.Width;
                this.pnlToolbox.Width = 25;
            }
            catch { }
        }
        private void OnSplitterMoving(object sender,SplitterCancelEventArgs e) {
            try {
                this.lblToolbox.BackColor = this.lblPin.BackColor = SystemColors.ActiveCaption;
                this.lblToolbox.ForeColor = this.lblPin.ForeColor = SystemColors.ActiveCaptionText;
                if (this.tmrAutoHide.Enabled) { this.tmrAutoHide.Stop(); this.tmrAutoHide.Enabled = false; }
            }
            catch (Exception ex) { reportError(ex); }
        }
        #endregion
        private void OnBlogKeyUp(object sender,KeyEventArgs e) {
            //Event handler for new blog entry
            Cursor.Current = Cursors.WaitCursor;
            try {
                if (e.KeyCode == Keys.Enter) {
                    BlogEntry entry = new BlogEntry();
                    entry.Date = DateTime.Now;
                    entry.Comment = this.txtComment.Text;
                    entry.UserID = Environment.UserName;
                    if (BlogGateway.AddBlogEntry(entry)) {
                        this.txtComment.Clear();
                        lock (this.txtBlog) {
                            this.msViewRefresh.PerformClick();
                        }

                    }
                }
            }
            catch (Exception ex) { reportError(ex); }
            finally { Cursor.Current = Cursors.Default; }
        }

        private void setUserServices() {
            //Set user services depending upon an item selected in the grid
            try {
                this.msFileNew.Enabled = this.csNew.Enabled = this.tsNew.Enabled = true;
                this.msFileOpen.Enabled = this.csOpen.Enabled = this.tsOpen.Enabled = true;
                this.msFileSaveAs.Enabled = true;
                this.msFilePageSetup.Enabled = true;
                this.msFilePrint.Enabled = true;
                this.msFilePrintPreview.Enabled = true;
                this.msFileExit.Enabled = true;
                this.msViewRefresh.Enabled = this.tsRefresh.Enabled = true;
                this.msViewToolbar.Enabled = this.msViewStatusBar.Enabled = true;
                this.msToolsConfig.Enabled = true;
                this.msHelpAbout.Enabled = true;
            }
            catch (Exception ex) { reportError(ex); }
        }
        private void reportError(Exception ex) { }
    }
}
