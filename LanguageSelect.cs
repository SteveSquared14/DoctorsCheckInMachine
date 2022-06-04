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
    public partial class LanguageSelect : Form
    {
        WelcomeScreen homeScreen;
        WelshScreen welshScreen;
        public LanguageSelect()
        {
            InitializeComponent();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            if (homeScreen == null)
            {
                homeScreen = new WelcomeScreen();
            }
            homeScreen.Show();
            this.Hide();
        }

        private void WelshBtn_Click(object sender, EventArgs e)
        {
            if (welshScreen == null)
            {
                welshScreen = new WelshScreen();
            }
            welshScreen.Show();
            this.Hide();
        }
    }
}
