using System;
using System.Threading;
using System.Windows.Forms;

namespace TimeLeapse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void Form1_Load(object sender, EventArgs e)
        {
            axGVSinglePlayer1.ShowTreeList = true;
            axGVSinglePlayer1.PlayMode = 0;

            axGVSinglePlayer1.Login2(txtIP.Text,
                                     int.Parse(txtPort.Text),
                                     txtUser.Text,
                                     txtPwd.Text);//   'Start login process


        }

        private void SnapShoting(object state)
        {

            bool SnapOK =
            axGVSinglePlayer1.SnapShot(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) +
            "\\TimeLeapse\\image" + state.ToString() + ".jpg");




            //throw new NotImplementedException();
        }

        private void axGVSinglePlayer1_LoginOK(object sender, EventArgs e)
        {
            label5.Text = "Login OK!";
        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

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

           setDateTime.Value =  setDateTime.Value.AddMinutes(20);
            


        }

        private void axGVSinglePlayer1_SearchEvent(object sender, AxGVSINGLEPLAYERLib._DGVSinglePlayerEvents_SearchEvent e)
        {

            if (e.bOK)
            {
                string NowTime = e.lpNowTime;

                System.Threading.Timer SnapTime
          = new System.Threading.Timer(SnapShoting, NowTime, 5000, Timeout.Infinite); //傳入調閱時間
                label5.Text = "Search OK!  " + e.lpNowTime;

            }
            else label5.Text = "No Data!";
            


        }


        private void button3_Click(object sender, EventArgs e)
        {
            SetSanp();
        }

        private void SetSanp()
        {
            int HostType = 0;
            int nDBType = 0; //Default value is 0. Reserved.
            int nCamera = 7;
            string lpDateTime = setDateTime.Value.ToString("yyyyMMddHHmmss") + "002";

            axGVSinglePlayer1.Search(HostType, nDBType, nCamera, lpDateTime);
        }
    }
}
