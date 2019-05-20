/* AthleticTeam.cs   
 * A class describing common characteristics
 * of all teams. Defined as an abstract class;
 * thus, no objects can be instantiated from it.
 * Created as a class library - .dll produced as
 * output
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeamBaseClass
{
    public abstract class AthleticTeam
    {
        private string sport;
        private string primaryCoach;
        private string teamDoctor;
        private string practiceLocation1;

        public AthleticTeam()
        {
        }

        public AthleticTeam(string type, string headCoach)
        {
            sport = type;
            primaryCoach = headCoach;
        }

        public AthleticTeam(string type, string headCoach,
            string doctor, string site1)
        {
            sport = type;
            primaryCoach = headCoach;
            teamDoctor = doctor;
            practiceLocation1 = site1;
        }

        public virtual string GetSeasonTimeSpan()
        {
            return " August - May";
        }

        public virtual string GetWeightRoomAvailability()
        {
            return " MTWRF 10a-12p";
        }

        public virtual string GetSwimPoolAvailability()
        {
            return " MTWRF 4p-6p";
        }

        public string Sport
        {
            get
            {
                return sport;
            }
            set
            {
                sport = value;
            }
        }

        public string PrimaryCoach
        {
            get
            {
                return primaryCoach;
            }
            set
            {
                primaryCoach = value;
            }
        }

        public string TeamDoctor
        {
            get
            {
                return teamDoctor;
            }
            set
            {
                teamDoctor = value;
            }
        }

        public string PracticeLocation1
        {
            get
            {
                return practiceLocation1;
            }
            set
            {
                practiceLocation1 = value;
            }
        }

        public override string ToString()
        {
            return  "Sport: " +  sport +
                    "Coach: " + primaryCoach;
        }
    }

}
