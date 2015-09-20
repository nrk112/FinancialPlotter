using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlotter.Views
{
    public partial class MainForm : Form
    {
        private int childFormNumber = 0;
        StandardControlsForm controlsForm;
        Models.LocalData localData = new Models.LocalData();

        public MainForm()
        {
            InitializeComponent();
            ShowControlForm();
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            GraphForm childGraph = new GraphForm(null);
            childGraph.MdiParent = this;
            childGraph.Text = "Graph " + childFormNumber++;
            childGraph.Show();
        }

        private void ShowControlForm()
        {
            controlsForm = new StandardControlsForm();
            controlsForm.MdiParent = this;
            controlsForm.Dock = DockStyle.Right;
            controlsForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            if (localData.LoadData())
            {
                GraphForm childGraph = new GraphForm(localData.Queries);
                childGraph.MdiParent = this;
                childGraph.Text = "Graph " + childFormNumber++;
                childGraph.Show();
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        #region Editing functions
        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }
        #endregion

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        #region Window Sorting
        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }
        #endregion

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void MainForm_MdiChildActivate(object sender, EventArgs e)
        {
            if (!(ActiveMdiChild is StandardControlsForm))
                controlsForm.Graph = (GraphForm)ActiveMdiChild;
        }
    }
}
