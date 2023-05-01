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
    public partial class CancellationConfirmation : Form
    {
        WelcomeScreen welcomeScreen;
        public CancellationConfirmation()
        {
            InitializeComponent();
        }

        private void FinishBtn_Click(object sender, EventArgs e)
        {
            QRScanner.qrCodeInfo = " ";
            NameSearch.patientName = " ";
            DOBSearch.patientDOB = " ";
            NHSSearch.patientNHSNumber = " ";
            AppointmentOptions.selectedAppointment = " ";
            List<Form> openForms = new List<Form>();

            foreach (Form f in Application.OpenForms)
                openForms.Add(f);

            foreach (Form f in openForms)
            {
                if (f.Name != "WelcomeScreen")
                    f.Close();
                else
                {
                    if (welcomeScreen == null)
                    {
                        welcomeScreen = new WelcomeScreen();
                    }
                    welcomeScreen.Show();
                    welcomeScreen.Left = this.Left;
                    welcomeScreen.Top = this.Top;
                    this.Hide();
                }
            }
        }
    }
}
