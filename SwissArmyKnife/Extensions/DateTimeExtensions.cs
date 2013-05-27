using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwissArmyKnife.Extensions
{
    public static class DateTimeExtensions
    {
        public static DateTime GetNextDateForDay(this DateTime startDate, DayOfWeek desiredDay)
        {
            DateTime nextDate = startDate;
            while (nextDate.DayOfWeek != desiredDay)
                nextDate = nextDate.AddDays(1D);

            return nextDate;
        }

        public static DateTime GetNextSunday(this DateTime fromDate)
        {
            DateTime date = new DateTime(year: fromDate.Year, month: fromDate.Month, day: fromDate.Day, hour: 0, minute: 1, second: 0);

            return date.AddDays(7 - (date.DayOfWeek == DayOfWeek.Sunday ? 7 : (int)date.DayOfWeek));
        }

        public static DateTime GetLastMonday(this DateTime fromDate)
        {
            DateTime date = new DateTime(year: fromDate.Year, month: fromDate.Month, day: fromDate.Day, hour: 0, minute: 1, second: 0);

            return date.Subtract(new TimeSpan((int)date.DayOfWeek - 1, 0, 0, 0, 0));
        }
    }
}
