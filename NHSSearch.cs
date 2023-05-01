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
    public partial class NHSSearch : Form
    {
        WelcomeScreen homeScreen;
        ModeSelection modeSelectScreen;
        HelpScreen helpScreen;
        NumberKeypad numberKeypad;
        ChangeApp changeAppScreen;
        public static string patientNHSNumber = " ";
        public NHSSearch()
        {
            InitializeComponent();
            ErrorLabel1.Hide();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            if (homeScreen == null)
            {
                homeScreen = new WelcomeScreen();
            }
            homeScreen.Show();
            homeScreen.Left = this.Left;
            homeScreen.Top = this.Left;
            this.Hide();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (modeSelectScreen == null)
            {
                modeSelectScreen = new ModeSelection();
            }
            modeSelectScreen.Show();
            modeSelectScreen.Left = this.Left;
            modeSelectScreen.Top = this.Top;
            this.Hide();
        }

        private void HelpBtn_Click(object sender, EventArgs e)
        {
            if (helpScreen == null)
            {
                helpScreen = new HelpScreen();
            }
            helpScreen.Show();
            helpScreen.Left = this.Left;
            helpScreen.Top = this.Top;
        }

        private void textBox_GotFocus(Object sender, EventArgs e)
        {
            NHSNumberTxtBox.BackColor = Color.LemonChiffon;
            TextBox tb = (TextBox)sender;

            if (numberKeypad == null)
            {
                numberKeypad = new NumberKeypad();
                numberKeypad.FormClosed += delegate
                {
                    numberKeypad = null;
                    this.ActiveControl = label1;
                };
            }
            numberKeypad.setNHSNumberTxtBox(tb);
            numberKeypad.Show();

            numberKeypad.Left = this.Left;
            numberKeypad.Top = this.Top + 539;
        }

        private void EnterBtn_Click_1(object sender, EventArgs e)
        {
            if (NHSNumberTxtBox.Text.Length == 10)
            {
                if (changeAppScreen == null)
                {
                    changeAppScreen = new ChangeApp();
                }
                patientNHSNumber = NHSNumberTxtBox.Text;
                changeAppScreen.Show();
                this.Hide();
            }
            else if (NHSNumberTxtBox.Text.Length == 0)
            {
                ErrorLabel1.Text = "Required*";
                ErrorLabel1.Show();
            }
            else if (NHSNumberTxtBox.Text.Length != 10)
            {
                ErrorLabel1.Text = "Incorrect entry";
                ErrorLabel1.Show();
            }
        }
    
    }
}
