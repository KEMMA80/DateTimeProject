using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateTimeClassLibrary
{
    public class DateTimeClass
    {
        /// <summary>
        /// метод, определяющий дату предыдущего дня
        /// </summary>
        public DateTime PrevDate(DateTime prevDay)
        {
            if (prevDay == new DateTime())
            {
                throw new Exception("Не введена дата");
            }
            else
            {
                prevDay = prevDay.AddDays(-1);
                return prevDay;
            }
        }

        /// <summary>
        /// метод, определяющий дату предыдущего дня
        /// </summary>
        public DateTime NextDate(DateTime nextDay)
        {
            if (nextDay == new DateTime())
            {
                throw new Exception("Не введена дата");
            }
            else
            {
                nextDay = nextDay.AddDays(1);
                return nextDay;
            }
        }

        /// <summary>
        /// метод, определяющий дни до конца месяца
        /// </summary>
        public int DaysUntilEndMonth(DateTime day)
        {
            if (day == new DateTime())
            {
                throw new Exception("Не введена дата");
            }
            else
            {
                int daysInMonth = DateTime.DaysInMonth(day.Year, day.Month);
                daysInMonth = daysInMonth - day.Day;
                return daysInMonth;
            }
        }
        /// <summary>
        /// метод, определяющий високосный год
        /// </summary>
        public bool LeapYearCheck(DateTime day)
        {
            if (day == new DateTime())
            {
                throw new Exception("Не введена дата");
            }
            else
            {
                return DateTime.IsLeapYear(day.Year);
            }
        }

        /// <summary>
        /// метод, определяющий дату некоторого по счету дня относительно установленной даты
        /// </summary>
        public DateTime FindDate(DateTime day, int days)
        {
            if (day == new DateTime())
            {
                throw new Exception("Не введена дата");
            }
            else
            {
                return day.AddDays(days);
            }
        }

        /// <summary>
        /// метод, определяющий последний день месяца
        /// </summary>
        public bool LastDayOfMonthCheck(DateTime day)
        {
            if (day == new DateTime())
            {
                throw new Exception("Не введена дата");
            }
            else
            {
                int daysInMonth = DateTime.DaysInMonth(day.Year, day.Month);
                if (day.Day == daysInMonth)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

        /// <summary>
        /// метод, определяющий первый день месяца
        /// </summary>
        public bool FirstDayOfMonthCheck(DateTime day)
        {
            if (day == new DateTime())
            {
                throw new Exception("Не введена дата");
            }
            else
            {

                if (day.Day == 1 && day.Month == 1) 
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }

    }
}
