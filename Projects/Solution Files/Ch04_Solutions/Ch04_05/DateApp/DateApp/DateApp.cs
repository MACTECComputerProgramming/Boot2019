/* DateApp.cs
 * This class tests the Date class.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DateApp
{
    class DateApp
    {
        static void Main(string[] args)
        {
            Date aDate = new Date();
            aDate.Month = AskForInput("Month");
            aDate.Day = AskForInput("Day");
            aDate.Year = AskForInput("Year");
            
            Console.Clear();
            Console.WriteLine("\tFirst Test");
            Console.WriteLine(aDate);

            Date secondDate = new Date();
            secondDate.Month = 3;
            secondDate.Day = 20;
            secondDate.Year = 2010;
            Console.WriteLine("\n\tSecond Test: ");
            Console.WriteLine(secondDate);

            Console.WriteLine("\n\tThird Test ");
            Date anotherDate = new Date(2, 2, 2011);
            Console.WriteLine("Date: " + anotherDate.ToString());

            Console.WriteLine("\n\tLast Test ");
            Date lastOne = new Date("October", 3, 2013);
            Console.WriteLine(lastOne.ReturnLongDate());

            Console.ReadKey();
        }

        public static int AskForInput(string whichOne)
        {
            string inValue;
            Console.Write("Enter a number representing the {0}: ", whichOne);
            inValue = Console.ReadLine();
            return (int.Parse(inValue));
        }
    }
}
