using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlotter.Models
{
    class DailyQuery : Interfaces.IDailyQuery
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

        public DateTime Date { get; }
        public float Open { get; }
        public float High { get; }
        public float Low { get; }
        public float Close { get; }
        public float Volume { get; }
        public float AdjClose { get; }
    }
}
