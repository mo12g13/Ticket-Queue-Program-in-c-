using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketQueueProject12_2
{
    class Ticket
    {
        //A static int for the ticket number that is being issued. 
        private static int nextAvailableTicket;
        public Ticket(TimeSlot nextAvailableTimeSlot)
        {
            this.tickNumber = nextAvailableTicket;
            nextAvailableTicket++;
            this.TicketTimsSlot = nextAvailableTimeSlot;
        }
    
        //Setting of the ticket number
        public static void SetFirstTicketNumber(int ticketNumber)
        {
            nextAvailableTicket = ticketNumber;
        }
        // A method that returns the Ticket Number and Next Available time
        public override string ToString()
        {
            return "Ticket " + tickNumber + " " + TicketTimsSlot.AvailableStartingTime.ToShortTimeString();
        }
        //Set and get property for the ticket number and Available time slot
        public int tickNumber { get; private set; }
        public TimeSlot TicketTimsSlot { get; private set; }

       

    }
}
