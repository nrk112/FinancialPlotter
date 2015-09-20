using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FinancialPlotter.Interfaces
{
    interface IDataPlugin
    {
        List<IDailyQuery> Queries { get; }
        bool HasOptions { get; }
        Form OptionsForm { get; }
        Form ControlForm { get; }
        void LoadData();
    }
}
