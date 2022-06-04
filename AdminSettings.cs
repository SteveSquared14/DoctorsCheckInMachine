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
    public partial class AdminSettings : Form
    {
        WelcomeScreen welcomeScreen;
        NumberKeypad numberKeypad;
        CleaningModeScreen cleaningModeScreen;
        public AdminSettings()
        {
            InitializeComponent();
            EnterBtn.Hide();
            ErrorLabel1.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
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

        private void textBox_GotFocus(Object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            ErrorLabel1.Hide();

            if (numberKeypad == null)
            {
                numberKeypad = new NumberKeypad();
                numberKeypad.FormClosed += delegate
                {
                    numberKeypad = null;
                    this.ActiveControl = label1;
                };
            }
            numberKeypad.setAdminNoTxtBox(tb);
            numberKeypad.Show();

            numberKeypad.Left = this.Left; ;
            numberKeypad.Top = this.Top + 539;
        }

        private void AdminNoTxtBox_TextChanged(object sender, EventArgs e)
        {
            if(AdminNoTxtBox.Text.Length < 6)
            {
                EnterBtn.Hide();
            }
            else if(AdminNoTxtBox.Text.Length > 6)
            {
                EnterBtn.Hide();
            }
            else
            {
                EnterBtn.Show();
            }
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if(AdminNoTxtBox.Text == "631247")
            {
                if (cleaningModeScreen == null)
                {
                    cleaningModeScreen = new CleaningModeScreen();
                }
                cleaningModeScreen.Show();
                cleaningModeScreen.Left = this.Left;
                cleaningModeScreen.Top = this.Top;
                this.Hide();
            }
            else
            {
                AdminNoTxtBox.Clear();
                ErrorLabel1.Show();
            }
        }

        private void AdminSettings_Load(object sender, EventArgs e)
        {
            this.ActiveControl = label1;
        }
    }
}
