/* Lecture.cs
 * This class extends Ticket
 * adding lecture
 * specific information.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketProcessingApp
{
    class Lecture : Ticket
    {
        private bool projectionNeeded;
        private string lectureTopic;

        public Lecture()
        {
            projectionNeeded = false;
        }

        public Lecture(int seatNum, string rowId, string dateTime,
            string nameEvent, string type, string location, double cost)
            : base(seatNum, rowId, dateTime, nameEvent, type, location, cost)
        {

        }
        public Lecture(int seatNum, string rowId, string dateTime,
            string nameEvent, string type, string location, bool projector, string info, double cost)
            : base(seatNum, rowId, dateTime, nameEvent, type, location, cost)
        {
            projectionNeeded = projector;
            lectureTopic = info;
        }

        public Lecture(string dateTime, string nameEvent, string info)
            : base(dateTime, nameEvent)
        {
            lectureTopic = info;
        }

        public bool ProjectionNeeded
        {
            get
            {
                return projectionNeeded;
            }
            set
            {
                projectionNeeded = value;
            }
        }

        public string LectureTopic
        {
            get
            {
                return lectureTopic;
            }
            set
            {
                lectureTopic = value;
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nLecture Topic: " + lectureTopic;
        }
    }
}
