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
    public partial class NameSearch : Form
    {
        WelcomeScreen homeScreen;
        ModeSelection modeSelectScreen;
        HelpScreen helpScreen;
        Keyboard keyboard;
        public ChangeApp changeAppScreen;
        public static string patientName = " ";

        public NameSearch()
        {
            InitializeComponent();
            RequiredLabel1.Hide();
            RequiredLabel2.Hide();
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
            
            TextBox tb = (TextBox)sender;

            if(keyboard == null)
            {
                keyboard = new Keyboard();
                keyboard.FormClosed += delegate
                {
                    keyboard = null;
                    this.ActiveControl = label1;
                };
            }
            keyboard.setFirstNameTxtBox(tb);
            keyboard.Show();

            keyboard.Left = this.Left;
            keyboard.Top = this.Top + 544;
        }

        private void EnterBtn_Click(object sender, EventArgs e)
        {
            if(FirstNameTxtBox.Text.Length > 0 && SurnameTxtBox.Text.Length > 0)
            {
                patientName = FirstNameTxtBox.Text + " " + SurnameTxtBox.Text;

                if (changeAppScreen == null)
                {
                    changeAppScreen = new ChangeApp();
                }
                changeAppScreen.Show();
                this.Hide();
                
            }
            else
            {
                RequiredLabel1.Show();
                RequiredLabel2.Show();
            }
           
        }

        private void FirstNameTxtBox_Click(object sender, EventArgs e)
        {
            FirstNameTxtBox.BackColor = Color.LemonChiffon;
        }

        private void SurnameTxtBox_Click(object sender, EventArgs e)
        {
            SurnameTxtBox.BackColor = Color.LemonChiffon;
        }
    }
}
