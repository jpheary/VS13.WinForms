using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS13.Windows {
    //
    public partial class dlgSplash:Form {
        //Members

        //Interface
        public dlgSplash(string title,string version,string copyright) {
            //Constructor
            try {
                InitializeComponent();
                this.lblTitle.Text = title;
                this.lblVersion.Text = version;
                this.lblCopyRight.Text = copyright;
            }
            catch (Exception ex) { throw new ApplicationException(ex.Message,ex); }
        }
        private void OnFormLoad(object sender,System.EventArgs e) {
            //Event handler for form load event
            this.Cursor = Cursors.WaitCursor;
            try {
                this.Refresh();
                this.BringToFront();
                this.Focus();
            }
            catch { }
            finally { this.Cursor = Cursors.WaitCursor; }
        }
        private void OnFormClosing(object sender,FormClosingEventArgs e) {
            try { this.SendToBack(); } catch { }
        }
        private void OnKeyPress(object sender,System.Windows.Forms.KeyPressEventArgs e) {
            //Event handler for form keypress eventt
            try {
                switch (e.KeyChar) {
                    case (char)13: e.Handled = true; this.Close(); break;
                    case (char)32: e.Handled = true; this.Close(); break;
                    default: e.Handled = true; break;
                }
            }
            catch { }
        }

    }
}
