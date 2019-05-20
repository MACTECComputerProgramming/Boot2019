/* This application creates a motorway class with data members
 * of name of motorway, type, direction, surface, number of lanes, toll or 
 * not toll and the party that maintains it. Instance methods
 * returns the full name of the motorway, full name of the 
 * motorway and whether it is toll or not,  full name of the 
 * motorway and the number of lanes. A ToString( ) method 
 * returns all data memberss. 
 */


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MotorwayApp
{
    public class Motorway
    {
        private string nameOfMotorway;
        private string typeOfMotorway;
        private char direction;
        private string surface;
        private int numberOfLanes;
        private bool toll;
        private string whoMaintains;

        public Motorway()
        {
        }

        public Motorway(string name, string suffixPartOfName, char northSouthEastOrWest)
        {
            nameOfMotorway = name;
            typeOfMotorway = suffixPartOfName;
            direction = northSouthEastOrWest;
        }

        public Motorway(string name, string suffixPartOfName, char northSouthEastOrWest, bool isItToll)
        {
            nameOfMotorway = name;
            typeOfMotorway = suffixPartOfName;
            direction = northSouthEastOrWest;
            toll = isItToll;
        }

        public Motorway(string name, string suffixPartOfName, char northSouthEastOrWest, bool isItToll, string whoseRoad)
        {
            nameOfMotorway = name;
            typeOfMotorway = suffixPartOfName;
            direction = northSouthEastOrWest;
            toll = isItToll;
            whoMaintains = whoseRoad;
        }


        public Motorway(string name, string suffixPartOfName, char northSouthEastOrWest, bool isItToll, 
                            string whoseRoad, string typeOfSurface)
        {
            nameOfMotorway = name;
            typeOfMotorway = suffixPartOfName;
            direction = northSouthEastOrWest;
            toll = isItToll;
            whoMaintains = whoseRoad;
            surface = typeOfSurface;
        }

        public Motorway(string name, string suffixPartOfName, char northSouthEastOrWest, bool isItToll, 
                            string whoseRoad, string typeOfSurface, int lanes)
        {
            nameOfMotorway = name;
            typeOfMotorway = suffixPartOfName;
            direction = northSouthEastOrWest;
            toll = isItToll;
            whoMaintains = whoseRoad;
            surface = typeOfSurface;
            numberOfLanes = lanes;
        }

        public Motorway(string name, string suffixPartOfName, char northSouthEastOrWest, int lanes)
        {
            nameOfMotorway = name;
            typeOfMotorway = suffixPartOfName;
            direction = northSouthEastOrWest;
            numberOfLanes = lanes;
        }

        public string NameOfMotorway
        {
            get
            {
                return nameOfMotorway;
            }
            set
            {
                nameOfMotorway = value;
            }
        }

        public string TypeOfMotorway
        {
            get
            {
                return typeOfMotorway;
            }
            set
            {
                typeOfMotorway = value;
            }
        }

        public char Direction
        {
            get
            {
                return direction;
            }
            set
            {
                direction = value;
            }
        }

        public int NumberOfLanes
        {
            get
            {
                return numberOfLanes;
            }
            set
            {
                numberOfLanes = value;
            }
        }

        public string Surface
        {
            get
            {
                return surface;
            }
            set
            {
                surface = value;
            }
        }

        public bool Toll
        {
            get
            {
                return toll;
            }
            set
            {
                toll = value;
            }
        }


        public string WhoMaintains
        {
            get
            {
                return whoMaintains;
            }
            set
            {
                whoMaintains = value;
            }
        }

        public string ReturnFullName()
        {
            return "Name of Motorway: " + nameOfMotorway + " " + typeOfMotorway + " " + direction;
        }

        public string ReturnTollInformation()
        {
            return ReturnFullName( ) + "\n" +
                   "Toll: " + toll;
        }

        public string ReturnLaneInformation()
        {
            return ReturnFullName() + "\n" +
                   "Number of Lanes: " + numberOfLanes;
        }

        public override string ToString()
        {
            return ReturnFullName() +
                   "\nToll: " + toll +
                   "\nNumber of Lanes: " + numberOfLanes +
                   "\nType of Surface: " + surface +
                   "\nMaintained by: " + whoMaintains;
        }
    }
}