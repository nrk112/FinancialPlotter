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
        public MainForm()
        {
            InitializeComponent();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            Models.LocalData localData = new Models.LocalData();
            if (localData.LoadData())
            {
                GraphForm childGraph = new GraphForm(localData.Queries);
                childGraph.MdiParent = this;
                childGraph.Text = localData.FileName;
                childGraph.Show();
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void propertiesPanelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            controlPanel.Visible = propertiesPanelToolStripMenuItem.Checked;
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
            SetControlPanelState();
        }

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
                graph.GraphStickFigures = checkBoxStickFigures.Checked;
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
        private void SetControlPanelState()
        {
            if (graph == null)
            {
                controlPanel.Enabled = false;
                return;
            }

            if (graph.Queries != null)
            {
                controlPanel.Enabled = true;

                //Set the Checkboxes
                labelEditing.Text = "Viewing: " + graph.Text;
                checkBoxMinorGrid.Checked = graph.GraphMinorGridLines;
                checkBoxMajorGrid.Checked = graph.GraphMajorGridLines;
                checkBoxCandleSticks.Checked = graph.GraphCandleSticks;
                checkBoxStickFigures.Checked = graph.GraphStickFigures;
                checkBoxClose.Checked = graph.GraphClose;
                checkBoxHigh.Checked = graph.GraphHigh;
                checkBoxLow.Checked = graph.GraphLow;
                checkBoxOpen.Checked = graph.GraphOpen;
                checkBoxMovAvg1.Checked = graph.GraphMovAvg1;
                checkBoxMovAvg2.Checked = graph.GraphMovAvg2;
                checkBoxMovAvg3.Checked = graph.GraphMovAvg3;

                //Set the moving avg days.
                if (graph.MovAvg1Days > numericUpDownGraph1.Minimum)
                    numericUpDownGraph1.Value = graph.MovAvg1Days;
                if (graph.MovAvg2Days > numericUpDownGraph2.Minimum)
                    numericUpDownGraph2.Value = graph.MovAvg2Days;
                if (graph.MovAvg3Days > numericUpDownGraph3.Minimum)
                    numericUpDownGraph3.Value = graph.MovAvg3Days;

                //Reset dates when switching between graphs.
                dateTimePickerEnd.MinDate = new DateTime(1755, 1, 1);
                dateTimePickerEnd.MaxDate = new DateTime(9000, 1, 1);
                dateTimePickerStart.MinDate = new DateTime(1755, 1, 1);
                dateTimePickerStart.MaxDate = new DateTime(9000, 1, 1);

                //Now set the date limits to desired values.
                dateTimePickerEnd.MaxDate = graph.MaxEndDate;
                dateTimePickerEnd.MinDate = graph.MinStartDate;
                dateTimePickerStart.MaxDate = graph.MaxEndDate;
                dateTimePickerStart.MinDate = graph.MinStartDate;

                //Set the starting dates to the max range.
                dateTimePickerEnd.Value = graph.EndDate;
                dateTimePickerStart.Value = graph.StartDate;

                //Set the colors of the buttons
                buttonColorClose.BackColor = graph.ColorGraphClose;
                buttonColorCandleDown.BackColor = graph.ColorGraphCandleDown;
                buttonColorCandleUp.BackColor = graph.ColorGraphCandleUp;
                buttonColorStickFigures.BackColor = graph.ColorGraphStickFigures;
                buttonColorMov1.BackColor = graph.ColorGraphMov1;
                buttonColorMov2.BackColor = graph.ColorGraphMov2;
                buttonColorMov3.BackColor = graph.ColorGraphMov3;
                buttonColorOpen.BackColor = graph.ColorGraphOpen;
                buttonColorHigh.BackColor = graph.ColorGraphHigh;
                buttonColorLow.BackColor = graph.ColorGraphLow;
            }
        }
        #endregion

        /// <summary>
        /// When a color button is pressed, it will call this function to set the appropriate colors.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonColorPicker_Click(object sender, EventArgs e)
        {
            Button colorButton = (Button)sender;

            //Set the initial value of the color dialog to the color of the button that was clicked.
            colorDialog1.Color = colorButton.BackColor;

            DialogResult result = colorDialog1.ShowDialog();
            if (result == DialogResult.OK)
            {

                //Set the graph color depending on the button.
                if (colorButton.Equals(buttonColorClose))
                {
                    graph.ColorGraphClose = colorDialog1.Color;
                }
                else if (colorButton.Equals(buttonColorMov1))
                {
                    graph.ColorGraphMov1 = colorDialog1.Color;
                }
                else if (colorButton.Equals(buttonColorMov2))
                {
                    graph.ColorGraphMov2 = colorDialog1.Color;
                }
                else if (colorButton.Equals(buttonColorMov3))
                {
                    graph.ColorGraphMov3 = colorDialog1.Color;
                }
                else if (colorButton.Equals(buttonColorCandleUp))
                {
                    graph.ColorGraphCandleUp = colorDialog1.Color;
                }
                else if (colorButton.Equals(buttonColorCandleDown))
                {
                    graph.ColorGraphCandleDown = colorDialog1.Color;
                }
                else if (colorButton.Equals(buttonColorLow))
                {
                    graph.ColorGraphLow = colorDialog1.Color;
                }
                else if (colorButton.Equals(buttonColorHigh))
                {
                    graph.ColorGraphHigh = colorDialog1.Color;
                }
                else if (colorButton.Equals(buttonColorOpen))
                {
                    graph.ColorGraphOpen = colorDialog1.Color;
                }
                else if (colorButton.Equals(buttonColorStickFigures))
                {
                    graph.ColorGraphStickFigures = colorDialog1.Color;
                }

                //Set the new color of the button that was clicked.
                colorButton.BackColor = colorDialog1.Color;
            }
        }
    }
}
