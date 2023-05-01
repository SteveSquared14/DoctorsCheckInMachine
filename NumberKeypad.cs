﻿using System;
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
    public partial class NumberKeypad : Form
    {
        TextBox tt;
        public NumberKeypad()
        {
            InitializeComponent();
            this.TopMost = true; //make the keyboard appear in front of everything else
        }

        public void setDoBTxtBox(TextBox t)
        {
            tt = t;
        }

        public void setNHSNumberTxtBox(TextBox t)
        {
            tt = t;
        }

        public void setAdminNoTxtBox(TextBox t)
        {
            tt = t;
        }

        private void button_Click(object sender, EventArgs e)
        {
            string ch = ((Button)sender).Text;
            string buttonName = ((Button)sender).Name;

            if (buttonName == "DeleteBtn")
            {
                if (tt.Text.Length > 0)
                {
                    int len = tt.Text.Length;
                    tt.Text = tt.Text.Remove(len - 1);
                }
            }
            else
            {
                tt.Text += ((Button)sender).Text;
            }
        }

        private void CloseBtn_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
