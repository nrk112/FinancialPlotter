namespace FinancialPlotter.Views
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.openToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.statusBarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.propertiesPanelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.windowsMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.cascadeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileVerticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tileHorizontalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.openToolStripButton = new System.Windows.Forms.ToolStripButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.controlPanel = new System.Windows.Forms.Panel();
            this.labelEditing = new System.Windows.Forms.Label();
            this.groupBoxGrid = new System.Windows.Forms.GroupBox();
            this.checkBoxMinorGrid = new System.Windows.Forms.CheckBox();
            this.checkBoxMajorGrid = new System.Windows.Forms.CheckBox();
            this.groupBoxMovingAvg = new System.Windows.Forms.GroupBox();
            this.buttonColorMov3 = new System.Windows.Forms.Button();
            this.buttonColorMov2 = new System.Windows.Forms.Button();
            this.buttonColorMov1 = new System.Windows.Forms.Button();
            this.numericUpDownGraph3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGraph2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownGraph1 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMovAvg3 = new System.Windows.Forms.CheckBox();
            this.checkBoxMovAvg2 = new System.Windows.Forms.CheckBox();
            this.checkBoxMovAvg1 = new System.Windows.Forms.CheckBox();
            this.buttonApply = new System.Windows.Forms.Button();
            this.groupBoxDisplayType = new System.Windows.Forms.GroupBox();
            this.buttonColorStickFigures = new System.Windows.Forms.Button();
            this.checkBoxStickFigures = new System.Windows.Forms.CheckBox();
            this.buttonColorOpen = new System.Windows.Forms.Button();
            this.buttonColorHigh = new System.Windows.Forms.Button();
            this.buttonColorLow = new System.Windows.Forms.Button();
            this.buttonColorCandleUp = new System.Windows.Forms.Button();
            this.buttonColorCandleDown = new System.Windows.Forms.Button();
            this.buttonColorClose = new System.Windows.Forms.Button();
            this.checkBoxClose = new System.Windows.Forms.CheckBox();
            this.checkBoxOpen = new System.Windows.Forms.CheckBox();
            this.checkBoxLow = new System.Windows.Forms.CheckBox();
            this.checkBoxHigh = new System.Windows.Forms.CheckBox();
            this.checkBoxCandleSticks = new System.Windows.Forms.CheckBox();
            this.groupBoxTimerPeriod = new System.Windows.Forms.GroupBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.menuStrip.SuspendLayout();
            this.toolStrip.SuspendLayout();
            this.controlPanel.SuspendLayout();
            this.groupBoxGrid.SuspendLayout();
            this.groupBoxMovingAvg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraph3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraph2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraph1)).BeginInit();
            this.groupBoxDisplayType.SuspendLayout();
            this.groupBoxTimerPeriod.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileMenu,
            this.viewMenu,
            this.toolsMenu,
            this.windowsMenu,
            this.helpMenu});
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.MdiWindowListItem = this.windowsMenu;
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(1264, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "MenuStrip";
            // 
            // fileMenu
            // 
            this.fileMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.fileMenu.ImageTransparentColor = System.Drawing.SystemColors.ActiveBorder;
            this.fileMenu.Name = "fileMenu";
            this.fileMenu.Size = new System.Drawing.Size(37, 20);
            this.fileMenu.Text = "&File";
            // 
            // openToolStripMenuItem
            // 
            this.openToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripMenuItem.Image")));
            this.openToolStripMenuItem.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripMenuItem.Name = "openToolStripMenuItem";
            this.openToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.openToolStripMenuItem.Text = "&Open";
            this.openToolStripMenuItem.Click += new System.EventHandler(this.OpenFile);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(149, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.ExitToolsStripMenuItem_Click);
            // 
            // viewMenu
            // 
            this.viewMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolBarToolStripMenuItem,
            this.statusBarToolStripMenuItem,
            this.propertiesPanelToolStripMenuItem});
            this.viewMenu.Name = "viewMenu";
            this.viewMenu.Size = new System.Drawing.Size(44, 20);
            this.viewMenu.Text = "&View";
            // 
            // toolBarToolStripMenuItem
            // 
            this.toolBarToolStripMenuItem.Checked = true;
            this.toolBarToolStripMenuItem.CheckOnClick = true;
            this.toolBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.toolBarToolStripMenuItem.Name = "toolBarToolStripMenuItem";
            this.toolBarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.toolBarToolStripMenuItem.Text = "&Toolbar";
            this.toolBarToolStripMenuItem.Click += new System.EventHandler(this.ToolBarToolStripMenuItem_Click);
            // 
            // statusBarToolStripMenuItem
            // 
            this.statusBarToolStripMenuItem.Checked = true;
            this.statusBarToolStripMenuItem.CheckOnClick = true;
            this.statusBarToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.statusBarToolStripMenuItem.Name = "statusBarToolStripMenuItem";
            this.statusBarToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.statusBarToolStripMenuItem.Text = "&Status Bar";
            this.statusBarToolStripMenuItem.Click += new System.EventHandler(this.StatusBarToolStripMenuItem_Click);
            // 
            // propertiesPanelToolStripMenuItem
            // 
            this.propertiesPanelToolStripMenuItem.Checked = true;
            this.propertiesPanelToolStripMenuItem.CheckOnClick = true;
            this.propertiesPanelToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.propertiesPanelToolStripMenuItem.Name = "propertiesPanelToolStripMenuItem";
            this.propertiesPanelToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.propertiesPanelToolStripMenuItem.Text = "Properties Panel";
            this.propertiesPanelToolStripMenuItem.Click += new System.EventHandler(this.propertiesPanelToolStripMenuItem_Click);
            // 
            // toolsMenu
            // 
            this.toolsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.optionsToolStripMenuItem});
            this.toolsMenu.Name = "toolsMenu";
            this.toolsMenu.Size = new System.Drawing.Size(47, 20);
            this.toolsMenu.Text = "&Tools";
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            // 
            // windowsMenu
            // 
            this.windowsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cascadeToolStripMenuItem,
            this.tileVerticalToolStripMenuItem,
            this.tileHorizontalToolStripMenuItem,
            this.closeAllToolStripMenuItem});
            this.windowsMenu.Name = "windowsMenu";
            this.windowsMenu.Size = new System.Drawing.Size(68, 20);
            this.windowsMenu.Text = "&Windows";
            // 
            // cascadeToolStripMenuItem
            // 
            this.cascadeToolStripMenuItem.Name = "cascadeToolStripMenuItem";
            this.cascadeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.cascadeToolStripMenuItem.Text = "&Cascade";
            this.cascadeToolStripMenuItem.Click += new System.EventHandler(this.CascadeToolStripMenuItem_Click);
            // 
            // tileVerticalToolStripMenuItem
            // 
            this.tileVerticalToolStripMenuItem.Name = "tileVerticalToolStripMenuItem";
            this.tileVerticalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tileVerticalToolStripMenuItem.Text = "Tile &Vertical";
            this.tileVerticalToolStripMenuItem.Click += new System.EventHandler(this.TileVerticalToolStripMenuItem_Click);
            // 
            // tileHorizontalToolStripMenuItem
            // 
            this.tileHorizontalToolStripMenuItem.Name = "tileHorizontalToolStripMenuItem";
            this.tileHorizontalToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.tileHorizontalToolStripMenuItem.Text = "Tile &Horizontal";
            this.tileHorizontalToolStripMenuItem.Click += new System.EventHandler(this.TileHorizontalToolStripMenuItem_Click);
            // 
            // closeAllToolStripMenuItem
            // 
            this.closeAllToolStripMenuItem.Name = "closeAllToolStripMenuItem";
            this.closeAllToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.closeAllToolStripMenuItem.Text = "C&lose All";
            this.closeAllToolStripMenuItem.Click += new System.EventHandler(this.CloseAllToolStripMenuItem_Click);
            // 
            // helpMenu
            // 
            this.helpMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpMenu.Name = "helpMenu";
            this.helpMenu.Size = new System.Drawing.Size(44, 20);
            this.helpMenu.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "&About ... ...";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.openToolStripButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 24);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1264, 25);
            this.toolStrip.TabIndex = 1;
            this.toolStrip.Text = "ToolStrip";
            // 
            // openToolStripButton
            // 
            this.openToolStripButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.openToolStripButton.Image = ((System.Drawing.Image)(resources.GetObject("openToolStripButton.Image")));
            this.openToolStripButton.ImageTransparentColor = System.Drawing.Color.Black;
            this.openToolStripButton.Name = "openToolStripButton";
            this.openToolStripButton.Size = new System.Drawing.Size(23, 22);
            this.openToolStripButton.Text = "Open";
            this.openToolStripButton.Click += new System.EventHandler(this.OpenFile);
            // 
            // controlPanel
            // 
            this.controlPanel.AutoScroll = true;
            this.controlPanel.Controls.Add(this.labelEditing);
            this.controlPanel.Controls.Add(this.groupBoxGrid);
            this.controlPanel.Controls.Add(this.groupBoxMovingAvg);
            this.controlPanel.Controls.Add(this.buttonApply);
            this.controlPanel.Controls.Add(this.groupBoxDisplayType);
            this.controlPanel.Controls.Add(this.groupBoxTimerPeriod);
            this.controlPanel.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlPanel.Enabled = false;
            this.controlPanel.Location = new System.Drawing.Point(1057, 49);
            this.controlPanel.Name = "controlPanel";
            this.controlPanel.Size = new System.Drawing.Size(207, 610);
            this.controlPanel.TabIndex = 4;
            // 
            // labelEditing
            // 
            this.labelEditing.AutoSize = true;
            this.labelEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditing.Location = new System.Drawing.Point(20, 11);
            this.labelEditing.Name = "labelEditing";
            this.labelEditing.Size = new System.Drawing.Size(73, 17);
            this.labelEditing.TabIndex = 13;
            this.labelEditing.Text = "Viewing: ";
            // 
            // groupBoxGrid
            // 
            this.groupBoxGrid.Controls.Add(this.checkBoxMinorGrid);
            this.groupBoxGrid.Controls.Add(this.checkBoxMajorGrid);
            this.groupBoxGrid.Location = new System.Drawing.Point(19, 41);
            this.groupBoxGrid.Name = "groupBoxGrid";
            this.groupBoxGrid.Size = new System.Drawing.Size(160, 71);
            this.groupBoxGrid.TabIndex = 12;
            this.groupBoxGrid.TabStop = false;
            this.groupBoxGrid.Text = "Graph Properties";
            // 
            // checkBoxMinorGrid
            // 
            this.checkBoxMinorGrid.AutoSize = true;
            this.checkBoxMinorGrid.Location = new System.Drawing.Point(7, 43);
            this.checkBoxMinorGrid.Name = "checkBoxMinorGrid";
            this.checkBoxMinorGrid.Size = new System.Drawing.Size(75, 17);
            this.checkBoxMinorGrid.TabIndex = 1;
            this.checkBoxMinorGrid.Text = "Show Grid";
            this.checkBoxMinorGrid.UseVisualStyleBackColor = true;
            // 
            // checkBoxMajorGrid
            // 
            this.checkBoxMajorGrid.AutoSize = true;
            this.checkBoxMajorGrid.Location = new System.Drawing.Point(7, 20);
            this.checkBoxMajorGrid.Name = "checkBoxMajorGrid";
            this.checkBoxMajorGrid.Size = new System.Drawing.Size(79, 17);
            this.checkBoxMajorGrid.TabIndex = 0;
            this.checkBoxMajorGrid.Text = "Show Axes";
            this.checkBoxMajorGrid.UseVisualStyleBackColor = true;
            // 
            // groupBoxMovingAvg
            // 
            this.groupBoxMovingAvg.Controls.Add(this.buttonColorMov3);
            this.groupBoxMovingAvg.Controls.Add(this.buttonColorMov2);
            this.groupBoxMovingAvg.Controls.Add(this.buttonColorMov1);
            this.groupBoxMovingAvg.Controls.Add(this.numericUpDownGraph3);
            this.groupBoxMovingAvg.Controls.Add(this.numericUpDownGraph2);
            this.groupBoxMovingAvg.Controls.Add(this.label3);
            this.groupBoxMovingAvg.Controls.Add(this.numericUpDownGraph1);
            this.groupBoxMovingAvg.Controls.Add(this.checkBoxMovAvg3);
            this.groupBoxMovingAvg.Controls.Add(this.checkBoxMovAvg2);
            this.groupBoxMovingAvg.Controls.Add(this.checkBoxMovAvg1);
            this.groupBoxMovingAvg.Location = new System.Drawing.Point(19, 409);
            this.groupBoxMovingAvg.Name = "groupBoxMovingAvg";
            this.groupBoxMovingAvg.Size = new System.Drawing.Size(160, 118);
            this.groupBoxMovingAvg.TabIndex = 11;
            this.groupBoxMovingAvg.TabStop = false;
            this.groupBoxMovingAvg.Text = "Moving Average Graphs";
            // 
            // buttonColorMov3
            // 
            this.buttonColorMov3.Location = new System.Drawing.Point(123, 88);
            this.buttonColorMov3.Name = "buttonColorMov3";
            this.buttonColorMov3.Size = new System.Drawing.Size(28, 13);
            this.buttonColorMov3.TabIndex = 25;
            this.buttonColorMov3.UseVisualStyleBackColor = true;
            this.buttonColorMov3.Click += new System.EventHandler(this.buttonColorPicker_Click);
            // 
            // buttonColorMov2
            // 
            this.buttonColorMov2.Location = new System.Drawing.Point(123, 64);
            this.buttonColorMov2.Name = "buttonColorMov2";
            this.buttonColorMov2.Size = new System.Drawing.Size(28, 13);
            this.buttonColorMov2.TabIndex = 22;
            this.buttonColorMov2.UseVisualStyleBackColor = true;
            this.buttonColorMov2.Click += new System.EventHandler(this.buttonColorPicker_Click);
            // 
            // buttonColorMov1
            // 
            this.buttonColorMov1.Location = new System.Drawing.Point(123, 39);
            this.buttonColorMov1.Name = "buttonColorMov1";
            this.buttonColorMov1.Size = new System.Drawing.Size(28, 13);
            this.buttonColorMov1.TabIndex = 19;
            this.buttonColorMov1.UseVisualStyleBackColor = true;
            this.buttonColorMov1.Click += new System.EventHandler(this.buttonColorPicker_Click);
            // 
            // numericUpDownGraph3
            // 
            this.numericUpDownGraph3.Location = new System.Drawing.Point(76, 84);
            this.numericUpDownGraph3.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownGraph3.Name = "numericUpDownGraph3";
            this.numericUpDownGraph3.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownGraph3.TabIndex = 24;
            this.numericUpDownGraph3.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // numericUpDownGraph2
            // 
            this.numericUpDownGraph2.Location = new System.Drawing.Point(76, 60);
            this.numericUpDownGraph2.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownGraph2.Name = "numericUpDownGraph2";
            this.numericUpDownGraph2.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownGraph2.TabIndex = 21;
            this.numericUpDownGraph2.Value = new decimal(new int[] {
            50,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(74, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Days";
            // 
            // numericUpDownGraph1
            // 
            this.numericUpDownGraph1.Location = new System.Drawing.Point(76, 37);
            this.numericUpDownGraph1.Minimum = new decimal(new int[] {
            5,
            0,
            0,
            0});
            this.numericUpDownGraph1.Name = "numericUpDownGraph1";
            this.numericUpDownGraph1.Size = new System.Drawing.Size(41, 20);
            this.numericUpDownGraph1.TabIndex = 18;
            this.numericUpDownGraph1.Value = new decimal(new int[] {
            10,
            0,
            0,
            0});
            // 
            // checkBoxMovAvg3
            // 
            this.checkBoxMovAvg3.AutoSize = true;
            this.checkBoxMovAvg3.Location = new System.Drawing.Point(6, 87);
            this.checkBoxMovAvg3.Name = "checkBoxMovAvg3";
            this.checkBoxMovAvg3.Size = new System.Drawing.Size(64, 17);
            this.checkBoxMovAvg3.TabIndex = 23;
            this.checkBoxMovAvg3.Text = "Graph 3";
            this.checkBoxMovAvg3.UseVisualStyleBackColor = true;
            // 
            // checkBoxMovAvg2
            // 
            this.checkBoxMovAvg2.AutoSize = true;
            this.checkBoxMovAvg2.Location = new System.Drawing.Point(6, 63);
            this.checkBoxMovAvg2.Name = "checkBoxMovAvg2";
            this.checkBoxMovAvg2.Size = new System.Drawing.Size(64, 17);
            this.checkBoxMovAvg2.TabIndex = 20;
            this.checkBoxMovAvg2.Text = "Graph 2";
            this.checkBoxMovAvg2.UseVisualStyleBackColor = true;
            // 
            // checkBoxMovAvg1
            // 
            this.checkBoxMovAvg1.AutoSize = true;
            this.checkBoxMovAvg1.Location = new System.Drawing.Point(6, 38);
            this.checkBoxMovAvg1.Name = "checkBoxMovAvg1";
            this.checkBoxMovAvg1.Size = new System.Drawing.Size(64, 17);
            this.checkBoxMovAvg1.TabIndex = 17;
            this.checkBoxMovAvg1.Text = "Graph 1";
            this.checkBoxMovAvg1.UseVisualStyleBackColor = true;
            // 
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(19, 533);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(160, 23);
            this.buttonApply.TabIndex = 26;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // groupBoxDisplayType
            // 
            this.groupBoxDisplayType.Controls.Add(this.buttonColorStickFigures);
            this.groupBoxDisplayType.Controls.Add(this.checkBoxStickFigures);
            this.groupBoxDisplayType.Controls.Add(this.buttonColorOpen);
            this.groupBoxDisplayType.Controls.Add(this.buttonColorHigh);
            this.groupBoxDisplayType.Controls.Add(this.buttonColorLow);
            this.groupBoxDisplayType.Controls.Add(this.buttonColorCandleUp);
            this.groupBoxDisplayType.Controls.Add(this.buttonColorCandleDown);
            this.groupBoxDisplayType.Controls.Add(this.buttonColorClose);
            this.groupBoxDisplayType.Controls.Add(this.checkBoxClose);
            this.groupBoxDisplayType.Controls.Add(this.checkBoxOpen);
            this.groupBoxDisplayType.Controls.Add(this.checkBoxLow);
            this.groupBoxDisplayType.Controls.Add(this.checkBoxHigh);
            this.groupBoxDisplayType.Controls.Add(this.checkBoxCandleSticks);
            this.groupBoxDisplayType.Location = new System.Drawing.Point(19, 238);
            this.groupBoxDisplayType.Name = "groupBoxDisplayType";
            this.groupBoxDisplayType.Size = new System.Drawing.Size(160, 165);
            this.groupBoxDisplayType.TabIndex = 9;
            this.groupBoxDisplayType.TabStop = false;
            this.groupBoxDisplayType.Text = "Graph Type";
            // 
            // buttonColorStickFigures
            // 
            this.buttonColorStickFigures.Location = new System.Drawing.Point(92, 43);
            this.buttonColorStickFigures.Name = "buttonColorStickFigures";
            this.buttonColorStickFigures.Size = new System.Drawing.Size(28, 15);
            this.buttonColorStickFigures.TabIndex = 8;
            this.buttonColorStickFigures.UseVisualStyleBackColor = true;
            this.buttonColorStickFigures.Click += new System.EventHandler(this.buttonColorPicker_Click);
            // 
            // checkBoxStickFigures
            // 
            this.checkBoxStickFigures.AutoSize = true;
            this.checkBoxStickFigures.Location = new System.Drawing.Point(7, 43);
            this.checkBoxStickFigures.Name = "checkBoxStickFigures";
            this.checkBoxStickFigures.Size = new System.Drawing.Size(84, 17);
            this.checkBoxStickFigures.TabIndex = 7;
            this.checkBoxStickFigures.Text = "StickFigures";
            this.checkBoxStickFigures.UseVisualStyleBackColor = true;
            // 
            // buttonColorOpen
            // 
            this.buttonColorOpen.Location = new System.Drawing.Point(92, 112);
            this.buttonColorOpen.Name = "buttonColorOpen";
            this.buttonColorOpen.Size = new System.Drawing.Size(28, 15);
            this.buttonColorOpen.TabIndex = 14;
            this.buttonColorOpen.UseVisualStyleBackColor = true;
            this.buttonColorOpen.Click += new System.EventHandler(this.buttonColorPicker_Click);
            // 
            // buttonColorHigh
            // 
            this.buttonColorHigh.Location = new System.Drawing.Point(92, 89);
            this.buttonColorHigh.Name = "buttonColorHigh";
            this.buttonColorHigh.Size = new System.Drawing.Size(28, 15);
            this.buttonColorHigh.TabIndex = 12;
            this.buttonColorHigh.UseVisualStyleBackColor = true;
            this.buttonColorHigh.Click += new System.EventHandler(this.buttonColorPicker_Click);
            // 
            // buttonColorLow
            // 
            this.buttonColorLow.Location = new System.Drawing.Point(92, 135);
            this.buttonColorLow.Name = "buttonColorLow";
            this.buttonColorLow.Size = new System.Drawing.Size(28, 15);
            this.buttonColorLow.TabIndex = 16;
            this.buttonColorLow.UseVisualStyleBackColor = true;
            this.buttonColorLow.Click += new System.EventHandler(this.buttonColorPicker_Click);
            // 
            // buttonColorCandleUp
            // 
            this.buttonColorCandleUp.Location = new System.Drawing.Point(92, 19);
            this.buttonColorCandleUp.Name = "buttonColorCandleUp";
            this.buttonColorCandleUp.Size = new System.Drawing.Size(28, 15);
            this.buttonColorCandleUp.TabIndex = 5;
            this.buttonColorCandleUp.UseVisualStyleBackColor = true;
            this.buttonColorCandleUp.Click += new System.EventHandler(this.buttonColorPicker_Click);
            // 
            // buttonColorCandleDown
            // 
            this.buttonColorCandleDown.Location = new System.Drawing.Point(126, 19);
            this.buttonColorCandleDown.Name = "buttonColorCandleDown";
            this.buttonColorCandleDown.Size = new System.Drawing.Size(28, 15);
            this.buttonColorCandleDown.TabIndex = 6;
            this.buttonColorCandleDown.UseVisualStyleBackColor = true;
            this.buttonColorCandleDown.Click += new System.EventHandler(this.buttonColorPicker_Click);
            // 
            // buttonColorClose
            // 
            this.buttonColorClose.Location = new System.Drawing.Point(92, 66);
            this.buttonColorClose.Name = "buttonColorClose";
            this.buttonColorClose.Size = new System.Drawing.Size(28, 15);
            this.buttonColorClose.TabIndex = 10;
            this.buttonColorClose.UseVisualStyleBackColor = true;
            this.buttonColorClose.Click += new System.EventHandler(this.buttonColorPicker_Click);
            // 
            // checkBoxClose
            // 
            this.checkBoxClose.AutoSize = true;
            this.checkBoxClose.Location = new System.Drawing.Point(7, 66);
            this.checkBoxClose.Name = "checkBoxClose";
            this.checkBoxClose.Size = new System.Drawing.Size(52, 17);
            this.checkBoxClose.TabIndex = 9;
            this.checkBoxClose.Text = "Close";
            this.checkBoxClose.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpen
            // 
            this.checkBoxOpen.AutoSize = true;
            this.checkBoxOpen.Location = new System.Drawing.Point(7, 112);
            this.checkBoxOpen.Name = "checkBoxOpen";
            this.checkBoxOpen.Size = new System.Drawing.Size(52, 17);
            this.checkBoxOpen.TabIndex = 13;
            this.checkBoxOpen.Text = "Open";
            this.checkBoxOpen.UseVisualStyleBackColor = true;
            // 
            // checkBoxLow
            // 
            this.checkBoxLow.AutoSize = true;
            this.checkBoxLow.Location = new System.Drawing.Point(7, 135);
            this.checkBoxLow.Name = "checkBoxLow";
            this.checkBoxLow.Size = new System.Drawing.Size(46, 17);
            this.checkBoxLow.TabIndex = 15;
            this.checkBoxLow.Text = "Low";
            this.checkBoxLow.UseVisualStyleBackColor = true;
            // 
            // checkBoxHigh
            // 
            this.checkBoxHigh.AutoSize = true;
            this.checkBoxHigh.Location = new System.Drawing.Point(7, 89);
            this.checkBoxHigh.Name = "checkBoxHigh";
            this.checkBoxHigh.Size = new System.Drawing.Size(48, 17);
            this.checkBoxHigh.TabIndex = 11;
            this.checkBoxHigh.Text = "High";
            this.checkBoxHigh.UseVisualStyleBackColor = true;
            // 
            // checkBoxCandleSticks
            // 
            this.checkBoxCandleSticks.AutoSize = true;
            this.checkBoxCandleSticks.Location = new System.Drawing.Point(7, 20);
            this.checkBoxCandleSticks.Name = "checkBoxCandleSticks";
            this.checkBoxCandleSticks.Size = new System.Drawing.Size(88, 17);
            this.checkBoxCandleSticks.TabIndex = 4;
            this.checkBoxCandleSticks.Text = "CandleSticks";
            this.checkBoxCandleSticks.UseVisualStyleBackColor = true;
            // 
            // groupBoxTimerPeriod
            // 
            this.groupBoxTimerPeriod.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxTimerPeriod.Controls.Add(this.label2);
            this.groupBoxTimerPeriod.Controls.Add(this.dateTimePickerStart);
            this.groupBoxTimerPeriod.Controls.Add(this.label1);
            this.groupBoxTimerPeriod.Location = new System.Drawing.Point(19, 120);
            this.groupBoxTimerPeriod.Name = "groupBoxTimerPeriod";
            this.groupBoxTimerPeriod.Size = new System.Drawing.Size(160, 112);
            this.groupBoxTimerPeriod.TabIndex = 8;
            this.groupBoxTimerPeriod.TabStop = false;
            this.groupBoxTimerPeriod.Text = "Time Period";
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(6, 80);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(99, 20);
            this.dateTimePickerEnd.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "End Date:";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(6, 36);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(99, 20);
            this.dateTimePickerStart.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start Date:";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(39, 17);
            this.toolStripStatusLabel.Text = "Status";
            // 
            // statusStrip
            // 
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 659);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1264, 22);
            this.statusStrip.TabIndex = 2;
            this.statusStrip.Text = "StatusStrip";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 681);
            this.Controls.Add(this.controlPanel);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.menuStrip);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.Text = "Financial Plotter";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.MdiChildActivate += new System.EventHandler(this.MainForm_MdiChildActivate);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.controlPanel.ResumeLayout(false);
            this.controlPanel.PerformLayout();
            this.groupBoxGrid.ResumeLayout(false);
            this.groupBoxGrid.PerformLayout();
            this.groupBoxMovingAvg.ResumeLayout(false);
            this.groupBoxMovingAvg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraph3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraph2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraph1)).EndInit();
            this.groupBoxDisplayType.ResumeLayout(false);
            this.groupBoxDisplayType.PerformLayout();
            this.groupBoxTimerPeriod.ResumeLayout(false);
            this.groupBoxTimerPeriod.PerformLayout();
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion


        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileHorizontalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileMenu;
        private System.Windows.Forms.ToolStripMenuItem openToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewMenu;
        private System.Windows.Forms.ToolStripMenuItem toolBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem statusBarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolsMenu;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem windowsMenu;
        private System.Windows.Forms.ToolStripMenuItem cascadeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tileVerticalToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem closeAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpMenu;
        private System.Windows.Forms.ToolStripButton openToolStripButton;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.Panel controlPanel;
        private System.Windows.Forms.Label labelEditing;
        private System.Windows.Forms.GroupBox groupBoxGrid;
        private System.Windows.Forms.CheckBox checkBoxMinorGrid;
        private System.Windows.Forms.CheckBox checkBoxMajorGrid;
        private System.Windows.Forms.GroupBox groupBoxMovingAvg;
        private System.Windows.Forms.NumericUpDown numericUpDownGraph3;
        private System.Windows.Forms.NumericUpDown numericUpDownGraph2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownGraph1;
        private System.Windows.Forms.CheckBox checkBoxMovAvg3;
        private System.Windows.Forms.CheckBox checkBoxMovAvg2;
        private System.Windows.Forms.CheckBox checkBoxMovAvg1;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.GroupBox groupBoxDisplayType;
        private System.Windows.Forms.CheckBox checkBoxClose;
        private System.Windows.Forms.CheckBox checkBoxOpen;
        private System.Windows.Forms.CheckBox checkBoxLow;
        private System.Windows.Forms.CheckBox checkBoxHigh;
        private System.Windows.Forms.CheckBox checkBoxCandleSticks;
        private System.Windows.Forms.GroupBox groupBoxTimerPeriod;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonColorClose;
        private System.Windows.Forms.Button buttonColorMov3;
        private System.Windows.Forms.Button buttonColorMov2;
        private System.Windows.Forms.Button buttonColorMov1;
        private System.Windows.Forms.Button buttonColorOpen;
        private System.Windows.Forms.Button buttonColorHigh;
        private System.Windows.Forms.Button buttonColorLow;
        private System.Windows.Forms.Button buttonColorCandleUp;
        private System.Windows.Forms.Button buttonColorCandleDown;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem propertiesPanelToolStripMenuItem;
        private System.Windows.Forms.Button buttonColorStickFigures;
        private System.Windows.Forms.CheckBox checkBoxStickFigures;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
        private System.Windows.Forms.StatusStrip statusStrip;
    }
}



