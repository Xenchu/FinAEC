using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinAEC
{
    public class CountDownAEC
    {
        public DateTime DateFin { get; set; }

        public CountDownAEC(int yearEnd, int monthEnd, int dayEnd)
        {
            DateFin = new DateTime(yearEnd, monthEnd, dayEnd);
        }

        public Tuple<int, int, int, TimeSpan> GetTimeLeft()
        {
            var now = DateTime.Now;

            var year = DateFin.Year - now.Year;
            var yearLeft = year < 0 ? 0 : year;

            var month = DateFin.Month - now.Month;
            var monthLeft = month < 0 ? 0 : month;

            var days = DateFin.Day - now.Day;
            var daysLeft = days < 0 ? 0 : days;

            var timeleft = DateFin - now;

            return new Tuple<int, int, int, TimeSpan>(yearLeft, monthLeft, daysLeft, timeleft);
        }
    }
}
