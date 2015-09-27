using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlotter.Models
{
    public class DailyQuery : Interfaces.IDailyQuery
    {
        public DailyQuery(DateTime Date, float open, float high, float low, float close, float volume)
        {
            this.Date = Date;
            this.Open = open;
            this.High = high;
            this.Low = low;
            this.Close = close;
            this.Volume = volume;
            this.AdjClose = 0;
        }

        public DailyQuery(DateTime Date, float open, float high, float low, float close, float volume, float adjClose)
        {
            this.Date = Date;
            this.Open = open;
            this.High = high;
            this.Low = low;
            this.Close = close;
            this.Volume = volume;
            this.AdjClose = adjClose;
        }

        public DateTime Date { get; private set; }
        public float Open { get; private set; }
        public float High { get; private set; }
        public float Low { get; private set; }
        public float Close { get; private set; }
        public float Volume { get; private set; }
        public float AdjClose { get; private set; }
    }
}
