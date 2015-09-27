namespace FinancialPlotter.Views
{
    partial class GraphForm
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
            this.toolTipCoordinates = new System.Windows.Forms.ToolTip(this.components);
            this.SuspendLayout();
            // 
            // GraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Name = "GraphForm";
            this.Text = "GraphForm";
            this.ResizeBegin += new System.EventHandler(this.GraphForm_ResizeBegin);
            this.ResizeEnd += new System.EventHandler(this.GraphForm_ResizeEnd);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GraphForm_Paint);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.GraphForm_MouseClick);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.GraphForm_MouseMove_1);
            this.Resize += new System.EventHandler(this.GraphForm_Resize);
            this.StyleChanged += new System.EventHandler(this.GraphForm_ResizeEnd);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ToolTip toolTipCoordinates;
    }
}