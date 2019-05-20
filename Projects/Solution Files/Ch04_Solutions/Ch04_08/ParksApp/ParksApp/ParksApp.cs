/* ParksApp.cs
 * This application tests the instance methods
 * and properties of the Park class.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParksApp
{
    public class ParksApp
    {
        public static void Main(string[] args)
        {
            Park huegonot = new Park("Heugonot", "Kerry GA", 3.00);
            Park yulie = new Park("Yulie", "Wyoming", "National", "camping", 5.00, 500, 100000, 750000);
            Park Aster = new Park();

            Console.WriteLine(yulie);
            Console.WriteLine("Revenue From Fees: " + yulie.ComputeRevenueFromFees().ToString("C"));
            Console.WriteLine("Cost Per Visitor: "  + yulie.CalculateCostPerVisitor().ToString("C"));

            Console.WriteLine();
            Console.WriteLine();
            huegonot.FacilitiesAvailable = "Hiking, Biking, Camping";
            Console.WriteLine(huegonot.ParkFacilities());

            Console.WriteLine();
            Console.WriteLine();
            Aster.ParkName = "Aster Regional Park";
            Aster.ParkLocation = "Maine";
            Aster.TypeOfPark = "Local";
            Console.WriteLine(Aster.WhichPark());

            Console.ReadKey();
        }
    }
}
