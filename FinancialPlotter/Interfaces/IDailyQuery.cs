using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinancialPlotter.Interfaces
{
    public interface IDailyQuery
    {
        DateTime Date { get; }
        float Open { get; }
        float High { get; }
        float Low { get; }
        float Close { get; }
        float Volume { get; }
        float AdjClose { get; }
    }
}
