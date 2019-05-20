/*Trip.cs
 * Include data members of distance traveled, 
 * total cost of gasoline, and number of gallons 
 * consumed. Includes a method that calculates destination 
 * per gallon and the cost per mile. 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TripApp
{
    class Trip
    {
        private string destination;
        private double distanceTraveled;
        private double fuelCost;
        private double gallonsConsumed;

        public Trip()
        {
        }
        public Trip(string dest)
        {
            destination = dest;
        }
        public Trip(string dest, double distance)
        {
            destination = dest;
            distanceTraveled = distance;
        }
        public Trip(string dest, double distance, double fuel)
        {
            destination = dest;
            distanceTraveled = distance;
            fuelCost = fuel;
        }
        public Trip(string dest, double distance, double fuel, double gallons)
        {
            destination = dest;
            distanceTraveled = distance;
            fuelCost = fuel;
            gallonsConsumed = gallons;
        }

        public string Destination
        {
            get
            {
                return destination;
            }
            set
            {
                destination = value;
            }
        }

        public double DistanceTraveled
        {
            get
            {
                return distanceTraveled;
            }
            set
            {
                distanceTraveled = value;
            }
        }

        public double FuelCost
        {
            get
            {
                return fuelCost;
            }
            set
            {
                fuelCost = value;
            }

        }

        public double GallonsConsumed
        {
            get
            {
                return gallonsConsumed;
            }
            set
            {
                gallonsConsumed = value;
            }
        }

        public double CalculateMilesPerGallon()
        {
            return distanceTraveled / gallonsConsumed;
        }

        public double CalculateCostPerMile()
        {
            return fuelCost / distanceTraveled;
        }

        public override string ToString()
        {
            return "Destination: " + destination +
                "\nTotal Miles: " + distanceTraveled +
                 "\nFuel Consumed: " + gallonsConsumed.ToString("f1") + " gallons" +
                 "\nCost: " + fuelCost.ToString("c") +
                 "\nMPG: " + CalculateMilesPerGallon().ToString("f0") +
                 "\nCost Per Mile: " + CalculateCostPerMile().ToString("c");
        }
    }
}
