using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;

namespace MedicalCheckInSystem
{
    public partial class ChangeApp : Form
    {
        ConfirmationScreen confirmationScreen;
        AppointmentOptions appointmentOptions;
        WelcomeScreen homeScreen;
        public NameSearch nameSearch;
        ErrorScreen errorScreen;
        AppChangeConf appChangeConf;

        public ChangeApp()
        {
            InitializeComponent();
        }

        private void ConfirmBtn_Click(object sender, EventArgs e)
        {
            if (ConfAppTxtBox.Text.Contains("rescheduled"))
            {
                if (appChangeConf == null)
                {
                    appChangeConf = new AppChangeConf();
                }
                appChangeConf.Show();
                appChangeConf.Left = this.Left;
                appChangeConf.Top = this.Top;
                this.Hide();
            }
            else
            {
                if (confirmationScreen == null)
                {
                    confirmationScreen = new ConfirmationScreen();
                }
                confirmationScreen.Show();
                confirmationScreen.Left = this.Left;
                confirmationScreen.Top = this.Top;
                this.Hide();
            }
            
        }

        private void ChangeAppBtn_Click(object sender, EventArgs e)
        {
            if (appointmentOptions == null)
            {
                appointmentOptions = new AppointmentOptions();
            }
            appointmentOptions.Show();
            appointmentOptions.Left = this.Left;
            appointmentOptions.Top = this.Top;
            ConfAppTxtBox.Clear();
            this.Close();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            if (homeScreen == null)
            {
                homeScreen = new WelcomeScreen();
            }
            homeScreen.Show();
            homeScreen.Left = this.Left;
            homeScreen.Top = this.Top;
            this.Hide();
        }

        private void ChangeApp_Load(object sender, EventArgs e)
        {
            //All data below, and names have either been removed for privacy or are made up for the project; thus not identfying anyone
            //If an appointment has been changed, do this
            if (AppointmentOptions.selectedAppointment != " ")
            {
                ConfAppTxtBox.Text = AppointmentOptions.selectedAppointment;
            }

            //For QR Code scanner
            else if (QRScanner.qrCodeInfo != " ")
            {
                ConfAppTxtBox.Text = QRScanner.qrCodeInfo;
            }

            //For Name Search Option
            else if (NameSearch.patientName == "[Removed for GitHub]")
            {
                NameSearch.patientName = "[Removed for GitHub]";
                ConfAppTxtBox.Text = "Hello " + NameSearch.patientName + ", your appointment is on 1st June 2021 at 4pm with Dr Smith";
                
            }
            else if (NameSearch.patientName == "[Removed for GitHub]")
            {
                NameSearch.patientName = "[Removed for GitHub]";
                ConfAppTxtBox.Text = "Hello " + NameSearch.patientName + ", your appointment is on 2nd June 2021 at 4pm with Dr Smith";
                
            }
            else if (NameSearch.patientName == "[Removed for GitHub]")
            {
                NameSearch.patientName = "[Removed for GitHub]";
                ConfAppTxtBox.Text = "Hello " + NameSearch.patientName + ", your appointment is on 3rd June 2021 at 4pm with Dr Smith";
            }
            else if (NameSearch.patientName == "[Removed for GitHub]")
            {
                NameSearch.patientName = "[Removed for GitHub]";
                ConfAppTxtBox.Text = "Hello [Removed for GitHub], your appointment is on 4th June 2021 at 4pm with Dr Smith";
            }
            else if (NameSearch.patientName == "JAMES MATTHEWS")
            {
                NameSearch.patientName = "James Matthews";
                ConfAppTxtBox.Text = "Hello [Removed for GitHub], your appointment is on 5th June 2021 at 4pm with Dr Smith";
            }
            else if (NameSearch.patientName == "[Removed for GitHub]")
            {
                NameSearch.patientName = "Danny Burnside";
                ConfAppTxtBox.Text = "Hello [Removed for GitHub], your appointment is on 6th June 2021 at 4pm with Dr Smith";
            }

            //For Date of Birth Search Option
            else if (DOBSearch.patientDOB == "[Removed for GitHub]")
            {
                NameSearch.patientName = "[Removed for GitHub]";
                ConfAppTxtBox.Text = "Hello [Removed for GitHub], your appointment is on 1st June 2021 at 4pm with Dr Smith";
                
            }
            else if (DOBSearch.patientDOB == "[Removed for GitHub]")
            {
                NameSearch.patientName = "[Removed for GitHub]";
                ConfAppTxtBox.Text = "Hello [Removed for GitHub], your appointment is on 2nd June 2021 at 4pm with Dr Smith";
                
            }
            else if (DOBSearch.patientDOB == "[Removed for GitHub]")
            {
                NameSearch.patientName = "[Removed for GitHub]";
                ConfAppTxtBox.Text = "Hello [Removed for GitHub], your appointment is on 3rd June 2021 at 4pm with Dr Smith";
                
            }
            else if (DOBSearch.patientDOB == "[Removed for GitHub]")
            {
                NameSearch.patientName = "[Removed for GitHub]";
                ConfAppTxtBox.Text = "Hello [Removed for GitHub], your appointment is on 4th June 2021 at 4pm with Dr Smith";
                
            }
            else if (DOBSearch.patientDOB == "[Removed for GitHub]")
            {
                NameSearch.patientName = "[Removed for GitHub]";
                ConfAppTxtBox.Text = "Hello [Removed for GitHub], your appointment is on 5th June 2021 at 4pm with Dr Smith";
                
            }
            else if (DOBSearch.patientDOB == "[Removed for GitHub]")
            {
                NameSearch.patientName = "[Removed for GitHub]";
                ConfAppTxtBox.Text = "Hello [Removed for GitHub], your appointment is on 7th June 2021 at 4pm with Dr Smith";
                
            }
            else if (DOBSearch.patientDOB == "[Removed for GitHub]")
            {
                NameSearch.patientName = "[Removed for GitHub]";
                ConfAppTxtBox.Text = "Hello [Removed for GitHub], your appointment is on 6th June 2021 at 4pm with Dr Smith";
                
            }

            //For NHS Number Search
            else if (NHSSearch.patientNHSNumber == "[Removed for GitHub]")
            {
                NameSearch.patientName = "[Removed for GitHub]";
                ConfAppTxtBox.Text = "Hello [Removed for GitHub], your appointment is on 1st June 2021 at 4pm with Dr Smith";
            }
            else if (NHSSearch.patientNHSNumber == "[Removed for GitHub]")
            {
                NameSearch.patientName = "[Removed for GitHub]";
                ConfAppTxtBox.Text = "Hello [Removed for GitHub], your appointment is on 2nd June 2021 at 4pm with Dr Smith";
            }
            else if (NHSSearch.patientNHSNumber == "[Removed for GitHub]")
            {
                NameSearch.patientName = "[Removed for GitHub]";
                ConfAppTxtBox.Text = "Hello [Removed for GitHub], your appointment is on 3rd June 2021 at 4pm with Dr Smith";
            }
            else if (NHSSearch.patientNHSNumber == "[Removed for GitHub]")
            {
                NameSearch.patientName = "[Removed for GitHub]";
                ConfAppTxtBox.Text = "Hello [Removed for GitHub], your appointment is on 4th June 2021 at 4pm with Dr Smith";
            }
            else if (NHSSearch.patientNHSNumber == "[Removed for GitHub]")
            {
                NameSearch.patientName = "[Removed for GitHub]";
                ConfAppTxtBox.Text = "Hello [Removed for GitHub], your appointment is on 5th June 2021 at 4pm with Dr Smith";
            }
            else if (NHSSearch.patientNHSNumber == "[Removed for GitHub]")
            {
                NameSearch.patientName = "[Removed for GitHub]";
                ConfAppTxtBox.Text = "Hello [Removed for GitHub], your appointment is on 6th June 2021 at 4pm with Dr Smith";
            }
            else if (NHSSearch.patientNHSNumber == "[Removed for GitHub]")
            {
                NameSearch.patientName = "[Removed for GitHub]";
                ConfAppTxtBox.Text = "Hello [Removed for GitHub], your appointment is on 7th June 2021 at 4pm with Dr Smith";
            }

            else
            {
                if (errorScreen == null)
                {
                    errorScreen = new ErrorScreen();
                }
                errorScreen.Show();
                errorScreen.Left = this.Left;
                errorScreen.Top = this.Top;
                this.Hide();
            }

        }
    }

}
