using FinancialPlotter.Interfaces;
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
    public partial class GraphForm : Form
    {
        public GraphForm(List<IDailyQuery> queries)
        {
            this.queries = queries;
            InitializeComponent();
        }

        private void GraphForm_Paint(object sender, PaintEventArgs e)
        {
            if (GraphMajorGridLines) DrawMajorGrid(e.Graphics);
            if (GraphMinorGridLines) DrawMinorGrid(e.Graphics);
            if (GraphHigh) DrawGraphHigh(e.Graphics);
            if (GraphLow) DrawGraphLow(e.Graphics);
            if (GraphClose) DrawGraphClose(e.Graphics);
            if (GraphOpen) DrawGraphOpen(e.Graphics);
            if (GraphCandleSticks) DrawGraphCandleSticks(e.Graphics);
            if (GraphMovAvg1) DrawGraphMovAvg1(e.Graphics);
            if (GraphMovAvg2) DrawGraphMovAvg2(e.Graphics);
            if (GraphMovAvg3) DrawGraphMovAvg3(e.Graphics);
        }

        private List<IDailyQuery> queries;

        public List<IDailyQuery> Queries
        {
            get { return queries; }
            set { queries = value; }
        }
        public bool GraphMajorGridLines { get; set; }
        public bool GraphMinorGridLines { get; set; }
        public bool GraphHigh { get; set; }
        public bool GraphLow { get; set; }
        public bool GraphClose { get; set; }
        public bool GraphOpen { get; set; }
        public bool GraphCandleSticks { get; set; }
        public bool GraphMovAvg1 { get; private set; }
        public bool GraphMovAvg2 { get; private set; }
        public bool GraphMovAvg3 { get; private set; }
        public int MovAvg1Days { get; private set; }
        public int MovAvg2Days { get; private set; }
        public int MovAvg3Days { get; private set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }


        private Pen blackPen = new Pen(Color.Black);

        /// <summary>
        /// Sets the values needed to graph the moving averages.
        /// </summary>
        /// <param name="id">The graph to set (1-3)</param>
        /// <param name="enabled">True to enable graphing.</param>
        /// <param name="days">The amount of days used to calculate the average.</param>
        public void SetMovingAverage(int id, bool enabled, int days)
        {
            switch (id)
            {
                case 1:
                    GraphMovAvg1 = enabled;
                    MovAvg1Days = days;
                    break;
                case 2:
                    GraphMovAvg2 = enabled;
                    MovAvg2Days = days;
                    break;
                case 3:
                    GraphMovAvg3 = enabled;
                    MovAvg3Days = days;
                    break;
                default:
                    throw new ArgumentOutOfRangeException("The argument is out of range.", "id");
            }
        }

        private void DrawGraphCandleSticks(Graphics g)
        {
            //throw new NotImplementedException();
        }

        private void DrawGraphOpen(Graphics g)
        {
            //throw new NotImplementedException();
        }

        private void DrawGraphClose(Graphics g)
        {
            //throw new NotImplementedException();
        }

        private void DrawGraphLow(Graphics g)
        {
            //throw new NotImplementedException();
        }

        private void DrawGraphHigh(Graphics g)
        {
            //throw new NotImplementedException();
        }

        private void DrawMajorGrid(Graphics g)
        {
            g.DrawLine(blackPen, this.Width / 6, this.Height / 6, this.Width - 50, this.Height - 50);
            //throw new NotImplementedException();
        }

        private void DrawMinorGrid(Graphics g)
        {
            //throw new NotImplementedException();
        }
        private void DrawGraphMovAvg3(Graphics g)
        {
            //throw new NotImplementedException();
        }

        private void DrawGraphMovAvg2(Graphics g)
        {
            //throw new NotImplementedException();
        }

        private void DrawGraphMovAvg1(Graphics g)
        {
            //throw new NotImplementedException();
        }

        private void GraphForm_ResizeEnd(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
