using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlotter.Models
{
    class DailyQuery : Interfaces.IDailyQuery
    {
        public DailyQuery(DateTime Date, int open, int high, int low, int close, int volume)
        {
            this.Date = Date;
            this.Open = open;
            this.High = high;
            this.Low = low;
            this.Close = close;
            this.Volume = volume;
            this.AdjClose = 0;
        }

        public DailyQuery(DateTime Date, int open, int high, int low, int close, int volume, int adjClose)
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
        public int Open { get; }
        public int High { get; }
        public int Low { get; }
        public int Close { get; }
        public int Volume { get; }
        public int AdjClose { get; }
    }
}
