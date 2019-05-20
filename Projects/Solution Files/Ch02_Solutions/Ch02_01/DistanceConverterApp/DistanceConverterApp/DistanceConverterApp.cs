/* DistanceConverterApp.cs
 * This application converts miles into 
 * feet and then converts that value into inches.
 * To satisfy the problem definition, change
 * the value for miles and re-run the application.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceConverterApp
{
    class DistanceConverterApp
    {
        static void Main(string[] args)
        {
            const int FEET_PER_MILE = 5280;
            double miles = 4.5;
            double feet,
                inches;

            feet = FEET_PER_MILE * miles;
            inches = feet * 12;

            Console.WriteLine("\tDistance Converter App\n");
            Console.WriteLine("Miles:  {0:N2}", miles);
            Console.WriteLine("Equivalent Feet:  {0:N0}", feet);
            Console.WriteLine("Equivalent Inches:  {0:N0}", inches);

            Console.ReadKey();
        }
    }
}
