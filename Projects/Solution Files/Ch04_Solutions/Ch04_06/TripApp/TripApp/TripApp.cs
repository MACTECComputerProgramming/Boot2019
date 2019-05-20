/*TripApp.cs
 *This class tests the Trip class. 
 *It allows users to input destination traveled and
 *fuel consumed.
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripApp
{
    class TripApp
    {
        static void Main(string[] args)
        {
            
            Trip aTrip = new Trip();
            aTrip.Destination = AskForDestination();
            aTrip.DistanceTraveled = AskForMilesTraveled();
            aTrip.GallonsConsumed = AskForFuelConsumed();
            aTrip.FuelCost = AskForFuelCost();

            Console.Clear();
            Console.WriteLine(aTrip);

            Console.WriteLine("\n\n");
            Trip anotherTrip = new Trip("Atlanta", 600, 120, 45);
            Console.WriteLine(anotherTrip);

            Console.WriteLine("\n\n");
            Trip lastTrip = new Trip("Boston", 300);
            lastTrip.FuelCost = 90;
            lastTrip.GallonsConsumed = 26;
            Console.WriteLine(lastTrip);
            Console.ReadKey();
        }

        public static string AskForDestination()
        {
            string inValue;
            Console.Write("Enter Trip Destination: ");
            inValue = Console.ReadLine();
            return inValue;
        }

        public static double AskForMilesTraveled()
        {
            string inValue;
            double miles;
            Console.Write("Enter Miles Traveled: ");
            inValue = Console.ReadLine();
            miles = double.Parse(inValue);
            return miles;
        }

        public static double AskForFuelConsumed()
        {
            string inValue;
            double fuel;
            Console.Write("Enter Gallons: ");
            inValue = Console.ReadLine();
            fuel = double.Parse(inValue);
            return fuel;
        }
        public static double AskForFuelCost()
        {
            string inValue;
            double cost;
            Console.Write("Enter Total Fuel Cost: ");
            inValue = Console.ReadLine();
            cost = double.Parse(inValue);
            return cost;
        }
    }
}
