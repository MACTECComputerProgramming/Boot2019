/* MonthName.cs
 * This class has one data member to hold
 * a month number. Methods in the class
 * return the associated month name and
 * the number of days in that month.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthNameApp
{
    class MonthName
    {
        private int monthNumber;

        public MonthName( )
        {
            
        }

        public MonthName(int num)
        {
            monthNumber = num;
        }

        public int MonthNumber
        {
            get
            {
                return monthNumber;
            }
            set
            {
                monthNumber = value;
            }
        }

        public string ReturnMonthName()
        {
            string name;
            switch (monthNumber)
            {
                case 1: name = "January";
                    break;
                case 2: name = "February";
                    break;
                case 3: name = "March";
                    break;
                case 4: name = "April";
                    break;
                case 5: name = "May";
                    break;
                case 6: name = "June";
                    break;
                case 7: name = "July";
                    break;
                case 8: name = "August";
                    break;
                case 9: name = "September";
                    break;
                case 10: name = "October";
                    break;
                case 11: name = "November";
                    break;
                case 12: name = "December";
                    break;
                default: name = "Improper Input";
                    break;
            }
            return name;
        }

        public int ReturnNumberOfDaysInMonth()
        {
            int numberOfDays;
            switch (monthNumber)
            {
                case 1:
                case 3:
                case 5:
                case 7:
                case 8:
                case 10:
                case 12: numberOfDays = 31;
                    break;
                case 4:
                case 6:
                case 9:
                case 11: numberOfDays = 30;
                    break;
                case 2: numberOfDays = 28;
                    break;
                default: numberOfDays = 0;
                    break;
            }
            return numberOfDays;
        }

        public override string ToString()
        {
            return "Month: " + ReturnMonthName() +
                "\nNumber of Days in the month: " + ReturnNumberOfDaysInMonth();
        }

    }
}
