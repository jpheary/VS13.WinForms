using System;
using System.Threading;
using System.Windows.Forms;

namespace VS13 {
    //
    public partial class frmMain:Form {
        //Members

        //Interface
        public frmMain() {
            //Constructor
            InitializeComponent();
            ActiveGateway.GatewayCacheUpdated += new EventHandler(OnGatewayCacheUpdated);
        }

        private void OnFormLoad(object sender,EventArgs e) {
            //Event handler for form laod event
            this.txtData.Text = "";
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
        }

        private void OnRefresh(object sender,EventArgs e) { 
            ActiveGateway.Refresh(); 
        }
        private void OnStartGateway(object sender,EventArgs e) {
            this.btnStart.Enabled = false;
            this.btnStop.Enabled = true;
            ActiveGateway.Start();
        }
        private void OnStopGateway(object sender,EventArgs e) {
            this.btnStart.Enabled = true;
            this.btnStop.Enabled = false;
            ActiveGateway.Stop();
        }
        private void OnGatewayCacheUpdated(object sender,EventArgs e) {
            //Event handler for issues changed
            if(this.txtData.InvokeRequired) {
                this.txtData.Invoke(new EventHandler(OnGatewayCacheUpdated),new object[] { sender,e });
            }
            else {
                this.txtData.Text += "\n\n" + ActiveGateway.Data.GetXml();
            }
        }
        private void OnDataDoubleClick(object sender,EventArgs e) { this.txtData.Text = "";  }
    }
}
