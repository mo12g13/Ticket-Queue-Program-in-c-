using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicketQueueProject12_2
{
    public partial class frmOption : Form
    {
        public frmOption()
        {
            InitializeComponent();
        }
        //A private reference variable of the QueueSettingup Class to be instantiate if the ok button is pressed
        private QueueSettingUp queueSetUp = null;

        private void FrmOptions_Load(object sender, EventArgs e)
        {
            // Setting of the default time
            startTimeValue.Value = DateTime.Now;
            //Setting the endTime Which adds 4 hours to the start time
            endTimeValue.Value = DateTime.Now.AddHours(4);
        }

        // A method that returns the queue set up when the ok button is pressed
        public QueueSettingUp GetSettings()
        {
            this.ShowDialog();
            return queueSetUp;
        }


 

        private void FrmOptions_Load_1(object sender, EventArgs e)
        {

            // Defualt Time setUp. set both the start end and the endTime
            startTimeValue.Value = DateTime.Now;
            endTimeValue.Value = DateTime.Now.AddHours(4);
        }

        private void btnOk_Click_1(object sender, EventArgs e)
        {
            // Checking the range of the time to make sure it is in the specify range
            if (IsValidTimeRange(startTimeValue, endTimeValue, minPerWindow))
            {
                int minutesPerWindow = (int)minPerWindow.Value;
                int guestsPerWindow = (int)this.guestPerWindow.Value;
                DateTime startTime = startTimeValue.Value;
                DateTime endTime = endTimeValue.Value;
                int firstTicketNumber = (int)this.firstTicketNumber.Value;

                queueSetUp = new QueueSettingUp(minutesPerWindow, guestsPerWindow, startTime, endTime, firstTicketNumber);
                this.Close();
            }
        }
        public static bool IsValidTimeRange(DateTimePicker startTime, DateTimePicker endTime, NumericUpDown numberOfTickets)
        {
            //if the start is greater than the end time, prompt the usser to right time
            if (startTime.Value > endTime.Value)
            {
                MessageBox.Show("End time should be lesser than start time.", "Selection Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                endTime.Focus();
                return false;
            }


            // This condition check to see if there is two times of the start and end date
            TimeSpan twoTimeSlotsSpan = TimeSpan.FromMinutes((int)numberOfTickets.Value * 2);
            if (endTime.Value - startTime.Value < twoTimeSlotsSpan)
            {
                MessageBox.Show(" Difference for two time must be between start and end time.", "Selection Error",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
                endTime.Focus();
                return false;
            }

            return true;
        }
    }
}

