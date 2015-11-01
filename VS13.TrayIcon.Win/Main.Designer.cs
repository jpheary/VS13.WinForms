namespace VS13 {
    partial class frmMain {
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this._lblAlert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // _lblAlert
            // 
            this._lblAlert.AutoSize = true;
            this._lblAlert.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._lblAlert.Location = new System.Drawing.Point(139, 22);
            this._lblAlert.Name = "_lblAlert";
            this._lblAlert.Size = new System.Drawing.Size(324, 26);
            this._lblAlert.TabIndex = 0;
            this._lblAlert.Text = "Click this form for a sample alert";
            this._lblAlert.Click += new System.EventHandler(this.OnFormClick);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 268);
            this.Controls.Add(this._lblAlert);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tray Icon";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.Click += new System.EventHandler(this.OnFormClick);
            this.Resize += new System.EventHandler(this.OnFormResize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label _lblAlert;
    }
}

