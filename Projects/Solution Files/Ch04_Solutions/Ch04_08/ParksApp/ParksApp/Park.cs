/* Park.cs
 * This class has data members for location, 
 * type of park (i.e. national, state, local) 
 * facilities, fee, number of  employees, 
 * number of visitors recorded for the past 12 months, and annual budget. 
 * In addition to constructors and properties defined, methods are 
 * included that return the cost per visitor and the revenue from fees for 
 * the past year based on the number of visitors.
*/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParksApp
{
    public class Park
    {
        private string parkName;
        private string  parkLocation;
        private string  typeOfPark;
        private string  facilitiesAvailable;
        private double  entranceFee;
        private int numberOfEmployees;
        private int numberOfVisitorsLastYear;
        private double annualBudget;

        public Park(string name, string location, string parkType, string facilities, double fee, int employees, int visitors, double budget)
        {
            parkName = name;
            parkLocation = location;
            typeOfPark = parkType;
            facilitiesAvailable = facilities;
            entranceFee = fee;
            numberOfEmployees = employees;
            numberOfVisitorsLastYear = visitors;
            annualBudget = budget;
        }

        public Park(string name, string location, string parkType, string facilities, double fee, int employees, int visitors)
        {
            parkName = name;
            parkLocation = location;
            typeOfPark = parkType;
            facilitiesAvailable = facilities;
            entranceFee = fee;
            numberOfEmployees = employees;
            numberOfVisitorsLastYear = visitors;
        }

        public Park(string name, string location, string parkType, string facilities, double fee, double budget)
        {
            parkName = name;
            parkLocation = location;
            typeOfPark = parkType;
            facilitiesAvailable = facilities;
            entranceFee = fee;
            annualBudget = budget;
        }

        public Park(string name, string location, string parkType, string facilities, double fee)
        {
            parkName = name;
            parkLocation = location;
            typeOfPark = parkType;
            facilitiesAvailable = facilities;
            entranceFee = fee;
        }

        public Park(string name, string location, string parkType, string facilities)
        {
            parkName = name;
            parkLocation = location;
            typeOfPark = parkType;
            facilitiesAvailable = facilities;
        }

        public Park(string name, string location, double fee)
        {
            parkName = name;
            parkLocation = location;
            entranceFee = fee;
        }

        public Park(string name, string location)
        {
            parkName = name;
            parkLocation = location;
        }

        public Park(string name)
        {
            parkName = name;
        }

        public Park()
        {
        }

        public string ParkName
        {
            get
            {
                return parkName;
            }
            set
            {
                parkName = value;
            }
        }

        public string ParkLocation
        {
            get
            {
                return parkLocation;
            }
            set
            {
                parkLocation = value;
            }
        }

        public string TypeOfPark
        {
            get
            {
                return typeOfPark;
            }
            set
            {
                typeOfPark = value;
            }
        }

        public string FacilitiesAvailable
        {
            get
            {
                return facilitiesAvailable;
            }
            set
            {
                facilitiesAvailable = value;
            }
        }

        public double EntranceFee
        {
            get
            {
                return entranceFee;
            }
            set
            {
                entranceFee = value;
            }
        }

        public int NumberOfEmployees
        {
            get
            {
                return numberOfEmployees;
            }
            set
            {
                numberOfEmployees = value;
            }
        }

        public int NumberOfVisitorsLastYear
        {
            get
            {
                return numberOfVisitorsLastYear;
            }
            set
            {
                numberOfVisitorsLastYear = value;
            }
        }

        public double AnnualBudget
        {
            get
            {
                return annualBudget;
            }
            set
            {
                annualBudget = value;
            }
        }

        public string WhichPark()
        {
            return "Park: " + parkName +
                "\nPark Location: " + parkLocation +
                "\nType of Park: " + typeOfPark;
        }

        public string ParkFacilities()
        {
            return "Park: " + parkName +
                "\nFacilities Available: " + facilitiesAvailable;
        }

        public double CalculateCostPerVisitor()
        {
            return annualBudget / numberOfVisitorsLastYear;
        }

        public double ComputeRevenueFromFees()
        {
            return numberOfVisitorsLastYear * entranceFee;
        }

        public override string ToString()
        {
            return "Park: " + parkName +
                "\nPark Location: " +  parkLocation +
                "\nType of Park: " + typeOfPark +
                "\nFacilities Available: " + facilitiesAvailable +
                "\nEntrance Fee: " + entranceFee.ToString("C") +
                "\nNumber of Employees: " + numberOfEmployees +
                "\nNumber of Visitors Last Year: " + numberOfVisitorsLastYear.ToString("N") +
                "\nAnnual Budget: " + annualBudget.ToString("C");
        }
    }
}
