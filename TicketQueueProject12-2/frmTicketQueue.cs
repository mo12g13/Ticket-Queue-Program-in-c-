using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace TicketQueueProject12_2
{
    public partial class frmTicketQueue : Form
    {
        public frmTicketQueue()
        {
            InitializeComponent();
        }
        private QueueSettingUp setUp;
        private Queue<TimeSlot> timeSlotTicket;
        private Queue<Ticket> availableTicketQueue;

        private void timerConroller_Tick(object sender, EventArgs e)
        {
            // Changes the title of the based on the time setting of the option form
            DateTime currentDayTime = DateTime.Now;
          
            if (currentDayTime < setUp.StartTime || currentDayTime > setUp.EndTime)
            {
                this.Text= "Closed";
            }
            else
            {
               this.Text= "Open";
            }
            this.Text = DateTime.Now.ToLongTimeString() + " (" + this.Text + ")";

            // This condition checks to see if the next time is less the current time and if 
            //it is, you want to dequeue from the ticket queue
            if (timeSlotTicket.Peek().AvailableStartingTime <= DateTime.Now)
            {
                TimeSlot readtyTimeSlot = timeSlotTicket.Dequeue();

                // The loops below checks and remove the ticket for the next time that is available.
                //If the loops can't find the next timeslot, the loops should break that means the timeslot is not avaiable.
                List<Ticket> ticketsReadyToEnter = new List<Ticket>();
                while (true)
                {
                    if (availableTicketQueue.Count > 0 && availableTicketQueue.Peek().TicketTimsSlot == readtyTimeSlot)
                    {
                        ticketsReadyToEnter.Add(availableTicketQueue.Dequeue());
                    }
                    else
                    {
                        break;
                    }
                }
                clearListQueue();

                // If tecket ready to enter is equal to 1 set the ticket ready to enter to the specific values.
                string ticketsReadyToEnterString = "Not Ready";
                if (ticketsReadyToEnter.Count == 1)
                {
                    ticketsReadyToEnterString = ticketsReadyToEnter[0].tickNumber.ToString();
                }
                else if (ticketsReadyToEnter.Count == 2)
                {
                    string first = ticketsReadyToEnter[0].tickNumber.ToString();
                    string second = ticketsReadyToEnter[1].tickNumber.ToString();
                    ticketsReadyToEnterString = first + " and " + second;
                }
                else if (ticketsReadyToEnter.Count > 2)
                {
                    string first = ticketsReadyToEnter[0].tickNumber.ToString();
                    string last = ticketsReadyToEnter[ticketsReadyToEnter.Count - 1].tickNumber.ToString();
                    ticketsReadyToEnterString = first + " - " + last;
                }
                lblcurrentEntry.Text = ticketsReadyToEnterString;
            }

            // This label shows the total number of tickets that have been issued
            lblIssueTicket.Text = availableTicketQueue.Count.ToString();

        
            foreach (var timeSlot in timeSlotTicket)
            {
                if (timeSlot.TicketsIssued < setUp.GuestsPerWindow)
                {
                    lblNextTimeEntry.Text = timeSlot.AvailableStartingTime.ToShortTimeString();
                    break;
                }
            }
        }

       
        
        // Clears the ticket and sets the lstQueueTicket items to an array of the available queue
        private void clearListQueue()
        {
            lstQueueTicket.Items.Clear();
            lstQueueTicket.Items.AddRange(availableTicketQueue.ToArray());
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            //Clear the list box if the clicks yea
            DialogResult result = MessageBox.Show("Clicking Yes will delete all tickets from the queue.\n" +
                "Continue?", "Continue", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                optionFormDisplaySetting();
            }
        }
        //This method gets the setting from the Option form and have it seteup
        private void optionFormDisplaySetting()
        {
            
            frmOption optionsForm = new frmOption();
            setUp = optionsForm.GetSettings();

            // Create all of the time slots.
            timeSlotTicket = new Queue<TimeSlot>();
            DateTime timeSlotStartTime = setUp.StartTime;
            while (timeSlotStartTime.AddMinutes(setUp.MinutesPerWindow) <= setUp.EndTime)
            {
                timeSlotTicket.Enqueue(new TimeSlot(timeSlotStartTime, setUp.MinutesPerWindow));
                timeSlotStartTime = timeSlotStartTime.AddMinutes(setUp.MinutesPerWindow);
            }

            Ticket.SetFirstTicketNumber(setUp.FirstTicketNumber);
            availableTicketQueue = new Queue<Ticket>();
            //Enable of the timer control afer the formOption is being display

            timerConroller.Enabled = true;
        }

        //A method that frmTicketQueue that loads the form  options and it's setting by calling the optionFormDisplaySetting()
        private void FrmTicketQueue_Load(object sender, EventArgs e)
        {
            optionFormDisplaySetting();
        }
        // This button issued the available ticket to the next slot.
        private void btnIssueTicket_Click_1(object sender, EventArgs e)
        {
            TimeSlot nextAvailibleTimeSlot = null;
            foreach (var timeSlot in timeSlotTicket)
            {
                if (timeSlot.TicketsIssued < setUp.GuestsPerWindow)
                {
                    nextAvailibleTimeSlot = timeSlot;
                    break;
                }
            }

            if (nextAvailibleTimeSlot != null)
            {
                availableTicketQueue.Enqueue(new Ticket(nextAvailibleTimeSlot));
                nextAvailibleTimeSlot.TicketsIssued++;
                clearListQueue();
            }
        }
    }
}
//This setUp the time slot and minutes minutesPerWindow for each ticket in the queue
class TimeSlot
{
    public TimeSlot(DateTime startTime, int minutesPerWindow)
    {
        this.AvailableStartingTime = startTime;
        this.AvailabeMinutePerWindow = minutesPerWindow;
        this.AvailableEndingTime = AvailableStartingTime.AddMinutes(AvailabeMinutePerWindow);
        this.TicketsIssued = 0;
    }

    //This method return the available start and avalable end Time
    public override string ToString()
    {
        return "Start Time: " + AvailableStartingTime.ToShortTimeString() + " End Time: " + AvailableEndingTime.ToShortTimeString();
    }
   //Properties for the start time and available minutes per window
    public DateTime AvailableStartingTime { get; private set; }
    public DateTime AvailableEndingTime { get; private set; }
    public int AvailabeMinutePerWindow { get; private set; }
    public int TicketsIssued { get; set; }

}