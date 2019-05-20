/*  Rowing.cs   
  * This class is a derived class of 
  * the AthleticTeam. It includes
  * additional characteristics of
  * boatHouseHours and headCoxswain.
  */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBaseClass
{
    public class Rowing : AthleticTeam
    {
        private string boatHouseHours;
        private string headCoxswain;

        public Rowing()
            : base()
        {
        }

        public Rowing(string sportType, string primCoach, string boatHsHrs)
            : base(sportType, primCoach)
        {
            boatHouseHours = boatHsHrs;
        }

        public Rowing(string sportType, string primCoach, string boatHsHrs,
                        string headRower)
            : base(sportType, primCoach)
        {
            boatHouseHours = boatHsHrs;
            headCoxswain = headRower;
        }


        public override string GetWeightRoomAvailability()
        {
            return " MTFS 6a-7a  &  " + base.GetWeightRoomAvailability();
        }

        public override string GetSwimPoolAvailability()
        {
            return " TRS 9a-11a  &  " + base.GetSwimPoolAvailability();
        }

        public override string GetSeasonTimeSpan()
        {
            return "Nov - April";
        }

        public string BoatHouseHours
        {
            get
            {
                return boatHouseHours;
            }
            set
            {
                boatHouseHours = value;
            }
        }

        public string HeadCoxswain
        {
            get
            {
                return headCoxswain;
            }
            set
            {
                headCoxswain = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() +
                "\nHeadCoxswain: " + headCoxswain;

        }
    }
}
