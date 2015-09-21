﻿using System;
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

        public MainForm()
        {
            InitializeComponent();
            //ShowControlForm();
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
            Models.LocalData localData = new Models.LocalData();
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
            graph = (GraphForm)ActiveMdiChild;
            setControlPanelState();



            //if (!(ActiveMdiChild is StandardControlsForm) && ActiveMdiChild != lastActiveForm)
            //{
            //    controlsForm.Graph = (GraphForm)ActiveMdiChild;
            //    lastActiveForm = (GraphForm)ActiveMdiChild;
            //} 
        }
        private Form lastActiveForm;


        #region Control Panel
        GraphForm graph;

        private void buttonApply_Click(object sender, EventArgs e)
        {
            if (graph != null)
            {
                if (dateTimePickerEnd.Value <= dateTimePickerStart.Value)
                {
                    MessageBox.Show("Please make sure the starting date is earlier than the ending date or no data will be shown.");
                    //dateTimePickerStart.Value = graph.MinStartDate;
                    //dateTimePickerEnd.Value = graph.MaxEndDate;
                    return;
                }
                graph.GraphMinorGridLines = checkBoxMinorGrid.Checked;
                graph.GraphMajorGridLines = checkBoxMajorGrid.Checked;
                graph.GraphCandleSticks = checkBoxCandleSticks.Checked;
                graph.GraphClose = checkBoxClose.Checked;
                graph.GraphHigh = checkBoxHigh.Checked;
                graph.GraphLow = checkBoxLow.Checked;
                graph.GraphOpen = checkBoxOpen.Checked;
                graph.SetMovingAverage(1, checkBoxMovAvg1.Checked, (int)numericUpDownGraph1.Value);
                graph.SetMovingAverage(2, checkBoxMovAvg2.Checked, (int)numericUpDownGraph2.Value);
                graph.SetMovingAverage(3, checkBoxMovAvg3.Checked, (int)numericUpDownGraph3.Value);

                graph.StartDate = dateTimePickerStart.Value;
                graph.EndDate = dateTimePickerEnd.Value;

                graph.Invalidate();
            }
        }

        /// <summary>
        /// Applies the graphs settings to the controls in the control panel.
        /// </summary>
        private void setControlPanelState()
        {
            if (graph == null)
            {
                controlPanel.Enabled = false;
                return;
            }

            if (graph.Queries != null)
            {
                controlPanel.Enabled = true;

                labelEditing.Text = "Editing: " + graph.Text;
                checkBoxMinorGrid.Checked = graph.GraphMinorGridLines;
                checkBoxMajorGrid.Checked = graph.GraphMajorGridLines;
                checkBoxCandleSticks.Checked = graph.GraphCandleSticks;
                checkBoxClose.Checked = graph.GraphClose;
                checkBoxHigh.Checked = graph.GraphHigh;
                checkBoxLow.Checked = graph.GraphLow;
                checkBoxOpen.Checked = graph.GraphOpen;
                checkBoxMovAvg1.Checked = graph.GraphMovAvg1;
                checkBoxMovAvg2.Checked = graph.GraphMovAvg2;
                checkBoxMovAvg3.Checked = graph.GraphMovAvg3;

                if (graph.MovAvg1Days > numericUpDownGraph1.Minimum)
                {
                    numericUpDownGraph1.Value = graph.MovAvg1Days;
                    numericUpDownGraph2.Value = graph.MovAvg2Days;
                    numericUpDownGraph3.Value = graph.MovAvg3Days;
                }

                //Reset dates when switching between graphs.
                dateTimePickerEnd.MinDate = new DateTime(1755, 1, 1);
                dateTimePickerEnd.MaxDate = new DateTime(9000, 1, 1);
                dateTimePickerStart.MinDate = new DateTime(1755, 1, 1);
                dateTimePickerStart.MaxDate = new DateTime(9000, 1, 1);

                //Set the date limits.
                dateTimePickerEnd.MaxDate = graph.MaxEndDate;
                dateTimePickerEnd.MinDate = graph.MinStartDate;
                dateTimePickerStart.MaxDate = graph.MaxEndDate;
                dateTimePickerStart.MinDate = graph.MinStartDate;

                //Set the starting dates to the max range.
                dateTimePickerEnd.Value = graph.EndDate;
                dateTimePickerStart.Value = graph.StartDate;
            }
        }
        #endregion
    }
}
