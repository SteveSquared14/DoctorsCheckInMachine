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
    public partial class ModeSelection : Form
    {
        QRScanner qrScanner;
        NHSSearch nhsSearch;
        DOBSearch dobSearch;
        NameSearch nameSearch;
        WelcomeScreen homeScreen;
        HelpScreen helpScreen;
        public ModeSelection()
        {
            InitializeComponent();
        }

        private void NameBtn_Click(object sender, EventArgs e)
        {
            if (nameSearch == null)
            {
                nameSearch = new NameSearch();
            }
            nameSearch.Show();
            nameSearch.Left = this.Left;
            nameSearch.Top = this.Top;
            this.Hide();
        }

        private void DoBBtn_Click(object sender, EventArgs e)
        {
            if (dobSearch == null)
            {
                dobSearch = new DOBSearch();
            }
            dobSearch.Show();
            dobSearch.Left = this.Left;
            dobSearch.Top = this.Top;
            this.Hide();
        }

        private void NHSBtn_Click(object sender, EventArgs e)
        {
            if (nhsSearch == null)
            {
                nhsSearch = new NHSSearch();
            }
            nhsSearch.Show();
            nhsSearch.Left = this.Left;
            nhsSearch.Top = this.Top;
            this.Hide();
        }

        private void QRBtn_Click(object sender, EventArgs e)
        {
            if (qrScanner == null)
            {
                qrScanner= new QRScanner();
            }
            qrScanner.Show();
            qrScanner.Left = this.Left;
            qrScanner.Top = this.Top;
            this.Hide();
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
    }
}
