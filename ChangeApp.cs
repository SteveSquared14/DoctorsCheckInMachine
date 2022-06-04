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
            else if (NameSearch.patientName == "JULIE DUCKETT")
            {
                NameSearch.patientName = "Julie Duckett";
                ConfAppTxtBox.Text = "Hello " + NameSearch.patientName + ", your appointment is on 1st June 2021 at 4pm with Dr Smith";
                
            }
            else if (NameSearch.patientName == "JONATHAN DUCKETT")
            {
                NameSearch.patientName = "Jonathan Duckett";
                ConfAppTxtBox.Text = "Hello " + NameSearch.patientName + ", your appointment is on 2nd June 2021 at 4pm with Dr Smith";
                
            }
            else if (NameSearch.patientName == "CLAIRE DUCKETT")
            {
                NameSearch.patientName = "Claire Duckett";
                ConfAppTxtBox.Text = "Hello " + NameSearch.patientName + ", your appointment is on 3rd June 2021 at 4pm with Dr Smith";
            }
            else if (NameSearch.patientName == "ALMA DUCKETT")
            {
                NameSearch.patientName = "Alma Duckett";
                ConfAppTxtBox.Text = "Hello Alma Duckett, your appointment is on 4th June 2021 at 4pm with Dr Smith";
            }
            else if (NameSearch.patientName == "JAMES MATTHEWS")
            {
                NameSearch.patientName = "James Matthews";
                ConfAppTxtBox.Text = "Hello James Matthews, your appointment is on 5th June 2021 at 4pm with Dr Smith";
            }
            else if (NameSearch.patientName == "DANNY BURNSIDE")
            {
                NameSearch.patientName = "Danny Burnside";
                ConfAppTxtBox.Text = "Hello Danny Burnside, your appointment is on 6th June 2021 at 4pm with Dr Smith";
            }

            //For Date of Birth Search Option
            else if (DOBSearch.patientDOB == "30081960")
            {
                NameSearch.patientName = "Julie Duckett";
                ConfAppTxtBox.Text = "Hello Julie Duckett, your appointment is on 1st June 2021 at 4pm with Dr Smith";
                
            }
            else if (DOBSearch.patientDOB == "11051963")
            {
                NameSearch.patientName = "Jonathan Duckett";
                ConfAppTxtBox.Text = "Hello Jonathan Duckett, your appointment is on 2nd June 2021 at 4pm with Dr Smith";
                
            }
            else if (DOBSearch.patientDOB == "03091993")
            {
                NameSearch.patientName = "Claire Duckett";
                ConfAppTxtBox.Text = "Hello Claire Duckett, your appointment is on 3rd June 2021 at 4pm with Dr Smith";
                
            }
            else if (DOBSearch.patientDOB == "24071934")
            {
                NameSearch.patientName = "Alma Duckett";
                ConfAppTxtBox.Text = "Hello Alma Duckett, your appointment is on 4th June 2021 at 4pm with Dr Smith";
                
            }
            else if (DOBSearch.patientDOB == "26011996")
            {
                NameSearch.patientName = "James Matthews";
                ConfAppTxtBox.Text = "Hello James Matthews, your appointment is on 5th June 2021 at 4pm with Dr Smith";
                
            }
            else if (DOBSearch.patientDOB == "11091993")
            {
                NameSearch.patientName = "Danny Burnside";
                ConfAppTxtBox.Text = "Hello Danny Burnside, your appointment is on 7th June 2021 at 4pm with Dr Smith";
                
            }
            else if (DOBSearch.patientDOB == "08031997")
            {
                NameSearch.patientName = "Lauren Hamilton-Smith";
                ConfAppTxtBox.Text = "Hello Lauren Hamilton-Smith, your appointment is on 6th June 2021 at 4pm with Dr Smith";
                
            }

            //For NHS Number Search
            else if (NHSSearch.patientNHSNumber == "3187562901")
            {
                NameSearch.patientName = "Julie Duckett";
                ConfAppTxtBox.Text = "Hello Julie Duckett, your appointment is on 1st June 2021 at 4pm with Dr Smith";
            }
            else if (NHSSearch.patientNHSNumber == "1231663021")
            {
                NameSearch.patientName = "Jonathan Duckett";
                ConfAppTxtBox.Text = "Hello Jonathan Duckett, your appointment is on 2nd June 2021 at 4pm with Dr Smith";
            }
            else if (NHSSearch.patientNHSNumber == "7057112127")
            {
                NameSearch.patientName = "Claire Duckett";
                ConfAppTxtBox.Text = "Hello Claire Duckett, your appointment is on 3rd June 2021 at 4pm with Dr Smith";
            }
            else if (NHSSearch.patientNHSNumber == "1135288273")
            {
                NameSearch.patientName = "Alma Duckett";
                ConfAppTxtBox.Text = "Hello Alma Duckett, your appointment is on 4th June 2021 at 4pm with Dr Smith";
            }
            else if (NHSSearch.patientNHSNumber == "1517124713")
            {
                NameSearch.patientName = "James Matthews";
                ConfAppTxtBox.Text = "Hello James Matthews, your appointment is on 5th June 2021 at 4pm with Dr Smith";
            }
            else if (NHSSearch.patientNHSNumber == "9043814190")
            {
                NameSearch.patientName = "Lauren Hamilton-Smith";
                ConfAppTxtBox.Text = "Hello Lauren Hamilton-Smith, your appointment is on 6th June 2021 at 4pm with Dr Smith";
            }
            else if (NHSSearch.patientNHSNumber == "4691610835")
            {
                NameSearch.patientName = "Danny Burnside";
                ConfAppTxtBox.Text = "Hello Danny Burnside, your appointment is on 7th June 2021 at 4pm with Dr Smith";
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
