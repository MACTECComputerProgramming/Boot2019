/* Play.cs
 * This class extends 
 * Ticket providing additional
 * details about upcoming plays.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketProcessingApp
{
    class Play : Ticket
    {
        private bool refreshmentsServed;
        private int numberOfActors;
        private string playSpecificInfo;

        public Play()
        {
        }

        public Play(int seatNum, string rowId, string dateTime,
            string nameEvent, string typeOfEvent, string location, 
            int numOfActors, string playDetails, double cost)
            : base(seatNum, rowId, dateTime, nameEvent, typeOfEvent, location, cost)
        {
            numberOfActors = numOfActors;
            playSpecificInfo = playDetails;
        }
        public Play(int seatNum, string rowId, string dateTime,
            string nameEvent, string type, string location, bool refreshments, 
            int numOfActors, string playInfo, double cost)
            : base(seatNum, rowId, dateTime, nameEvent, type, location, cost)
        {
            refreshmentsServed = refreshments;
            playSpecificInfo = playInfo;
            numberOfActors = numOfActors;

        }

        public Play(string dateTime, string nameEvent, int numOfActors, double cost)
            : base(dateTime, nameEvent, cost)
        {
            numberOfActors = numOfActors;
        }

        
        public bool RefreshmentsServed
        {
            get
            {
                return refreshmentsServed;
            }
            set
            {
                refreshmentsServed = value;
            }
        }

        public int NumberOfActors
        {
            get 
            { 
                return numberOfActors; 
            }
            set 
            { 
                numberOfActors = value; 
            }
        }

        public string PlaySpecificInfo
        {
            get
            {
                return playSpecificInfo;
            }
            set
            {
                playSpecificInfo = value;
            }
        }
        public override string ToString()
        {
            return base.ToString() +
                    "\nNumber of Actors: " + numberOfActors;
        }
    }
}
