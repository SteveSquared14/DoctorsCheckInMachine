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
    public partial class CleaningModeScreen : Form
    {
        AdminSettings adminSettings;
        CleaningModeActivated cleaningModeActivated;
        public CleaningModeScreen()
        {
            InitializeComponent();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            if (adminSettings == null)
            {
                adminSettings = new AdminSettings();
            }
            adminSettings.Show();
            adminSettings.Left = this.Left;
            adminSettings.Top = this.Top;
            this.Hide();
        }

        private void CleaningModeBtn_Click(object sender, EventArgs e)
        {
            if (cleaningModeActivated == null)
            {
                cleaningModeActivated = new CleaningModeActivated();
            }
            cleaningModeActivated.Show();
            cleaningModeActivated.Left = this.Left;
            cleaningModeActivated.Top = this.Top;
            this.Hide();
        }
    }
}
