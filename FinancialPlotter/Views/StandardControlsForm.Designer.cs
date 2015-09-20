namespace FinancialPlotter.Views
{
    partial class StandardControlsForm
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
            this.groupBoxTimerPeriod = new System.Windows.Forms.GroupBox();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonApply = new System.Windows.Forms.Button();
            this.groupBoxDisplayType = new System.Windows.Forms.GroupBox();
            this.checkBoxClose = new System.Windows.Forms.CheckBox();
            this.checkBoxOpen = new System.Windows.Forms.CheckBox();
            this.checkBoxLow = new System.Windows.Forms.CheckBox();
            this.checkBoxHigh = new System.Windows.Forms.CheckBox();
            this.checkBoxCandleSticks = new System.Windows.Forms.CheckBox();
            this.groupBoxMovingAvg = new System.Windows.Forms.GroupBox();
            this.numericUpDownGraph3 = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownGraph2 = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.numericUpDownGraph1 = new System.Windows.Forms.NumericUpDown();
            this.checkBoxMovAvg3 = new System.Windows.Forms.CheckBox();
            this.checkBoxMovAvg2 = new System.Windows.Forms.CheckBox();
            this.checkBoxMovAvg1 = new System.Windows.Forms.CheckBox();
            this.groupBoxGrid = new System.Windows.Forms.GroupBox();
            this.checkBoxMinorGrid = new System.Windows.Forms.CheckBox();
            this.checkBoxMajorGrid = new System.Windows.Forms.CheckBox();
            this.labelEditing = new System.Windows.Forms.Label();
            this.groupBoxTimerPeriod.SuspendLayout();
            this.groupBoxDisplayType.SuspendLayout();
            this.groupBoxMovingAvg.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraph3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraph2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraph1)).BeginInit();
            this.groupBoxGrid.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxTimerPeriod
            // 
            this.groupBoxTimerPeriod.Controls.Add(this.dateTimePickerEnd);
            this.groupBoxTimerPeriod.Controls.Add(this.label2);
            this.groupBoxTimerPeriod.Controls.Add(this.dateTimePickerStart);
            this.groupBoxTimerPeriod.Controls.Add(this.label1);
            this.groupBoxTimerPeriod.Location = new System.Drawing.Point(12, 122);
            this.groupBoxTimerPeriod.Name = "groupBoxTimerPeriod";
            this.groupBoxTimerPeriod.Size = new System.Drawing.Size(160, 112);
            this.groupBoxTimerPeriod.TabIndex = 0;
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
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
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
            this.dateTimePickerStart.TabIndex = 1;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.dateTimePickerStart_ValueChanged);
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
            // buttonApply
            // 
            this.buttonApply.Location = new System.Drawing.Point(12, 465);
            this.buttonApply.Name = "buttonApply";
            this.buttonApply.Size = new System.Drawing.Size(160, 23);
            this.buttonApply.TabIndex = 4;
            this.buttonApply.Text = "Apply";
            this.buttonApply.UseVisualStyleBackColor = true;
            this.buttonApply.Click += new System.EventHandler(this.buttonApply_Click);
            // 
            // groupBoxDisplayType
            // 
            this.groupBoxDisplayType.Controls.Add(this.checkBoxClose);
            this.groupBoxDisplayType.Controls.Add(this.checkBoxOpen);
            this.groupBoxDisplayType.Controls.Add(this.checkBoxLow);
            this.groupBoxDisplayType.Controls.Add(this.checkBoxHigh);
            this.groupBoxDisplayType.Controls.Add(this.checkBoxCandleSticks);
            this.groupBoxDisplayType.Location = new System.Drawing.Point(12, 240);
            this.groupBoxDisplayType.Name = "groupBoxDisplayType";
            this.groupBoxDisplayType.Size = new System.Drawing.Size(160, 94);
            this.groupBoxDisplayType.TabIndex = 1;
            this.groupBoxDisplayType.TabStop = false;
            this.groupBoxDisplayType.Text = "Graph Type";
            // 
            // checkBoxClose
            // 
            this.checkBoxClose.AutoSize = true;
            this.checkBoxClose.Location = new System.Drawing.Point(7, 66);
            this.checkBoxClose.Name = "checkBoxClose";
            this.checkBoxClose.Size = new System.Drawing.Size(52, 17);
            this.checkBoxClose.TabIndex = 4;
            this.checkBoxClose.Text = "Close";
            this.checkBoxClose.UseVisualStyleBackColor = true;
            // 
            // checkBoxOpen
            // 
            this.checkBoxOpen.AutoSize = true;
            this.checkBoxOpen.Location = new System.Drawing.Point(101, 43);
            this.checkBoxOpen.Name = "checkBoxOpen";
            this.checkBoxOpen.Size = new System.Drawing.Size(52, 17);
            this.checkBoxOpen.TabIndex = 3;
            this.checkBoxOpen.Text = "Open";
            this.checkBoxOpen.UseVisualStyleBackColor = true;
            // 
            // checkBoxLow
            // 
            this.checkBoxLow.AutoSize = true;
            this.checkBoxLow.Location = new System.Drawing.Point(7, 43);
            this.checkBoxLow.Name = "checkBoxLow";
            this.checkBoxLow.Size = new System.Drawing.Size(46, 17);
            this.checkBoxLow.TabIndex = 2;
            this.checkBoxLow.Text = "Low";
            this.checkBoxLow.UseVisualStyleBackColor = true;
            // 
            // checkBoxHigh
            // 
            this.checkBoxHigh.AutoSize = true;
            this.checkBoxHigh.Location = new System.Drawing.Point(101, 20);
            this.checkBoxHigh.Name = "checkBoxHigh";
            this.checkBoxHigh.Size = new System.Drawing.Size(48, 17);
            this.checkBoxHigh.TabIndex = 1;
            this.checkBoxHigh.Text = "High";
            this.checkBoxHigh.UseVisualStyleBackColor = true;
            // 
            // checkBoxCandleSticks
            // 
            this.checkBoxCandleSticks.AutoSize = true;
            this.checkBoxCandleSticks.Location = new System.Drawing.Point(7, 20);
            this.checkBoxCandleSticks.Name = "checkBoxCandleSticks";
            this.checkBoxCandleSticks.Size = new System.Drawing.Size(88, 17);
            this.checkBoxCandleSticks.TabIndex = 0;
            this.checkBoxCandleSticks.Text = "CandleSticks";
            this.checkBoxCandleSticks.UseVisualStyleBackColor = true;
            // 
            // groupBoxMovingAvg
            // 
            this.groupBoxMovingAvg.Controls.Add(this.numericUpDownGraph3);
            this.groupBoxMovingAvg.Controls.Add(this.numericUpDownGraph2);
            this.groupBoxMovingAvg.Controls.Add(this.label3);
            this.groupBoxMovingAvg.Controls.Add(this.numericUpDownGraph1);
            this.groupBoxMovingAvg.Controls.Add(this.checkBoxMovAvg3);
            this.groupBoxMovingAvg.Controls.Add(this.checkBoxMovAvg2);
            this.groupBoxMovingAvg.Controls.Add(this.checkBoxMovAvg1);
            this.groupBoxMovingAvg.Location = new System.Drawing.Point(12, 341);
            this.groupBoxMovingAvg.Name = "groupBoxMovingAvg";
            this.groupBoxMovingAvg.Size = new System.Drawing.Size(160, 118);
            this.groupBoxMovingAvg.TabIndex = 5;
            this.groupBoxMovingAvg.TabStop = false;
            this.groupBoxMovingAvg.Text = "Moving Average Graphs";
            // 
            // numericUpDownGraph3
            // 
            this.numericUpDownGraph3.Location = new System.Drawing.Point(76, 84);
            this.numericUpDownGraph3.Name = "numericUpDownGraph3";
            this.numericUpDownGraph3.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownGraph3.TabIndex = 6;
            // 
            // numericUpDownGraph2
            // 
            this.numericUpDownGraph2.Location = new System.Drawing.Point(76, 60);
            this.numericUpDownGraph2.Name = "numericUpDownGraph2";
            this.numericUpDownGraph2.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownGraph2.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(98, 21);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Days";
            // 
            // numericUpDownGraph1
            // 
            this.numericUpDownGraph1.Location = new System.Drawing.Point(76, 37);
            this.numericUpDownGraph1.Name = "numericUpDownGraph1";
            this.numericUpDownGraph1.Size = new System.Drawing.Size(73, 20);
            this.numericUpDownGraph1.TabIndex = 3;
            // 
            // checkBoxMovAvg3
            // 
            this.checkBoxMovAvg3.AutoSize = true;
            this.checkBoxMovAvg3.Location = new System.Drawing.Point(6, 87);
            this.checkBoxMovAvg3.Name = "checkBoxMovAvg3";
            this.checkBoxMovAvg3.Size = new System.Drawing.Size(64, 17);
            this.checkBoxMovAvg3.TabIndex = 2;
            this.checkBoxMovAvg3.Text = "Graph 3";
            this.checkBoxMovAvg3.UseVisualStyleBackColor = true;
            // 
            // checkBoxMovAvg2
            // 
            this.checkBoxMovAvg2.AutoSize = true;
            this.checkBoxMovAvg2.Location = new System.Drawing.Point(6, 63);
            this.checkBoxMovAvg2.Name = "checkBoxMovAvg2";
            this.checkBoxMovAvg2.Size = new System.Drawing.Size(64, 17);
            this.checkBoxMovAvg2.TabIndex = 1;
            this.checkBoxMovAvg2.Text = "Graph 2";
            this.checkBoxMovAvg2.UseVisualStyleBackColor = true;
            // 
            // checkBoxMovAvg1
            // 
            this.checkBoxMovAvg1.AutoSize = true;
            this.checkBoxMovAvg1.Location = new System.Drawing.Point(6, 38);
            this.checkBoxMovAvg1.Name = "checkBoxMovAvg1";
            this.checkBoxMovAvg1.Size = new System.Drawing.Size(64, 17);
            this.checkBoxMovAvg1.TabIndex = 0;
            this.checkBoxMovAvg1.Text = "Graph 1";
            this.checkBoxMovAvg1.UseVisualStyleBackColor = true;
            // 
            // groupBoxGrid
            // 
            this.groupBoxGrid.Controls.Add(this.checkBoxMinorGrid);
            this.groupBoxGrid.Controls.Add(this.checkBoxMajorGrid);
            this.groupBoxGrid.Location = new System.Drawing.Point(12, 43);
            this.groupBoxGrid.Name = "groupBoxGrid";
            this.groupBoxGrid.Size = new System.Drawing.Size(160, 71);
            this.groupBoxGrid.TabIndex = 6;
            this.groupBoxGrid.TabStop = false;
            this.groupBoxGrid.Text = "Grid Lines";
            // 
            // checkBoxMinorGrid
            // 
            this.checkBoxMinorGrid.AutoSize = true;
            this.checkBoxMinorGrid.Location = new System.Drawing.Point(7, 43);
            this.checkBoxMinorGrid.Name = "checkBoxMinorGrid";
            this.checkBoxMinorGrid.Size = new System.Drawing.Size(110, 17);
            this.checkBoxMinorGrid.TabIndex = 1;
            this.checkBoxMinorGrid.Text = "Show Minor Lines";
            this.checkBoxMinorGrid.UseVisualStyleBackColor = true;
            // 
            // checkBoxMajorGrid
            // 
            this.checkBoxMajorGrid.AutoSize = true;
            this.checkBoxMajorGrid.Location = new System.Drawing.Point(7, 20);
            this.checkBoxMajorGrid.Name = "checkBoxMajorGrid";
            this.checkBoxMajorGrid.Size = new System.Drawing.Size(110, 17);
            this.checkBoxMajorGrid.TabIndex = 0;
            this.checkBoxMajorGrid.Text = "Show Major Lines";
            this.checkBoxMajorGrid.UseVisualStyleBackColor = true;
            // 
            // labelEditing
            // 
            this.labelEditing.AutoSize = true;
            this.labelEditing.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEditing.Location = new System.Drawing.Point(13, 13);
            this.labelEditing.Name = "labelEditing";
            this.labelEditing.Size = new System.Drawing.Size(68, 17);
            this.labelEditing.TabIndex = 7;
            this.labelEditing.Text = "Editing: ";
            // 
            // StandardControlsForm
            // 
            this.AcceptButton = this.buttonApply;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(184, 501);
            this.Controls.Add(this.labelEditing);
            this.Controls.Add(this.groupBoxGrid);
            this.Controls.Add(this.groupBoxMovingAvg);
            this.Controls.Add(this.buttonApply);
            this.Controls.Add(this.groupBoxDisplayType);
            this.Controls.Add(this.groupBoxTimerPeriod);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "StandardControlsForm";
            this.ShowInTaskbar = false;
            this.Text = "Controls";
            this.TopMost = true;
            this.groupBoxTimerPeriod.ResumeLayout(false);
            this.groupBoxTimerPeriod.PerformLayout();
            this.groupBoxDisplayType.ResumeLayout(false);
            this.groupBoxDisplayType.PerformLayout();
            this.groupBoxMovingAvg.ResumeLayout(false);
            this.groupBoxMovingAvg.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraph3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraph2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownGraph1)).EndInit();
            this.groupBoxGrid.ResumeLayout(false);
            this.groupBoxGrid.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxTimerPeriod;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonApply;
        private System.Windows.Forms.GroupBox groupBoxDisplayType;
        private System.Windows.Forms.CheckBox checkBoxClose;
        private System.Windows.Forms.CheckBox checkBoxOpen;
        private System.Windows.Forms.CheckBox checkBoxLow;
        private System.Windows.Forms.CheckBox checkBoxHigh;
        private System.Windows.Forms.CheckBox checkBoxCandleSticks;
        private System.Windows.Forms.GroupBox groupBoxMovingAvg;
        private System.Windows.Forms.CheckBox checkBoxMovAvg3;
        private System.Windows.Forms.CheckBox checkBoxMovAvg2;
        private System.Windows.Forms.CheckBox checkBoxMovAvg1;
        private System.Windows.Forms.NumericUpDown numericUpDownGraph3;
        private System.Windows.Forms.NumericUpDown numericUpDownGraph2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown numericUpDownGraph1;
        private System.Windows.Forms.GroupBox groupBoxGrid;
        private System.Windows.Forms.CheckBox checkBoxMinorGrid;
        private System.Windows.Forms.CheckBox checkBoxMajorGrid;
        private System.Windows.Forms.Label labelEditing;
    }
}