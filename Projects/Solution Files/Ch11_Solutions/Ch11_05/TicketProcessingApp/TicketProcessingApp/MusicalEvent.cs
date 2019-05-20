/* MusicalEvent.cs
 * This class extends the 
 * Ticket class providing
 * details regarding upcoming 
 * musical events.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketProcessingApp
{
    class MusicalEvent : Ticket
    {
        private string performerName;
        private bool memoriabilityOnSale;
        private bool backStageOffered;
        private bool signsAutographAvailable;

        public MusicalEvent()
            : base()
        { 
        }

        public MusicalEvent(string performer, string eventDateTime, string eventName,
                      string eventLocation, double cost)
            : base (eventDateTime, eventName, eventLocation, cost)
        {
            performerName = performer;
        }

        public MusicalEvent(string performer, string eventDateTime, string eventName,
                             string eventLocation, bool memoriability, 
                            bool backStage, bool signsAutograph, double cost)
            : base(eventDateTime, eventName, eventLocation, cost)
        {
            performerName = performer;
            memoriabilityOnSale = memoriability;
            backStageOffered =  backStage;
            signsAutographAvailable = signsAutograph;
        }

        public string PerformerName
        {
            get 
            { 
                return performerName; 
            }
            set 
            { 
                performerName = value; 
            }
        }

        public bool MemoriabilityOnSale
        {
            get 
            { 
                return memoriabilityOnSale; 
            }
            set 
            { 
                memoriabilityOnSale = value; 
            }
        }

        public bool BackStageOffered
        {
            get 
            { 
                return backStageOffered; 
            }
            set 
            { 
                backStageOffered = value; 
            }
        }

        public bool SignsAutographAvailable
        {
            get 
            { 
                return signsAutographAvailable; 
            }
            set 
            { 
                signsAutographAvailable = value; 
            }
        }

        public override string ToString()
        {
            return base.ToString() +
                "\nPerformers: " + performerName;
        }
    }
}
