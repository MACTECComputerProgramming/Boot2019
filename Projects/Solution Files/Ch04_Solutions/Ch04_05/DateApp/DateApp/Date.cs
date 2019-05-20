/* Date.cs
 * Date class includes integer data members 
 * for year, month and day and a string data member for the month. 
 * It override the ToString( ) method providing a 
 * date formatted with slashes (/) separating the month, day and year.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateApp
{
    class Date
    {
        private int month;
        private int day;
        private int year;
        private string monthName;

        public Date()
        {
        }

        public Date(int m, int d, int y)
        {
            month = m;
            day = d;
            year = y;
        }

        public Date(string mon, int d, int y)
        {
            monthName = mon;
            day = d;
            year = y;
        }


        public int Month
        {
            get
            {
                return month;
            }
            set
            {
                month = value;
            }
        }

        public string MonthName
        {
            get
            {
                return monthName;
            }
            set
            {
                monthName = value;
            }
        }

        public int Day
        {
            get
            {
                return day;
            }
            set
            {
                day = value;
            }
        }

        public int Year
        {
            get
            {
                return year;
            }
            set
            {
                year = value;
            }
        }

        public string ReturnLongDate()
        {
            return monthName + " " + day + ", " + year;
        }

        public override string ToString()
        {
            return month + "/" +
                day + "/" +
                year;
        }
    }
}
