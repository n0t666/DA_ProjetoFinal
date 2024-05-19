using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DA_ProjetoFinal
{
    public class UtilityController
    {

        public static int GetWeekNumber(DateTime date)
        {
            Calendar calendar = CultureInfo.CurrentCulture.Calendar;
            int week = calendar.GetWeekOfYear(date, CalendarWeekRule.FirstDay, DayOfWeek.Monday);
            return week;
        }
    }
}
