namespace VS13.Windows {
    partial class VS13StatusStrip {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ssControl = new System.Windows.Forms.StatusStrip();
            this.slStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.slUser1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slUser2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.slOnline = new System.Windows.Forms.ToolStripStatusLabel();
            this.ssControl.SuspendLayout();
            this.SuspendLayout();
            // 
            // ssControl
            // 
            this.ssControl.AutoSize = false;
            this.ssControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ssControl.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.slStatus,
            this.slUser1,
            this.slUser2,
            this.slOnline});
            this.ssControl.Location = new System.Drawing.Point(0, 0);
            this.ssControl.Name = "ssControl";
            this.ssControl.ShowItemToolTips = true;
            this.ssControl.Size = new System.Drawing.Size(437, 20);
            this.ssControl.SizingGrip = false;
            this.ssControl.TabIndex = 14;
            // 
            // slStatus
            // 
            this.slStatus.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.slStatus.Name = "slStatus";
            this.slStatus.Size = new System.Drawing.Size(276, 15);
            this.slStatus.Spring = true;
            this.slStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // slUser1
            // 
            this.slUser1.AutoSize = false;
            this.slUser1.AutoToolTip = true;
            this.slUser1.Name = "slUser1";
            this.slUser1.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.slUser1.Size = new System.Drawing.Size(50, 15);
            this.slUser1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // slUser2
            // 
            this.slUser2.AutoSize = false;
            this.slUser2.AutoToolTip = true;
            this.slUser2.Name = "slUser2";
            this.slUser2.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.slUser2.Size = new System.Drawing.Size(50, 15);
            this.slUser2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // slOnline
            // 
            this.slOnline.AutoSize = false;
            this.slOnline.AutoToolTip = true;
            this.slOnline.Name = "slOnline";
            this.slOnline.Overflow = System.Windows.Forms.ToolStripItemOverflow.Never;
            this.slOnline.Size = new System.Drawing.Size(15, 15);
            // 
            // VS13StatusStrip
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ssControl);
            this.Name = "VS13StatusStrip";
            this.Size = new System.Drawing.Size(437, 20);
            this.Resize += new System.EventHandler(this.OnControlResize);
            this.ssControl.ResumeLayout(false);
            this.ssControl.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.StatusStrip ssControl;
        private System.Windows.Forms.ToolStripStatusLabel slStatus;
        private System.Windows.Forms.ToolStripStatusLabel slUser1;
        private System.Windows.Forms.ToolStripStatusLabel slUser2;
        private System.Windows.Forms.ToolStripStatusLabel slOnline;
    }
}
