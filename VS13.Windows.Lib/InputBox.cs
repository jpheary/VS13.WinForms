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
    public partial class InputBox:Form {
        //Members
        private const string CMD_CANCEL = "&Cancel";
        private const string CMD_OK = "O&K";

        //Interface
        public InputBox(string message,string data,string title) {
            //Constructor
            try {
                InitializeComponent();
                this.btnOk.Text = CMD_OK;
                this.btnCancel.Text = CMD_CANCEL;

                //Set message, data, and titlebar caption
                this.lblMessage.Text = message;
                this.txtInput.Text = data;
                this.Text = title;
            }
            catch (Exception ex) { throw ex; }
        }
        private void OnFormLoad(object sender,System.EventArgs e) {
            //Initialize controls - set default values
            try {
                //Set initial service states
                this.txtInput.Focus();
                ValidateForm(null,null);
            }
            catch (Exception ex) { throw new ApplicationException(ex.Message,ex); }
        }
        private void ValidateForm(object sender,System.EventArgs e) {
            //Event handler for changes to input value
            this.btnOk.Enabled = (this.txtInput.Text.Trim().Length > 0);
        }
        private void OnCmdClick(object sender,System.EventArgs e) {
            //Command button handler
            try {
                Button btn = (Button)sender;
                switch (btn.Text) {
                    case CMD_CANCEL: this.DialogResult = DialogResult.Cancel; break;
                    case CMD_OK: this.DialogResult = DialogResult.OK; break;
                }
                this.Close();
            }
            catch (Exception) { }
        }
    }
}
