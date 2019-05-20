/* MonthNameApp.cs
 * This application tests the MonthName class.
 * It asks for an integer between 1 and 12, then
 * instantiates an object of the MonthName class.
 * A call to the MonthName's ToString( ) method
 * displays the associated month and its
 * integral number of days.
 * 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonthNameApp
{
    class MonthNameApp
    {
        static void Main(string[] args)
        {
            int monthNumber;

            Console.Write("You will be asked to enter a number from 1 - 12. \nThe month associated with"
                + " the number will be displayed along with \nthe number of days in the month.\n\n");

            Console.WriteLine("\nPress any key when you are ready to begin...");
            Console.ReadKey();
            Console.Clear();

			monthNumber = GetInput( );
            MonthName firstTest = new MonthName(monthNumber);
            Console.WriteLine(firstTest);

            Console.WriteLine("\n\nPress any key when you are ready to do another test...");
            Console.ReadKey();
            Console.Clear();

            monthNumber = GetInput();
            MonthName secondTest = new MonthName(monthNumber);
            Console.WriteLine(secondTest);

            Console.WriteLine("\n\nPress any key when you are ready to do another test...");
            Console.ReadKey();
            Console.Clear();

            monthNumber = GetInput();
            MonthName thirdTest = new MonthName(monthNumber);
            Console.WriteLine(thirdTest);

           Console.ReadKey();
		}

		public static int GetInput( )
		{
            int inputNumber;
			Console.Write( "Please enter an integer between 1 - 12 representing the month number: " );			
			if (int.TryParse(Console.ReadLine(), out inputNumber) == false)
                Console.WriteLine("Invalid month number entered - month set to 0");
			return inputNumber;			
		}

    }
}
