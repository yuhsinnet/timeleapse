using System;
using System.Windows.Forms;

namespace TimeLeapse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {




            dateTimePicker1.Value = e.Start;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            axGVSinglePlayer1.ShowTreeList = true;


            axGVSinglePlayer1.Login2(txtIP.Text,
                                     int.Parse(txtPort.Text),
                                     txtUser.Text,
                                     txtPwd.Text);//   'Start login process

        }

        private void axGVSinglePlayer1_LoginOK(object sender, EventArgs e)
        {
            label5.Text = "Login OK!";
        }
       

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            int HostType = 0;
            int nDBType = 0; //Default value is 0. Reserved.
            int nCamera = 2;
            string lpDateTime = dateTimePicker1.Value.ToString("yyyyMMddHHmmss") + "002";

            axGVSinglePlayer1.SearchAndPlay(HostType, nDBType, nCamera, lpDateTime);
        }

        private void axGVSinglePlayer1_LoginEvent(object sender, AxGVSINGLEPLAYERLib._DGVSinglePlayerEvents_LoginEvent e)
        {
            string iStatus = "";
            switch (e.iStatus)
            {

                case 0:
                    iStatus = "Login successful.";
                    break;
                case 1:
                    iStatus = "Failed to connect to the server.";
                    break;
                case 2:
                    iStatus = "Login failed.";
                    break;
                case 3:
                    iStatus = "Exceed the maximum connection of the server.";
                    break;
                case 4:
                    iStatus = "The application is too old.";
                    break;
                case 5:
                    iStatus = "The CODEC of the application is too old.";
                    break;


                default:
                    break;
            }


            label5.Text = iStatus;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            axGVSinglePlayer1.SnapShot(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\image.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            axGVSinglePlayer1.GetBitmap(true, Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\image.bmp");
        }
    }
}
