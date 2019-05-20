/* Ticket.cs
 * This class is a super or base class 
 * for campus event ticketing. It describes
 * the common characteristics of tickets
 * on campus.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketProcessingApp
{
    public abstract class  Ticket
    {
        private int seat;
		private string row;
		private string eventDateTime;
		private string eventName;
		private string eventType;
		private string eventLocation;
        private double ticketCost;

		public Ticket()
		{
		}

		public Ticket(int seatNum, string rowId, string dateTime,
				         string nameEvent, string type, string location, double cost)
		{
			eventType = type;
			eventName = nameEvent;
			eventLocation = location;
			eventDateTime = dateTime;
			seat = seatNum;
			row = rowId;
            ticketCost = cost;
		}

        public Ticket(string dateTime, string nameEvent, 
            string type, string location, double cost)
        {
            eventType = type;
            eventName = nameEvent;
            eventLocation = location;
            eventDateTime = dateTime;
            ticketCost = cost;
        }

        public Ticket(string dateTime, string nameEvent,
                      string location, double cost)
        {
            eventDateTime = dateTime;
            eventName = nameEvent;
            eventLocation = location;
            ticketCost = cost;
        }

        public Ticket(string dateTime, string nameEvent, double cost)
        {
            eventName = nameEvent;
            eventDateTime = dateTime;
            ticketCost = cost;
        }

        public Ticket(string dateTime, string nameEvent)
        {
            eventName = nameEvent;
            eventDateTime = dateTime;
        }

		public int Seat
		{
			get
			{
				return seat;
			}
			set
			{
				seat = value;
			}
		}
		
		public string Row
		{
			get
			{
				return row;
			}
			set
			{
				row = value;
			}
		}

		public string EventDateTime
		{
			get
			{
				return eventDateTime;
			}
			set
			{
				eventDateTime = value;
			}
		}

		public string EventName
		{
			get
			{
				return eventName;
			}
			set
			{
				eventName = value;
			}
		}

		public string EventType
		{
			get
			{
				return eventType;
			}
			set
			{
				eventType = value;
			}
		}

		public string EventLocation
		{
			get
			{
				return eventLocation;
			}
			set
			{
				eventLocation = value;
			}
		}


        public double TicketCost
        {
            get 
            { 
                return ticketCost; 
            }
            set 
            { 
                ticketCost = value; 
            }
        }
		

        public override string ToString()
        {
            return   eventType.ToUpper() + ":\t" + eventName +
                    "\n\tWhere:\t" + eventLocation +
                    "\n\tWhen:\t" + eventDateTime +
                    "\n\tCost:\t" + ticketCost.ToString("C") + 
                    "\n\tRow - Seat:  " + row + " - " + seat;
        }
	}
}

