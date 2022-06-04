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
    public partial class CleaningModeActivated : Form
    {
        WelcomeScreen welcomeScreen;
        public int counter = 30;
        public CleaningModeActivated()
        {
            InitializeComponent();
        }

        private void CleaningModeActivated_Load(object sender, EventArgs e)
        {
            timer1.Start();
            //if () //check if the timer has reached its time limite. If so, show the homescreen
            {
                timer1.Interval = 30000;
                timer1.Tick += new EventHandler(timer1_Tick);
                timer1.Start();

                int counter = 30;
                timer2 = new Timer();
                timer2.Tick += new EventHandler(timer2_Tick);
                timer2.Interval = 1000; // 1 second
                timer2.Start();
                label4.Text = counter.ToString();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (welcomeScreen == null)
            {
                welcomeScreen = new WelcomeScreen();
            }
            welcomeScreen.Show();
            welcomeScreen.Left = this.Left;
            welcomeScreen.Top = this.Top;
            this.Close();
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            counter--;
            if (counter == 0)

                timer1.Stop();
            label4.Text = counter.ToString();
        }
    }
}
