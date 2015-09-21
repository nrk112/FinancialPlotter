using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlotter.Helpers
{
    class GraphTransform
    {
        public GraphTransform(float U1, float V1, float U2, float V2, float X1, float Y1, float X2, float Y2, float leftMargin, float bottomMargin)
        {
            this.LeftMargin = leftMargin;
            this.BottomMargin = bottomMargin;

            this.u1 = U1;
            this.u2 = U2;
            this.v1 = V1;
            this.v2 = V2;

            this.x1 = X1;
            this.x2 = X2;
            this.y1 = Y1;
            this.y2 = Y2;

            SetupMatrix();
        }

        float scaleX;
        float scaleY;

        float shiftX;
        float shiftY;

        public float u1 { get; private set; }
        public float v1 { get; private set; }
        public float u2 { get; private set; }
        public float v2 { get; private set; }
        public float x1 { get; private set; }
        public float y1 { get; private set; }
        public float x2 { get; private set; }
        public float y2 { get; private set; }
        public float LeftMargin { get; private set; }
        public float BottomMargin { get; private set; }
        public Matrix matrix { get; private set; }

        private void SetupMatrix()
        {
            matrix = new Matrix();

            scaleX = (u2 - u1) / (x2 - x1);
            scaleY = (v2 - v1) / (y2 - y1);

            matrix.Scale(scaleX, scaleY);

            shiftX = -x1 + (LeftMargin / 2);
            shiftY = -y1 + (BottomMargin / 2);

            matrix.Translate(shiftX, shiftY);
        }
        public float xRange
        {
            get { return Math.Abs(x2 - x1); }
        }

        public float yRange
        {
            get { return Math.Abs(y2 - y1); }
        }
    }
}
