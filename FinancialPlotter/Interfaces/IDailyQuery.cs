using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlotter.Interfaces
{
    interface IDailyQuery
    {
        DateTime Date { get; }
        int Open { get; }
        int High { get; }
        int Low { get; }
        int Close { get; }
        int Volume { get; }
        int AdjClose { get; }
    }
}
