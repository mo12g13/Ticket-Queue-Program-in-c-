using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TicketQueueProject12_2
{
    //The queue setup class that set the queue.
   public class QueueSettingUp
    {

        //Queue Setting Constructors
        public QueueSettingUp(int windowMinutes, int guestWindow, DateTime startTime, DateTime endTime,
            int firstTicketNumber)
        {
            this.MinutesPerWindow = windowMinutes;
            this.GuestsPerWindow = guestWindow;
            this.StartTime = startTime;
            this.EndTime = endTime;
            this.FirstTicketNumber = firstTicketNumber;
        }
        //Getters and setters for the for minutes per window, guest per window and startTime
        public int MinutesPerWindow { get; set; }
        public int GuestsPerWindow { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }
        public int FirstTicketNumber { get; set; }
    }
}
