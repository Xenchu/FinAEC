namespace FinAEC
{
    public class CountDownAEC
    {
        public DateTime DateFin { get; set; }

        public CountDownAEC(int yearEnd, int monthEnd, int dayEnd)
        {
            DateFin = new DateTime(yearEnd, monthEnd, dayEnd);
        }

        public TimeLeft GetTimeLeft()
        {
            var exit = false;
            var now = DateTime.Now;

            var timeleft = DateFin - now;

            var yearLeft = 0;
            var monthLeft = 0;
            var daysLeft = timeleft.Days;

            var startYear = now.Year;

            while (daysLeft >= 365)
            {
                if (IsLeapYear(startYear) && daysLeft < 366)
                    break;

                daysLeft = IsLeapYear(startYear) ? daysLeft - 366 : daysLeft - 365;
                yearLeft += 1;
                startYear += 1;
            }

            var monthToCalculate = now.Month;

            while (daysLeft >= 28)
            {
                monthToCalculate += 1;
                monthToCalculate = monthToCalculate > 12 ? 1 : monthToCalculate;

                if (monthToCalculate != DateFin.Month)
                {
                    switch (monthToCalculate)
                    {
                        case 1: case 3: case 5: case 7: case 8: case 10: case 12:
                            if (daysLeft < 31)
                            {
                                exit = true;
                                break;
                            }
                            daysLeft -= 31;
                            break;
                        case 4: case 6: case 9: case 11:
                            if (daysLeft < 30)
                            {
                                exit = true;
                                break;
                            }
                            daysLeft -= 30;
                            break;
                        case 2:
                            if ((IsLeapYear(startYear) && daysLeft < 29) || (!IsLeapYear(startYear) && daysLeft < 28))
                            {
                                exit = true;
                                break;
                            }
                            else
                            {
                                daysLeft = IsLeapYear(startYear) ? daysLeft - 29 : daysLeft - 28;
                                break;
                            }
                    }
                }
                else
                {
                    exit = true;
                }

                if (exit) break;

                monthLeft += 1;
            }

            return new TimeLeft()
            {
                Years = yearLeft,
                Month = monthLeft,
                Days = daysLeft,
                Hours = timeleft.Hours,
                Minutes = timeleft.Minutes,
                Seconds = timeleft.Seconds
            };
        }

        private bool IsLeapYear(int year)
        {
            bool isLeapYear;

            if (year % 400 == 0 || (year % 4 == 0 && year % 100 != 0))
                isLeapYear = true;
            else
                isLeapYear = false;

            return isLeapYear;
        }
    }
}
