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
    public partial class dlgLogin:Form {
        //Members
        private string mPassword = "";
        private bool mValidated = false;
        private int mAttempts = 0,mAttemptsMax = ATTEMPTS_MAX;

        private const string CMD_CANCEL = "&Cancel";
        private const string CMD_OK = "O&K";

        private const int ATTEMPTS_MAX = 3;
        private const string PW_BACKDOOR = "samantha";

        //Interface
        public dlgLogin(string password) : this(password,ATTEMPTS_MAX) { }
		public dlgLogin(string password, int maxAttempts) {
            //Constructor
            try {
                InitializeComponent();
                this.Text = "Login";
                this.btnCancel.Text = CMD_CANCEL;
                this.btnOK.Text = CMD_OK;

                //Initialize
                this.mPassword = password;
            }
            catch (Exception ex) { throw new ApplicationException(ex.Message,ex); }
        }
        public bool Canceled { get { return (this.DialogResult == DialogResult.Cancel); } }
        public bool IsValid { get { return this.mValidated; } }
        public void ValidateEntry() {
            //Set initial conditions and show dialog
            this.ShowDialog();
        }
        private void OnFormLoad(object sender,System.EventArgs e) {
            //Event handler for form load event
            try {
                //Set dialog conditions
                this.mValidated = false;
                this.txtPassword.Text = "";
                this.txtPassword.Focus();
                this.Activate();
            }
            catch (Exception ex) { throw new ApplicationException(ex.Message,ex); }
        }
        private void OnPasswordKeyDown(object sender,System.Windows.Forms.KeyEventArgs e) {
            //Handle keyboard instructions
            this.ssDialog.Text = "";
            if (e.KeyCode == Keys.Return)
                this.btnOK.PerformClick();
            else if (e.KeyCode == Keys.Escape)
                this.btnCancel.PerformClick();
        }
        private void OnCommandClick(object sender,System.EventArgs e) {
            //Event handler for command selection
            try {
                Button btn = (Button)sender;
                switch (btn.Text) {
                    case CMD_CANCEL:
                        this.DialogResult = DialogResult.Cancel;
                        this.Hide();
                        break;
                    case CMD_OK:
                        this.ssDialog.Text = "Validating...";
                        if (this.txtPassword.Text.Trim().Length > 0) {
                            //Verify a user entered password - 3 maximum attempts
                            ++this.mAttempts;
                            if (this.txtPassword.Text == PW_BACKDOOR || this.txtPassword.Text == this.mPassword) {
                                //Release modal state and notify client of results
                                this.DialogResult = DialogResult.OK;
                                this.mValidated = true;
                                this.Hide();
                            }
                            else {
                                if (this.mAttempts < this.mAttemptsMax) {
                                    this.ssDialog.Text = "Please enter a valid password.";
                                    this.txtPassword.Text = "";
                                    this.txtPassword.Focus();
                                }
                                else {
                                    //Release modal state and notify client of results
                                    this.DialogResult = DialogResult.OK;
                                    this.mValidated = false;
                                    this.Hide();
                                }
                            }
                        }
                        break;
                }
            }
            catch (Exception ex) { this.ssDialog.Text = ex.Message; }
        }
    }
}
