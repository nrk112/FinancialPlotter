﻿using System;
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

                if (graph.MovAvg1Days > numericUpDownGraph1.Minimum)
                {
                    numericUpDownGraph1.Value = graph.MovAvg1Days;
                    numericUpDownGraph2.Value = graph.MovAvg2Days;
                    numericUpDownGraph3.Value = graph.MovAvg3Days;
                }

                //Reset dates when switching between graphs.
                dateTimePickerEnd.MinDate = new DateTime(1755,1,1);
                dateTimePickerEnd.MaxDate = new DateTime(9000,1,1);
                dateTimePickerStart.MinDate = new DateTime(1755,1,1);
                dateTimePickerStart.MaxDate = new DateTime(9000,1,1);

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
    }
}