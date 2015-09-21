using FinancialPlotter.Interfaces;
using FinancialPlotter.Helpers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FinancialPlotter.Views
{
    public partial class GraphForm : Form
    {
        /// <summary>
        /// Constructor for class.
        /// </summary>
        /// <param name="queries">Dataset to be used for graphing.</param>
        public GraphForm(List<IDailyQuery> queries)
        {
            this.Queries = queries;
            if (queries != null)
            {
                MinStartDate = StartDate = Queries.First().Date;
                MaxEndDate = EndDate = Queries.Last().Date;
            }

            InitializeComponent();
        }

        /// <summary>
        /// Repaints the graph form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GraphForm_Paint(object sender, PaintEventArgs e)
        {
            SetupGraphingTransform();

            if (this.WindowState != FormWindowState.Minimized)
            {
                e.Graphics.Transform = graphTransform.matrix;
            }

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

        #region Properties **********************

        public List<IDailyQuery> Queries { get; set; }
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
        public DateTime MinStartDate { get; private set; }
        public DateTime MaxEndDate { get; private set; }
        public Color ColorGraphHigh { get; set; }
        public Color ColorGraphLow { get; set; }
        public Color ColorGraphClose { get; set; }
        public Color ColorGraphOpen { get; set; }
        public Color ColorGraphMov1 { get; set; }
        public Color ColorGraphMov2 { get; set; }
        public Color ColorGraphMov3 { get; set; }
        public Color ColorGraphCandleUp { get; set; }
        public Color ColorGraphCandleDown { get; set; }

        #endregion Properties **********************

        private float leftMargin = 0.0f;
        private float bottomMargin = 0.0f;

        private Pen graphPen = new Pen(Color.Black, 0.2f);
        //private Pen blackPen = new Pen(Color.Black, 0.2f);
        private GraphTransform graphTransform;

        /// <summary>
        /// Configure the graphing transform object.
        /// </summary>
        private void SetupGraphingTransform()
        {
            Rectangle winRect = this.ClientRectangle;
            Rectangle subWinRect = winRect;

            float u1 = subWinRect.X;
            float v1 = subWinRect.Y;
            float u2 = subWinRect.X + subWinRect.Width;
            float v2 = subWinRect.Y + subWinRect.Height;

            //Constraints that determine the size of the graph to be translated onto the window. 
            float x1 = 0;
            float y1 = MaxValue;
            float x2 = getDaysCountInRange();
            float y2 = MinValue;
            graphTransform = new GraphTransform(u1, v1, u2, v2, x1, y1, x2, y2, leftMargin, bottomMargin);
        }

        private float getDaysCountInRange()
        {
            float dayIndex = 0.0f;
            foreach (IDailyQuery dailyQuery in Queries)
            {
                if (StartDate <= dailyQuery.Date && EndDate >= dailyQuery.Date)
                    dayIndex++;
            }
            return dayIndex;
            //return (float)(EndDate - StartDate).TotalDays;
        }

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

        /// <summary>
        /// Property that calculates the maximum value in the data set of this graph.
        /// </summary>
        public float MaxValue
        {
            get
            {
                float highest = 0.0f;
                foreach (IDailyQuery dailyQuery in Queries)
                {
                    if (StartDate <= dailyQuery.Date && EndDate >= dailyQuery.Date)
                    {
                        if (dailyQuery.High > highest)
                            highest = dailyQuery.High;
                    }
                }
                return highest;
            }
        }

        /// <summary>
        /// Property that calculates the minimum value in the data set of this graph.
        /// </summary>
        public float MinValue
        {
            get
            {
                float lowest = 9999.9f;
                foreach (IDailyQuery dailyQuery in Queries)
                {
                    if (StartDate <= dailyQuery.Date && EndDate >= dailyQuery.Date)
                    {
                        if (dailyQuery.Low < lowest && dailyQuery.Low != 0.0f)
                            lowest = dailyQuery.Low;
                    }
                }
                return lowest;
            }
        }

        private void DrawGraphCandleSticks(Graphics g)
        {
            graphPen.Color = Color.Black;
            SolidBrush brushUp = new SolidBrush(ColorGraphCandleUp);
            SolidBrush brushDown = new SolidBrush(ColorGraphCandleDown);

            float offset = 0.3f;
            float thickness = offset * 2;

            int dayIndex = 0;
            foreach (IDailyQuery dailyQuery in Queries)
            {
                if (StartDate <= dailyQuery.Date && EndDate >= dailyQuery.Date)
                {
                    g.DrawLine(graphPen, dayIndex, dailyQuery.High, dayIndex, dailyQuery.Low);
                    if (dailyQuery.Open < dailyQuery.Close)
                    {
                        g.FillRectangle(brushDown, dayIndex - offset, dailyQuery.Open, thickness, (dailyQuery.Close - dailyQuery.Open));
                    }
                    else
                    {
                        g.FillRectangle(brushUp, dayIndex - offset, dailyQuery.Close, thickness, (dailyQuery.Open - dailyQuery.Close));
                    }
                    dayIndex += 1;
                }
            }
        }

        private void DrawGraphOpen(Graphics g)
        {
            GraphicsPath gp = new GraphicsPath();
            PointF firstPoint = new PointF();
            PointF secondPoint = new PointF();
            int dayIndex = 0;
            foreach (IDailyQuery dailyQuery in Queries)
            {
                if (StartDate <= dailyQuery.Date && EndDate >= dailyQuery.Date)
                {
                    if (dayIndex %2 == 0)
                    {
                        firstPoint = new PointF(dayIndex, dailyQuery.Open);
                    }
                    else
                    {
                        secondPoint = new PointF(dayIndex, dailyQuery.Open);
                        gp.AddLine(firstPoint, secondPoint);
                    }
                    dayIndex += 1;
                }
            }
            graphPen.Color = ColorGraphOpen;
            g.DrawPath(graphPen, gp);
        }

        private void DrawGraphClose(Graphics g)
        {
            GraphicsPath gp = new GraphicsPath();
            PointF firstPoint = new PointF();
            PointF secondPoint = new PointF();
            int dayIndex = 0;
            foreach (IDailyQuery dailyQuery in Queries)
            {
                if (StartDate <= dailyQuery.Date && EndDate >= dailyQuery.Date)
                {
                    if (dayIndex % 2 == 0)
                    {
                        firstPoint = new PointF(dayIndex, dailyQuery.Close);
                    }
                    else
                    {
                        secondPoint = new PointF(dayIndex, dailyQuery.Close);
                        gp.AddLine(firstPoint, secondPoint);
                    }
                    dayIndex += 1;
                }
            }
            graphPen.Color = ColorGraphClose;
            g.DrawPath(graphPen, gp);
        }

        private void DrawGraphLow(Graphics g)
        {
            GraphicsPath gp = new GraphicsPath();
            PointF firstPoint = new PointF();
            PointF secondPoint = new PointF();
            int dayIndex = 0;
            foreach (IDailyQuery dailyQuery in Queries)
            {
                if (StartDate <= dailyQuery.Date && EndDate >= dailyQuery.Date)
                {
                    if (dayIndex % 2 == 0)
                    {
                        firstPoint = new PointF(dayIndex, dailyQuery.Low);
                    }
                    else
                    {
                        secondPoint = new PointF(dayIndex, dailyQuery.Low);
                        gp.AddLine(firstPoint, secondPoint);
                    }
                    dayIndex += 1;
                }
            }
            graphPen.Color = ColorGraphLow;
            g.DrawPath(graphPen, gp);
        }

        private void DrawGraphHigh(Graphics g)
        {
            GraphicsPath gp = new GraphicsPath();
            PointF firstPoint = new PointF();
            PointF secondPoint = new PointF();
            int dayIndex = 0;
            foreach (IDailyQuery dailyQuery in Queries)
            {
                if (StartDate <= dailyQuery.Date && EndDate >= dailyQuery.Date)
                {
                    if (dayIndex % 2 == 0)
                    {
                        firstPoint = new PointF(dayIndex, dailyQuery.High);
                    }
                    else
                    {
                        secondPoint = new PointF(dayIndex, dailyQuery.High);
                        gp.AddLine(firstPoint, secondPoint);
                    }
                    dayIndex += 1;
                }
            }
            graphPen.Color = ColorGraphHigh;
            g.DrawPath(graphPen, gp);
        }

        private void DrawMajorGrid(Graphics g)
        {
        }

        private void DrawMinorGrid(Graphics g)
        {
        }

        private void DrawGraphMovAvg3(Graphics g)
        {
            using (GraphicsPath gp = new GraphicsPath())
            {
                PointF firstPoint = new PointF(0, 0);
                PointF secondPoint = new PointF(0, 0);
                List<float> closePrices = new List<float>();
                float sum = 0.0f;
                float avgClose;

                int dayIndex = 0;
                foreach (IDailyQuery dailyQuery in Queries)
                {
                    if (StartDate <= dailyQuery.Date && EndDate >= dailyQuery.Date)
                    {
                        //Load the initial days to be summed before drawing.
                        if (dayIndex <= MovAvg3Days)
                        {
                            closePrices.Add(dailyQuery.Close);
                        }
                        //When there is enough data, the calculations and drawing can begin.
                        else
                        {
                            sum = closePrices.Sum();
                            avgClose = sum / MovAvg3Days;
                            closePrices.RemoveAt(0);
                            closePrices.Add(dailyQuery.Close);

                            if (dayIndex % 2 == 0)
                            {
                                firstPoint = new PointF(dayIndex, avgClose);
                            }
                            else
                            {
                                secondPoint = new PointF(dayIndex, avgClose);
                                gp.AddLine(firstPoint, secondPoint);
                            }
                        }
                        dayIndex++;
                    }
                }
                graphPen.Color = ColorGraphMov3;
                g.DrawPath(graphPen, gp);
            }
        }

        private void DrawGraphMovAvg2(Graphics g)
        {
            using (GraphicsPath gp = new GraphicsPath())
            {
                PointF firstPoint = new PointF(0, 0);
                PointF secondPoint = new PointF(0, 0);
                List<float> closePrices = new List<float>();
                float sum = 0.0f;
                float avgClose;

                int dayIndex = 0;
                foreach (IDailyQuery dailyQuery in Queries)
                {
                    if (StartDate <= dailyQuery.Date && EndDate >= dailyQuery.Date)
                    {
                        //Load the initial days to be summed before drawing.
                        if (dayIndex <= MovAvg2Days)
                        {
                            closePrices.Add(dailyQuery.Close);
                        }
                        //When there is enough data, the calculations and drawing can begin.
                        else
                        {
                            sum = closePrices.Sum();
                            avgClose = sum / MovAvg2Days;
                            closePrices.RemoveAt(0);
                            closePrices.Add(dailyQuery.Close);

                            if (dayIndex % 2 == 0)
                            {
                                firstPoint = new PointF(dayIndex, avgClose);
                            }
                            else
                            {
                                secondPoint = new PointF(dayIndex, avgClose);
                                gp.AddLine(firstPoint, secondPoint);
                            }
                        }
                        dayIndex++;
                    }
                }
                graphPen.Color = ColorGraphMov2;
                g.DrawPath(graphPen, gp);
            }
        }

        private void DrawGraphMovAvg1(Graphics g)
        {
            using (GraphicsPath gp = new GraphicsPath())
            {
                PointF firstPoint = new PointF(0, 0);
                PointF secondPoint = new PointF(0, 0);
                List<float> closePrices = new List<float>();
                float sum = 0.0f;
                float avgClose;

                int dayIndex = 0;
                foreach (IDailyQuery dailyQuery in Queries)
                {
                    if (StartDate <= dailyQuery.Date && EndDate >= dailyQuery.Date)
                    {
                        //Load the initial days to be summed before drawing.
                        if (dayIndex <= MovAvg1Days)
                        {
                            closePrices.Add(dailyQuery.Close);
                        }
                        //When there is enough data, the calculations and drawing can begin.
                        else
                        {
                            sum = closePrices.Sum();
                            avgClose = sum / MovAvg1Days;
                            closePrices.RemoveAt(0);
                            closePrices.Add(dailyQuery.Close);

                            if (dayIndex % 2 == 0)
                            {
                                firstPoint = new PointF(dayIndex, avgClose);
                            }
                            else
                            {
                                secondPoint = new PointF(dayIndex, avgClose);
                                gp.AddLine(firstPoint, secondPoint);
                            }
                        }
                        dayIndex++;
                    }
                }
                graphPen.Color = ColorGraphMov1;
                g.DrawPath(graphPen, gp);
            }
        }

        private void GraphForm_ResizeEnd(object sender, EventArgs e)
        {
            this.GraphCandleSticks = tempCandleSticksEnabled;
            Invalidate();
        }

        private void GraphForm_ResizeBegin(object sender, EventArgs e)
        {
            tempCandleSticksEnabled = this.GraphCandleSticks;
            this.GraphCandleSticks = false;
        }
        private bool tempCandleSticksEnabled;

        private void GraphForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }
    }
}
