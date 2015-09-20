using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlotter.Views
{
    public partial class StandardControlsForm : Form
    {
        public StandardControlsForm()
        {
            InitializeComponent();
        }

        private GraphForm graph;
        public GraphForm Graph
        {
            get { return graph; }
            set
            {
                graph = value;
                setControlPanelState();
            }
        }

        /// <summary>
        /// Applies the settings to the activated graph.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonApply_Click(object sender, EventArgs e)
        {
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

        /// <summary>
        /// Applies the graphs settings to the controls in the control panel.
        /// </summary>
        private void setControlPanelState()
        {
            if (graph.Queries != null)
            {
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
                numericUpDownGraph1.Value = graph.MovAvg1Days;
                numericUpDownGraph2.Value = graph.MovAvg2Days;
                numericUpDownGraph3.Value = graph.MovAvg3Days;

                dateTimePickerStart.MinDate = graph.Queries.Last().Date;
                dateTimePickerStart.MaxDate = graph.Queries.First().Date;
                dateTimePickerEnd.MinDate = graph.Queries.Last().Date;
                dateTimePickerEnd.MaxDate = graph.Queries.First().Date;
            }

        }

        private void dateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.MinDate = dateTimePickerStart.Value;
        }

        private void dateTimePickerEnd_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerStart.MaxDate = dateTimePickerEnd.Value;
        }
    }
}
