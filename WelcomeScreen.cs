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
    public partial class WelcomeScreen : Form
    {
        ModeSelection modeSelect;
        AdminSettings adminScreen;
        LanguageSelect languageScreen;
        public WelcomeScreen()
        {
            InitializeComponent();
        }

        private void StartBtn_Click(object sender, EventArgs e)
        {
            if (modeSelect == null)
            {
                modeSelect = new ModeSelection();
            }
            modeSelect.Show();
            modeSelect.Left = this.Left;
            modeSelect.Top = this.Top;
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (adminScreen == null)
            {
                adminScreen = new AdminSettings();
            }
            adminScreen.Show();
            adminScreen.Left = this.Left;
            adminScreen.Top = this.Top;
            this.Hide();
        }

        private void LanguageBtn_Click(object sender, EventArgs e)
        {
            if(languageScreen == null)
            {
                languageScreen = new LanguageSelect();
            }
            languageScreen.Show();
            languageScreen.Left = this.Left;
            languageScreen.Top = this.Top;
            this.Hide();
        }
    }
}
