using FinancialPlotter.Interfaces;
using FinancialPlotter.Helpers;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace FinancialPlotter.Views
{
    public partial class GraphForm : Form
    {
        #region Graph Setup and Config
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
            SetupInitialState();
        }

        /// <summary>
        /// Configure the graphing transform object.
        /// </summary>
        private void SetupGraphingTransform()
        {
            Rectangle winRect = this.ClientRectangle;
            Rectangle subWinRect = winRect;

            float u1 = subWinRect.X;
            float v1 = subWinRect.Y;
            float u2 = subWinRect.X + subWinRect.Width - leftMargin;
            float v2 = subWinRect.Y + subWinRect.Height;

            //Constraints that determine the size of the graph to be translated onto the window. 
            float x1 = 0;
            float y1 = MaxGraphValue + bottomMargin;
            float x2 = getDaysCountInRange();
            float y2 = MinGraphValue;
            graphTransform = new GraphTransform(u1, v1, u2, v2, x1, y1, x2, y2, leftMargin, bottomMargin);
        }

        /// <summary>
        /// Sets up the default state of the gra[h.
        /// </summary>
        private void SetupInitialState()
        {
            ColorGraphClose = Color.Green;
            ColorGraphMov1 = Color.Magenta;
            ColorGraphMov2 = Color.Maroon;
            ColorGraphMov3 = Color.MistyRose;
            ColorGraphOpen = Color.DarkOrange;
            ColorGraphHigh = Color.LightBlue;
            ColorGraphLow = Color.DarkBlue;
            ColorGraphCandleDown = Color.DeepPink;
            ColorGraphCandleUp = Color.Turquoise;
            ColorGraphStickFigures = Color.Black;

            MovAvg1Days = 10;
            MovAvg2Days = 50;
            MovAvg3Days = 100;

            //Show only the closing graph at start.
            GraphClose = true;
            GraphMinorGridLines = true;

            toolTipCoordinates.SetToolTip(this, "");
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
        #endregion

        #region Properties **********************

        public List<IDailyQuery> Queries { get; set; }
        public bool GraphMajorGridLines { get; set; }
        public bool GraphMinorGridLines { get; set; }
        public bool GraphHigh { get; set; }
        public bool GraphLow { get; set; }
        public bool GraphClose { get; set; }
        public bool GraphOpen { get; set; }
        public bool GraphCandleSticks { get; set; }
        public bool GraphStickFigures { get; set; }
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
        public Color ColorGraphStickFigures { get; set; }

        private float leftMargin = 0.0f;
        private float bottomMargin = 0.0f;

        private Pen graphPen = new Pen(Color.Black, 0.2f);
        private GraphTransform graphTransform;
        private Bitmap graph;
        private Graphics bitmapGraphics;

        /// <summary>
        /// Gets the amount of days between the currently specified range of data.
        /// </summary>
        /// <returns></returns>
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
        /// Property that calculates the maximum value in the data set of this graph.
        /// </summary>
        public float MaxGraphValue
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
        public float MinGraphValue
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

        #endregion Properties **********************

        #region Drawing The Graphs

        /// <summary>
        /// Draws the Candle Sticks graph
        /// </summary>
        /// <param name="g">The Graphics fromt he object to draw to.</param>
        private void DrawGraphCandleSticks(Graphics g)
        {
            //Pen graphPen = new Pen(Color.Black);
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

        /// <summary>
        /// Draws the Candle Sticks graph
        /// </summary>
        /// <param name="g">The Graphics fromt he object to draw to.</param>
        private void DrawGraphStickFigures(Graphics g)
        {
            graphPen.Color = Color.Black;

            float offset = 0.5f;
            float thickness = offset * 2;

            int dayIndex = 0;
            foreach (IDailyQuery dailyQuery in Queries)
            {
                if (StartDate <= dailyQuery.Date && EndDate >= dailyQuery.Date)
                {
                    g.DrawLine(graphPen, dayIndex, dailyQuery.High, dayIndex, dailyQuery.Low);
                    g.DrawLine(graphPen, dayIndex, dailyQuery.Open, (dayIndex - offset), dailyQuery.Open);
                    g.DrawLine(graphPen, dayIndex, dailyQuery.Close, (dayIndex + offset), dailyQuery.Close);
                    dayIndex += 1;
                }
            }
        }

        /// <summary>
        /// Draws the Candle Sticks graph
        /// </summary>
        /// <param name="g">The Graphics fromt he object to draw to.</param>
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
                    if (dayIndex % 2 == 0)
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

        /// <summary>
        /// Draws the High Low Open Close graph.
        /// </summary>
        /// <param name="g">The Graphics fromt he object to draw to.</param>
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

        /// <summary>
        /// Draws the low values graph
        /// </summary>
        /// <param name="g">The Graphics fromt he object to draw to.</param>
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

        /// <summary>
        /// Draws the High values graph
        /// </summary>
        /// <param name="g">The Graphics fromt he object to draw to.</param>
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

        /// <summary>
        /// Currently does nothing. Axes were moved to graph lines method for now.
        /// </summary>
        /// <param name="g">The Graphics fromt he object to draw to.</param>
        private void DrawMajorGrid(Graphics g)
        {
            //Included in the DrawMinorGrid method for now.
        }

        /// <summary>
        /// Draws the graph lines and axes
        /// </summary>
        /// <param name="g">The Graphics fromt he object to draw to.</param>
        private void DrawMinorGrid(Graphics g)
        {
            //Draw Minor Lines
            graphPen.Color = Color.LightGray;

            //Verticle
            float xInc = (float)Math.Pow(10.0, Math.Floor(Math.Log10(graphTransform.xRange)) - 1);
            for (float x = 0f; x < graphTransform.x2; x += xInc)
            {
                g.DrawLine(graphPen, x, graphTransform.y1, x, graphTransform.y2);
            }

            //Horizontal
            float yInc = (float)Math.Pow(10.0, Math.Floor(Math.Log10(graphTransform.yRange)) - 1);
            for (float y = graphTransform.y2; y < graphTransform.y1; y += yInc)
            {
                g.DrawLine(graphPen, graphTransform.x1, y, graphTransform.x2, y);
            }

            //Draw Major Lines
            graphPen.Color = Color.Gray;
            SizeF sf;
            Bitmap bmp;

            //Verticle
            xInc = (float)Math.Pow(10.0, Math.Floor(Math.Log10(graphTransform.xRange)));
            for (float x = 0f; x < graphTransform.x2; x += xInc)
            {
                //Draw Lines 
                g.DrawLine(graphPen, x, graphTransform.y1, x, graphTransform.y2);

                //Draw X Axis
                if (GraphMajorGridLines)
                {
                    string stringToDraw = Queries.ElementAt((int)x).Date.ToShortDateString();
                    sf = g.MeasureString(stringToDraw, this.Font);
                    bmp = new Bitmap((int)sf.Width * 4, (int)sf.Height * 4);
                    bmp.SetResolution(384, 384);
                    using (Graphics bmpGraphics = Graphics.FromImage(bmp))
                    {
                        bmpGraphics.DrawString(stringToDraw, this.Font, Brushes.Black, 0, 0);
                    }
                    bmp.RotateFlip(RotateFlipType.Rotate180FlipX);
                    g.DrawImage(bmp, x, graphTransform.y2 - sf.Height);
                }
            }

            //Horizontal
            yInc = (float)Math.Pow(10.0, Math.Floor(Math.Log10(graphTransform.yRange)));
            for (float y = graphTransform.y2; y < graphTransform.y1; y += yInc)
            {
                //Draw Lines
                g.DrawLine(graphPen, graphTransform.x1, y, graphTransform.x2, y);

                //Draw y axis
                if (GraphMajorGridLines)
                {
                    sf = g.MeasureString(((int)y).ToString(), this.Font);
                    bmp = new Bitmap((int)sf.Width * 4, (int)sf.Height * 4);
                    bmp.SetResolution(384, 384);
                    using (Graphics bmpGraphics = Graphics.FromImage(bmp))
                    {
                        //bmpGraphics.ScaleTransform((bmp.Width / graphTransform.xRange), (graphTransform.yRange / bmp.Height));
                        bmpGraphics.DrawString(((int)y).ToString(), this.Font, Brushes.Black, 0, 0);
                    }
                    bmp.RotateFlip(RotateFlipType.Rotate180FlipX);
                    g.DrawImage(bmp, graphTransform.x1 - sf.Width, y);
                }
            }
        }

        /// <summary>
        /// Draws the moving average graphs.
        /// </summary>
        /// <param name="g">The graphics from the object to draw to.</param>
        /// <param name="graphID">The ID of the set of properties to use to draw the graph.</param>
        private void DrawGraphMovAvg(Graphics g, int graphID)
        {
            using (GraphicsPath gp = new GraphicsPath())
            {
                PointF firstPoint = new PointF(0, 0);
                PointF secondPoint = new PointF(0, 0);
                List<float> closePrices = new List<float>();
                float sum = 0.0f;
                float avgClose;

                int days = 0;
                switch (graphID)
                {
                    case 1:
                        days = MovAvg1Days;
                        graphPen.Color = ColorGraphMov1;
                        break;
                    case 2:
                        days = MovAvg2Days;
                        graphPen.Color = ColorGraphMov2;
                        break;
                    case 3:
                        days = MovAvg3Days;
                        graphPen.Color = ColorGraphMov3;
                        break;
                    default:
                        break;
                }

                int dayIndex = 0;
                foreach (IDailyQuery dailyQuery in Queries)
                {
                    if (StartDate <= dailyQuery.Date && EndDate >= dailyQuery.Date)
                    {
                        //Load the initial days to be summed before drawing.
                        if (dayIndex <= days)
                        {
                            closePrices.Add(dailyQuery.Close);
                        }
                        //When there is enough data, the calculations and drawing can begin.
                        else
                        {
                            sum = closePrices.Sum();
                            avgClose = sum / days;
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
                g.DrawPath(graphPen, gp);
            }
        }
        #endregion

        #region Event Handlers

        /// <summary>
        /// Repaints the graph form.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GraphForm_Paint(object sender, PaintEventArgs e)
        {
            graph = new Bitmap(this.Width, this.Height);
            bitmapGraphics = Graphics.FromImage(graph);

            //Set the margin for the Axis
            if (GraphMajorGridLines)
            {
                leftMargin = 50;
                bottomMargin = 30;
            }
            else
            {
                leftMargin = 0;
                bottomMargin = 0;
            }

            SetupGraphingTransform();

            if (this.WindowState != FormWindowState.Minimized)
            {
                bitmapGraphics.Transform = graphTransform.matrix;
            }

            if (GraphMajorGridLines) DrawMajorGrid(bitmapGraphics);
            if (GraphMinorGridLines) DrawMinorGrid(bitmapGraphics);
            if (GraphHigh) DrawGraphHigh(bitmapGraphics);
            if (GraphLow) DrawGraphLow(bitmapGraphics);
            if (GraphClose) DrawGraphClose(bitmapGraphics);
            if (GraphOpen) DrawGraphOpen(bitmapGraphics);
            if (GraphCandleSticks) DrawGraphCandleSticks(bitmapGraphics);
            if (GraphStickFigures) DrawGraphStickFigures(bitmapGraphics);
            if (GraphMovAvg1) DrawGraphMovAvg(bitmapGraphics, 1);
            if (GraphMovAvg2) DrawGraphMovAvg(bitmapGraphics, 2);
            if (GraphMovAvg3) DrawGraphMovAvg(bitmapGraphics, 3);

            e.Graphics.DrawImage(graph, 0, 0);
        }

        private void GraphForm_ResizeEnd(object sender, EventArgs e)
        {
            this.GraphCandleSticks = tempCandleSticksEnabled;
            this.GraphStickFigures = tempStickFigureEnabled;
            Invalidate();
        }

        private void GraphForm_ResizeBegin(object sender, EventArgs e)
        {
            tempCandleSticksEnabled = this.GraphCandleSticks;
            tempStickFigureEnabled = this.GraphStickFigures;
            this.GraphCandleSticks = false;
        }
        private bool tempCandleSticksEnabled;
        private bool tempStickFigureEnabled;

        private void GraphForm_Resize(object sender, EventArgs e)
        {
            Invalidate();
        }

        private void GraphForm_MouseClick(object sender, MouseEventArgs e)
        {
            ////Get the position of the cursor relative to the active window (graph)
            //Point p = PointToClient(Cursor.Position);

            ////Set the value of the x coordinate (date)
            //p.X = (int)((p.X / graphTransform.scaleX) + graphTransform.shiftX);
            //if (GraphMajorGridLines) p.X -= (int)leftMargin;

            ////Set the value of the y coordinate (value)
            //p.Y = (int)(this.Height * graphTransform.scaleY - (((p.Y / graphTransform.scaleY) - graphTransform.y1) - graphTransform.shiftY));

            //toolTipCoordinates.Show(p.ToString(), this);
        }

        private void GraphForm_MouseMove_1(object sender, MouseEventArgs e)
        {
            //toolTipCoordinates.Hide(this);
        }
        #endregion
    }
}
