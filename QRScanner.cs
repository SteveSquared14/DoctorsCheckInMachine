using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace MedicalCheckInSystem
{
    public partial class QRScanner : Form
    {
        WelcomeScreen homeScreen;
        ModeSelection modeSelectScreen;
        HelpScreen helpScreen;
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice videoCaptureDevice;
        public static string qrCodeInfo = " ";
        ChangeApp changeAppScreen;

        public QRScanner()
        {
            InitializeComponent();
        }

        private void QRScanner_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach (FilterInfo filterInfo in filterInfoCollection)
                cboCamera.Items.Add(filterInfo.Name);
            cboCamera.SelectedIndex = 0;

            videoCaptureDevice = new VideoCaptureDevice(filterInfoCollection[cboCamera.SelectedIndex].MonikerString);
            videoCaptureDevice.NewFrame += FinalFrame_NewFrame;
            videoCaptureDevice.Start();
            timer1.Start();
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

        private void FinalFrame_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox1.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            BarcodeReader Reader = new BarcodeReader();
            Result result = Reader.Decode((Bitmap)pictureBox1.Image);
            if (result != null)
            {
                qrCodeInfo = result.Text;
                string qrCodeText = qrCodeInfo;
                string[] words = qrCodeText.Split(' ');
                string firstName = (string)words.GetValue(1);
                string surname = (string)words.GetValue(2);
                NameSearch.patientName = firstName + " " + surname;
                if(qrCodeInfo.Equals(result.Text))
                {
                    if (changeAppScreen == null)
                    {
                        changeAppScreen = new ChangeApp();
                    }
                    changeAppScreen.Show();
                    changeAppScreen.Left = this.Left;
                    changeAppScreen.Top = this.Top;
                    this.Close();
                }
            }
                       
        
        }

        private void QRScanner_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (videoCaptureDevice.IsRunning == true)
                videoCaptureDevice.Stop();
        }
    }
}
