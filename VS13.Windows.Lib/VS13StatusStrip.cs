using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VS13.Windows {
    //
    public partial class VS13StatusStrip:UserControl {
        //Members

        //Interface
        public VS13StatusStrip() {
            //Constructor
            InitializeComponent();
        }
        public override Font Font {
            get {
                return base.Font;
            }
            set {
                base.Font = this.slStatus.Font = this.slUser1.Font = this.slUser2.Font = this.slOnline.Font = value;
            }
        }
        public ToolStripStatusLabel StatusLabel { get { return this.slStatus; } }
        public ToolStripStatusLabel User1Label { get { return this.slUser1; } }
        public ToolStripStatusLabel User2Label { get { return this.slUser2; } }
        public ToolStripStatusLabel OnlineLabel { get { return this.slOnline; } }
        public string StatusText { get { return this.slStatus.Text; } set { this.slStatus.Text = this.slStatus.ToolTipText = value; } }
        public void SetOnlineStatus(OnlineIcon image,string tooltip) { this.slOnline.Image = (image == OnlineIcon.On) ? global::VS13.Properties.Resources.online : global::VS13.Properties.Resources.offline; this.slOnline.ToolTipText = tooltip; }
        private void OnControlResize(object sender,System.EventArgs e) {
            //Event hanlder for control resize event
            this.slOnline.Width = this.ssControl.Height;
        }
    }
}
