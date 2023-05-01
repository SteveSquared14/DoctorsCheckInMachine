using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MedicalCheckInSystem
{
    public partial class AppointmentOptions : Form
    {
        ChangeApp changeApp;
        CancellationConfirmation cancellationConfirmation;
        public static string selectedAppointment = " ";
        public AppointmentOptions()
        {
            InitializeComponent();
        }
        private void button_Click(object sender, EventArgs e)
        {
            selectedAppointment = "Hello " + NameSearch.patientName + " your appointment has been rescheduled to the " + ((Button)sender).Text;

            if (changeApp == null)
            {
                changeApp = new ChangeApp(); ;            }
            changeApp.Show();
            changeApp.Left = this.Left;
            changeApp.Top = this.Top;
            this.Hide();


        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (changeApp == null)
            {
                changeApp = new ChangeApp(); ;
            }
            changeApp.Show();
            changeApp.Left = this.Left;
            changeApp.Top = this.Top;
            this.Hide();
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            if (cancellationConfirmation == null)
            {
                cancellationConfirmation = new CancellationConfirmation(); ;
            }
            cancellationConfirmation.Show();
            cancellationConfirmation.Left = this.Left;
            cancellationConfirmation.Top = this.Top;
            this.Hide();
        }
    }
}
