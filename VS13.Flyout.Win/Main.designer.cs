namespace VS13 {
    partial class Main {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
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
            this.components = new System.ComponentModel.Container();
            this.msMain = new System.Windows.Forms.MenuStrip();
            this.msFile = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileNew = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.msFileOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.msFileSaveAs = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileSep3 = new System.Windows.Forms.ToolStripSeparator();
            this.msFilePageSetup = new System.Windows.Forms.ToolStripMenuItem();
            this.msFilePrint = new System.Windows.Forms.ToolStripMenuItem();
            this.msFilePrintPreview = new System.Windows.Forms.ToolStripMenuItem();
            this.msFileSep4 = new System.Windows.Forms.ToolStripSeparator();
            this.msFileExit = new System.Windows.Forms.ToolStripMenuItem();
            this.msEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.msView = new System.Windows.Forms.ToolStripMenuItem();
            this.msViewRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.msViewSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.msViewFont = new System.Windows.Forms.ToolStripMenuItem();
            this.msViewSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.msViewToolbar = new System.Windows.Forms.ToolStripMenuItem();
            this.msViewStatusBar = new System.Windows.Forms.ToolStripMenuItem();
            this.msTools = new System.Windows.Forms.ToolStripMenuItem();
            this.msToolsConfig = new System.Windows.Forms.ToolStripMenuItem();
            this.msWin = new System.Windows.Forms.ToolStripMenuItem();
            this.msWinCascade = new System.Windows.Forms.ToolStripMenuItem();
            this.msWinTileH = new System.Windows.Forms.ToolStripMenuItem();
            this.msWinTileV = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelp = new System.Windows.Forms.ToolStripMenuItem();
            this.msHelpAbout = new System.Windows.Forms.ToolStripMenuItem();
            this.tsMain = new System.Windows.Forms.ToolStrip();
            this.tsNew = new System.Windows.Forms.ToolStripButton();
            this.tsSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.tsOpen = new System.Windows.Forms.ToolStripButton();
            this.tsSep2 = new System.Windows.Forms.ToolStripSeparator();
            this.tsRefresh = new System.Windows.Forms.ToolStripButton();
            this.csMain = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.csNew = new System.Windows.Forms.ToolStripMenuItem();
            this.csSep1 = new System.Windows.Forms.ToolStripSeparator();
            this.csOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.scMain = new System.Windows.Forms.Splitter();
            this.tabBlog = new System.Windows.Forms.TabPage();
            this.scBlog = new System.Windows.Forms.SplitContainer();
            this.txtBlog = new System.Windows.Forms.TextBox();
            this.txtComment = new System.Windows.Forms.TextBox();
            this.tabToolbox = new System.Windows.Forms.TabControl();
            this.pnlToolbox = new System.Windows.Forms.Panel();
            this.pnlToolboxTitlebar = new System.Windows.Forms.Panel();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblToolbox = new System.Windows.Forms.Label();
            this.tmrAutoHide = new System.Windows.Forms.Timer(this.components);
            this.ssMain = new System.Windows.Forms.StatusStrip();
            this.msMain.SuspendLayout();
            this.tsMain.SuspendLayout();
            this.csMain.SuspendLayout();
            this.tabBlog.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBlog)).BeginInit();
            this.scBlog.Panel1.SuspendLayout();
            this.scBlog.Panel2.SuspendLayout();
            this.scBlog.SuspendLayout();
            this.tabToolbox.SuspendLayout();
            this.pnlToolbox.SuspendLayout();
            this.pnlToolboxTitlebar.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMain
            // 
            this.msMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFile,
            this.msEdit,
            this.msView,
            this.msTools,
            this.msWin,
            this.msHelp});
            this.msMain.Location = new System.Drawing.Point(0, 0);
            this.msMain.MdiWindowListItem = this.msWin;
            this.msMain.Name = "msMain";
            this.msMain.Size = new System.Drawing.Size(854, 24);
            this.msMain.TabIndex = 0;
            // 
            // msFile
            // 
            this.msFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msFileNew,
            this.msFileSep1,
            this.msFileOpen,
            this.msFileSep2,
            this.msFileSaveAs,
            this.msFileSep3,
            this.msFilePageSetup,
            this.msFilePrint,
            this.msFilePrintPreview,
            this.msFileSep4,
            this.msFileExit});
            this.msFile.Name = "msFile";
            this.msFile.Size = new System.Drawing.Size(37, 20);
            this.msFile.Text = "&File";
            // 
            // msFileNew
            // 
            this.msFileNew.Name = "msFileNew";
            this.msFileNew.Size = new System.Drawing.Size(152, 22);
            this.msFileNew.Text = "&New...";
            this.msFileNew.Click += new System.EventHandler(this.OnItemClick);
            // 
            // msFileSep1
            // 
            this.msFileSep1.Name = "msFileSep1";
            this.msFileSep1.Size = new System.Drawing.Size(149, 6);
            // 
            // msFileOpen
            // 
            this.msFileOpen.Name = "msFileOpen";
            this.msFileOpen.Size = new System.Drawing.Size(152, 22);
            this.msFileOpen.Text = "&Open...";
            this.msFileOpen.Click += new System.EventHandler(this.OnItemClick);
            // 
            // msFileSep2
            // 
            this.msFileSep2.Name = "msFileSep2";
            this.msFileSep2.Size = new System.Drawing.Size(149, 6);
            // 
            // msFileSaveAs
            // 
            this.msFileSaveAs.Name = "msFileSaveAs";
            this.msFileSaveAs.Size = new System.Drawing.Size(152, 22);
            this.msFileSaveAs.Text = "Save &As...";
            this.msFileSaveAs.Click += new System.EventHandler(this.OnItemClick);
            // 
            // msFileSep3
            // 
            this.msFileSep3.Name = "msFileSep3";
            this.msFileSep3.Size = new System.Drawing.Size(149, 6);
            // 
            // msFilePageSetup
            // 
            this.msFilePageSetup.Name = "msFilePageSetup";
            this.msFilePageSetup.Size = new System.Drawing.Size(152, 22);
            this.msFilePageSetup.Text = "Page &Setup...";
            this.msFilePageSetup.Click += new System.EventHandler(this.OnItemClick);
            // 
            // msFilePrint
            // 
            this.msFilePrint.Name = "msFilePrint";
            this.msFilePrint.Size = new System.Drawing.Size(152, 22);
            this.msFilePrint.Text = "&Print...";
            this.msFilePrint.Click += new System.EventHandler(this.OnItemClick);
            // 
            // msFilePrintPreview
            // 
            this.msFilePrintPreview.Name = "msFilePrintPreview";
            this.msFilePrintPreview.Size = new System.Drawing.Size(152, 22);
            this.msFilePrintPreview.Text = "Print Pre&view...";
            this.msFilePrintPreview.Click += new System.EventHandler(this.OnItemClick);
            // 
            // msFileSep4
            // 
            this.msFileSep4.Name = "msFileSep4";
            this.msFileSep4.Size = new System.Drawing.Size(149, 6);
            // 
            // msFileExit
            // 
            this.msFileExit.Name = "msFileExit";
            this.msFileExit.Size = new System.Drawing.Size(152, 22);
            this.msFileExit.Text = "E&xit";
            this.msFileExit.Click += new System.EventHandler(this.OnItemClick);
            // 
            // msEdit
            // 
            this.msEdit.Name = "msEdit";
            this.msEdit.Size = new System.Drawing.Size(39, 20);
            this.msEdit.Text = "&Edit";
            // 
            // msView
            // 
            this.msView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msViewRefresh,
            this.msViewSep1,
            this.msViewFont,
            this.msViewSep2,
            this.msViewToolbar,
            this.msViewStatusBar});
            this.msView.Name = "msView";
            this.msView.Size = new System.Drawing.Size(44, 20);
            this.msView.Text = "&View";
            // 
            // msViewRefresh
            // 
            this.msViewRefresh.Name = "msViewRefresh";
            this.msViewRefresh.Size = new System.Drawing.Size(126, 22);
            this.msViewRefresh.Text = "&Refresh";
            this.msViewRefresh.Click += new System.EventHandler(this.OnItemClick);
            // 
            // msViewSep1
            // 
            this.msViewSep1.Name = "msViewSep1";
            this.msViewSep1.Size = new System.Drawing.Size(123, 6);
            // 
            // msViewFont
            // 
            this.msViewFont.Name = "msViewFont";
            this.msViewFont.Size = new System.Drawing.Size(126, 22);
            this.msViewFont.Text = "&Font...";
            this.msViewFont.Click += new System.EventHandler(this.OnItemClick);
            // 
            // msViewSep2
            // 
            this.msViewSep2.Name = "msViewSep2";
            this.msViewSep2.Size = new System.Drawing.Size(123, 6);
            // 
            // msViewToolbar
            // 
            this.msViewToolbar.Name = "msViewToolbar";
            this.msViewToolbar.Size = new System.Drawing.Size(126, 22);
            this.msViewToolbar.Text = "&Toolbar";
            this.msViewToolbar.Click += new System.EventHandler(this.OnItemClick);
            // 
            // msViewStatusBar
            // 
            this.msViewStatusBar.Name = "msViewStatusBar";
            this.msViewStatusBar.Size = new System.Drawing.Size(126, 22);
            this.msViewStatusBar.Text = "Status &Bar";
            this.msViewStatusBar.Click += new System.EventHandler(this.OnItemClick);
            // 
            // msTools
            // 
            this.msTools.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msToolsConfig});
            this.msTools.Name = "msTools";
            this.msTools.Size = new System.Drawing.Size(48, 20);
            this.msTools.Text = "&Tools";
            // 
            // msToolsConfig
            // 
            this.msToolsConfig.Name = "msToolsConfig";
            this.msToolsConfig.Size = new System.Drawing.Size(148, 22);
            this.msToolsConfig.Text = "&Configuration";
            this.msToolsConfig.Click += new System.EventHandler(this.OnItemClick);
            // 
            // msWin
            // 
            this.msWin.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msWinCascade,
            this.msWinTileH,
            this.msWinTileV});
            this.msWin.Name = "msWin";
            this.msWin.Size = new System.Drawing.Size(63, 20);
            this.msWin.Text = "&Window";
            // 
            // msWinCascade
            // 
            this.msWinCascade.Image = global::VS13.Properties.Resources.CascadeWindows;
            this.msWinCascade.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.msWinCascade.Name = "msWinCascade";
            this.msWinCascade.Size = new System.Drawing.Size(160, 22);
            this.msWinCascade.Text = "&Cascade";
            this.msWinCascade.Click += new System.EventHandler(this.OnItemClick);
            // 
            // msWinTileH
            // 
            this.msWinTileH.Image = global::VS13.Properties.Resources.ArrangeWindows;
            this.msWinTileH.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.msWinTileH.Name = "msWinTileH";
            this.msWinTileH.Size = new System.Drawing.Size(160, 22);
            this.msWinTileH.Text = "Tile &Horizontally";
            this.msWinTileH.Click += new System.EventHandler(this.OnItemClick);
            // 
            // msWinTileV
            // 
            this.msWinTileV.Image = global::VS13.Properties.Resources.ArrangeSideBySide;
            this.msWinTileV.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.msWinTileV.Name = "msWinTileV";
            this.msWinTileV.Size = new System.Drawing.Size(160, 22);
            this.msWinTileV.Text = "Tile &Vetically";
            this.msWinTileV.Click += new System.EventHandler(this.OnItemClick);
            // 
            // msHelp
            // 
            this.msHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.msHelpAbout});
            this.msHelp.Name = "msHelp";
            this.msHelp.Size = new System.Drawing.Size(44, 20);
            this.msHelp.Text = "&Help";
            // 
            // msHelpAbout
            // 
            this.msHelpAbout.Name = "msHelpAbout";
            this.msHelpAbout.Size = new System.Drawing.Size(143, 22);
            this.msHelpAbout.Text = "&About Flyout";
            this.msHelpAbout.Click += new System.EventHandler(this.OnItemClick);
            // 
            // tsMain
            // 
            this.tsMain.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.tsMain.ImageScalingSize = new System.Drawing.Size(32, 32);
            this.tsMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsNew,
            this.tsSep1,
            this.tsOpen,
            this.tsSep2,
            this.tsRefresh});
            this.tsMain.Location = new System.Drawing.Point(0, 24);
            this.tsMain.Name = "tsMain";
            this.tsMain.Size = new System.Drawing.Size(854, 54);
            this.tsMain.TabIndex = 3;
            // 
            // tsNew
            // 
            this.tsNew.Image = global::VS13.Properties.Resources.NewDocument;
            this.tsNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsNew.Name = "tsNew";
            this.tsNew.Size = new System.Drawing.Size(36, 51);
            this.tsNew.Text = "New";
            this.tsNew.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsNew.ToolTipText = "New";
            this.tsNew.Click += new System.EventHandler(this.OnItemClick);
            // 
            // tsSep1
            // 
            this.tsSep1.Name = "tsSep1";
            this.tsSep1.Size = new System.Drawing.Size(6, 54);
            // 
            // tsOpen
            // 
            this.tsOpen.Image = global::VS13.Properties.Resources.Open;
            this.tsOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsOpen.Name = "tsOpen";
            this.tsOpen.Size = new System.Drawing.Size(40, 51);
            this.tsOpen.Text = "Open";
            this.tsOpen.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsOpen.ToolTipText = "Open";
            this.tsOpen.Click += new System.EventHandler(this.OnItemClick);
            // 
            // tsSep2
            // 
            this.tsSep2.Name = "tsSep2";
            this.tsSep2.Size = new System.Drawing.Size(6, 54);
            // 
            // tsRefresh
            // 
            this.tsRefresh.Image = global::VS13.Properties.Resources.Refresh;
            this.tsRefresh.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.tsRefresh.Name = "tsRefresh";
            this.tsRefresh.Size = new System.Drawing.Size(50, 51);
            this.tsRefresh.Text = "Refresh";
            this.tsRefresh.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.tsRefresh.ToolTipText = "Refresh";
            this.tsRefresh.Click += new System.EventHandler(this.OnItemClick);
            // 
            // csMain
            // 
            this.csMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.csNew,
            this.csSep1,
            this.csOpen});
            this.csMain.Name = "csMain";
            this.csMain.Size = new System.Drawing.Size(104, 54);
            // 
            // csNew
            // 
            this.csNew.Image = global::VS13.Properties.Resources.NewDocument;
            this.csNew.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.csNew.Name = "csNew";
            this.csNew.Size = new System.Drawing.Size(103, 22);
            this.csNew.Text = "&New";
            this.csNew.Click += new System.EventHandler(this.OnItemClick);
            // 
            // csSep1
            // 
            this.csSep1.Name = "csSep1";
            this.csSep1.Size = new System.Drawing.Size(100, 6);
            // 
            // csOpen
            // 
            this.csOpen.Image = global::VS13.Properties.Resources.Open;
            this.csOpen.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.csOpen.Name = "csOpen";
            this.csOpen.Size = new System.Drawing.Size(103, 22);
            this.csOpen.Text = "&Open";
            this.csOpen.Click += new System.EventHandler(this.OnItemClick);
            // 
            // scMain
            // 
            this.scMain.Dock = System.Windows.Forms.DockStyle.Right;
            this.scMain.Location = new System.Drawing.Point(609, 78);
            this.scMain.Name = "scMain";
            this.scMain.Size = new System.Drawing.Size(3, 296);
            this.scMain.TabIndex = 121;
            this.scMain.TabStop = false;
            // 
            // tabBlog
            // 
            this.tabBlog.Controls.Add(this.scBlog);
            this.tabBlog.ImageKey = "search.gif";
            this.tabBlog.Location = new System.Drawing.Point(4, 4);
            this.tabBlog.Name = "tabBlog";
            this.tabBlog.Size = new System.Drawing.Size(210, 264);
            this.tabBlog.TabIndex = 0;
            this.tabBlog.Text = "Blog";
            this.tabBlog.ToolTipText = "Search issue headers";
            // 
            // scBlog
            // 
            this.scBlog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.scBlog.Location = new System.Drawing.Point(0, 0);
            this.scBlog.Name = "scBlog";
            this.scBlog.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // scBlog.Panel1
            // 
            this.scBlog.Panel1.Controls.Add(this.txtBlog);
            // 
            // scBlog.Panel2
            // 
            this.scBlog.Panel2.Controls.Add(this.txtComment);
            this.scBlog.Size = new System.Drawing.Size(210, 264);
            this.scBlog.SplitterDistance = 177;
            this.scBlog.TabIndex = 24;
            // 
            // txtBlog
            // 
            this.txtBlog.BackColor = System.Drawing.SystemColors.Window;
            this.txtBlog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtBlog.Location = new System.Drawing.Point(0, 0);
            this.txtBlog.Multiline = true;
            this.txtBlog.Name = "txtBlog";
            this.txtBlog.ReadOnly = true;
            this.txtBlog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBlog.Size = new System.Drawing.Size(210, 177);
            this.txtBlog.TabIndex = 1;
            // 
            // txtComment
            // 
            this.txtComment.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtComment.Location = new System.Drawing.Point(0, 0);
            this.txtComment.MaxLength = 300;
            this.txtComment.Multiline = true;
            this.txtComment.Name = "txtComment";
            this.txtComment.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtComment.Size = new System.Drawing.Size(210, 83);
            this.txtComment.TabIndex = 23;
            this.txtComment.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnBlogKeyUp);
            // 
            // tabToolbox
            // 
            this.tabToolbox.Alignment = System.Windows.Forms.TabAlignment.Right;
            this.tabToolbox.Controls.Add(this.tabBlog);
            this.tabToolbox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabToolbox.ItemSize = new System.Drawing.Size(120, 24);
            this.tabToolbox.Location = new System.Drawing.Point(0, 24);
            this.tabToolbox.Multiline = true;
            this.tabToolbox.Name = "tabToolbox";
            this.tabToolbox.SelectedIndex = 0;
            this.tabToolbox.ShowToolTips = true;
            this.tabToolbox.Size = new System.Drawing.Size(242, 272);
            this.tabToolbox.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabToolbox.TabIndex = 120;
            // 
            // pnlToolbox
            // 
            this.pnlToolbox.Controls.Add(this.tabToolbox);
            this.pnlToolbox.Controls.Add(this.pnlToolboxTitlebar);
            this.pnlToolbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnlToolbox.Location = new System.Drawing.Point(612, 78);
            this.pnlToolbox.Name = "pnlToolbox";
            this.pnlToolbox.Size = new System.Drawing.Size(242, 296);
            this.pnlToolbox.TabIndex = 123;
            // 
            // pnlToolboxTitlebar
            // 
            this.pnlToolboxTitlebar.Controls.Add(this.lblPin);
            this.pnlToolboxTitlebar.Controls.Add(this.lblToolbox);
            this.pnlToolboxTitlebar.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlToolboxTitlebar.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pnlToolboxTitlebar.ForeColor = System.Drawing.SystemColors.WindowText;
            this.pnlToolboxTitlebar.Location = new System.Drawing.Point(0, 0);
            this.pnlToolboxTitlebar.Name = "pnlToolboxTitlebar";
            this.pnlToolboxTitlebar.Padding = new System.Windows.Forms.Padding(3);
            this.pnlToolboxTitlebar.Size = new System.Drawing.Size(242, 24);
            this.pnlToolboxTitlebar.TabIndex = 121;
            // 
            // lblPin
            // 
            this.lblPin.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPin.BackColor = System.Drawing.SystemColors.Control;
            this.lblPin.Font = new System.Drawing.Font("Verdana", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPin.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblPin.Location = new System.Drawing.Point(192, 4);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(16, 16);
            this.lblPin.TabIndex = 120;
            this.lblPin.Text = "X";
            this.lblPin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblToolbox
            // 
            this.lblToolbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblToolbox.BackColor = System.Drawing.SystemColors.Control;
            this.lblToolbox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lblToolbox.Font = new System.Drawing.Font("Verdana", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToolbox.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblToolbox.Location = new System.Drawing.Point(3, 3);
            this.lblToolbox.Name = "lblToolbox";
            this.lblToolbox.Size = new System.Drawing.Size(210, 18);
            this.lblToolbox.TabIndex = 119;
            this.lblToolbox.Text = "Toolbox";
            this.lblToolbox.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // ssMain
            // 
            this.ssMain.Location = new System.Drawing.Point(0, 374);
            this.ssMain.Name = "ssMain";
            this.ssMain.Size = new System.Drawing.Size(854, 22);
            this.ssMain.TabIndex = 125;
            this.ssMain.Text = "ssMain";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 396);
            this.Controls.Add(this.scMain);
            this.Controls.Add(this.pnlToolbox);
            this.Controls.Add(this.ssMain);
            this.Controls.Add(this.tsMain);
            this.Controls.Add(this.msMain);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMain;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "VS13.Flyout.Win";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.OnFormClosing);
            this.Load += new System.EventHandler(this.OnFormLoad);
            this.msMain.ResumeLayout(false);
            this.msMain.PerformLayout();
            this.tsMain.ResumeLayout(false);
            this.tsMain.PerformLayout();
            this.csMain.ResumeLayout(false);
            this.tabBlog.ResumeLayout(false);
            this.scBlog.Panel1.ResumeLayout(false);
            this.scBlog.Panel1.PerformLayout();
            this.scBlog.Panel2.ResumeLayout(false);
            this.scBlog.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scBlog)).EndInit();
            this.scBlog.ResumeLayout(false);
            this.tabToolbox.ResumeLayout(false);
            this.pnlToolbox.ResumeLayout(false);
            this.pnlToolboxTitlebar.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMain;
        private System.Windows.Forms.ToolStripMenuItem msFile;
        private System.Windows.Forms.ToolStripMenuItem msFileExit;
        private System.Windows.Forms.ToolStripMenuItem msHelp;
        private System.Windows.Forms.ToolStripMenuItem msHelpAbout;
        private System.Windows.Forms.ToolStrip tsMain;
        private System.Windows.Forms.ToolStripMenuItem msView;
        private System.Windows.Forms.ToolStripMenuItem msViewRefresh;
        private System.Windows.Forms.ToolStripMenuItem msFileNew;
        private System.Windows.Forms.ToolStripSeparator msFileSep2;
        private System.Windows.Forms.ToolStripMenuItem msFileOpen;
        private System.Windows.Forms.ToolStripSeparator msFileSep1;
        private System.Windows.Forms.ToolStripButton tsNew;
        private System.Windows.Forms.ToolStripButton tsOpen;
        private System.Windows.Forms.ContextMenuStrip csMain;
        private System.Windows.Forms.ToolStripMenuItem csNew;
        private System.Windows.Forms.ToolStripSeparator csSep1;
        private System.Windows.Forms.ToolStripMenuItem csOpen;
        private System.Windows.Forms.ToolStripSeparator tsSep1;
        private System.Windows.Forms.ToolStripSeparator msFileSep3;
        private System.Windows.Forms.ToolStripSeparator tsSep2;
        private System.Windows.Forms.ToolStripButton tsRefresh;
        private System.Windows.Forms.ToolStripMenuItem msEdit;
        private System.Windows.Forms.ToolStripSeparator msViewSep1;
        private System.Windows.Forms.ToolStripMenuItem msViewToolbar;
        private System.Windows.Forms.ToolStripMenuItem msViewStatusBar;
        private System.Windows.Forms.ToolStripMenuItem msTools;
        private System.Windows.Forms.ToolStripMenuItem msToolsConfig;
        private System.Windows.Forms.ToolStripMenuItem msFilePrint;
        private System.Windows.Forms.ToolStripMenuItem msFilePageSetup;
        private System.Windows.Forms.ToolStripMenuItem msFilePrintPreview;
        private System.Windows.Forms.ToolStripSeparator msFileSep4;
        private System.Windows.Forms.ToolStripSeparator msViewSep2;
        private System.Windows.Forms.ToolStripMenuItem msFileSaveAs;
        private System.Windows.Forms.ToolStripMenuItem msWin;
        private System.Windows.Forms.ToolStripMenuItem msWinCascade;
        private System.Windows.Forms.ToolStripMenuItem msWinTileH;
        private System.Windows.Forms.ToolStripMenuItem msWinTileV;
        private System.Windows.Forms.ToolStripMenuItem msViewFont;
        private System.Windows.Forms.Splitter scMain;
        private System.Windows.Forms.TabPage tabBlog;
        private System.Windows.Forms.SplitContainer scBlog;
        private System.Windows.Forms.TextBox txtBlog;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.TabControl tabToolbox;
        private System.Windows.Forms.Panel pnlToolbox;
        private System.Windows.Forms.Panel pnlToolboxTitlebar;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Label lblToolbox;
        private System.Windows.Forms.Timer tmrAutoHide;
        private System.Windows.Forms.StatusStrip ssMain;
    }
}

