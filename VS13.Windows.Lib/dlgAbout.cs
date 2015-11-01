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
    public partial class dlgAbout:Form {
        //Members
        private const string CMD_CLOSE = "&Close";

        //Interface
        public dlgAbout() : this("Unknown Application","Version: Unknown","Copyright: Unknown","") { }
		public dlgAbout(string description, string version, string copyright) : this(description,version,copyright,"") { }
        public dlgAbout(string description,string version,string copyright,string updated) {
            //Constructor
            try {
                //Required for Windows Form Designer support
                InitializeComponent();
                this.cmdDialog.Text = CMD_CLOSE;

                //Set labels for app description, version, and copyright, and update
                this.Text = "About " + description;
                this.lblAppName.Text = description;
                this.lblVersion.Text = version;
                this.lblCopyright.Text = copyright;
                this.lblUpdated.Text = updated;
            }
            catch (Exception ex) { throw new ApplicationException(ex.Message,ex); }
        }
        private void OnCmdClick(object sender,System.EventArgs e) {
            //Event handler for button commands
            try {
                Button btn = (Button)sender;
                switch (btn.Text) {
                    case CMD_CLOSE:
                        //Close the dialog
                        this.DialogResult = DialogResult.Cancel;
                        this.Close();
                        break;
                }
            }
            catch { }
        }
    }
}
