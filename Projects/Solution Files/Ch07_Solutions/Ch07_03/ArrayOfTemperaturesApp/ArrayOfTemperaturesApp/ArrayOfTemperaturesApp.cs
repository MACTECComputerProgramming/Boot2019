/* ArrayOfTemperaturesApp.cs
 * This class is used to test the public members of the
 * TemperatureArray class.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayOfTemperaturesApp
{
    class ArrayOfTemperaturesApp
    {
        static void Main(string[] args)
        {
            int[] weekOne = { 87, 98, 78, 88, 79, 89, 92 };
            ArrayOfTemperatures tempTest = new ArrayOfTemperatures(weekOne);

            Console.WriteLine("Average Temp: {0}", tempTest.ReturnAverage().ToString("F2"));
            Console.WriteLine("Lowest Temp: {0}", tempTest.ReturnSmallest().ToString("F0"));
            Console.WriteLine("Highest Temp: {0}", tempTest.ReturnLargest().ToString("F0"));
            Console.WriteLine("Average Temp excluding Lowest: {0}", tempTest.ReturnAverageExcludingSmallest().ToString("F2"));
            Console.WriteLine("Number of Days below {0}: {1}", 80, tempTest.ReturnDaysBelow(80));
            Console.WriteLine("Press any key to see the final test...");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(tempTest);

            Console.ReadKey();
        }
    }
}
