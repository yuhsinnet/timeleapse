
/*todo-list
 * V 1.無資料不會自動跳過
 * V 2.自動偵測並創建擷取資料夾
 * 3.將左下角的OSD 移除
 * V 4.解決影像過大問題
 * V 5.使用FFMPEG //ffmpeg -f concat -r 2 -i list.txt -s:v 1920x1080 -c:v libx264 -crf 35 -pix_fmt yuv420p camera7.avi
 * 
 * 
 */









using System;
using System.Globalization;
using System.IO;
using System.Windows.Forms;

namespace TimeLeapse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CultureInfo provider = CultureInfo.InvariantCulture;
        string savepath;
        DateTime setdatetime;
        string GetThisTime;
        private void Form1_Load(object sender, EventArgs e)
        {
            axGVSinglePlayer1.ShowTreeList = true;
            axGVSinglePlayer1.PlayMode = 0;

            axGVSinglePlayer1.Login2(txtIP.Text,
                                     int.Parse(txtPort.Text),
                                     txtUser.Text,
                                     txtPwd.Text);//   'Start login process

            //startDateTime.Value = DateTime.Today.AddMonths(-1);
            //string datestr = $"{DateTime.Today.Year}{DateTime.Today.AddMonths(-1):d2}01000000";

            string staryear = $"{DateTime.Today.AddMonths(-1).Year:d4}";
            string starmonth = $"{DateTime.Today.AddMonths(-1).Month:d2}";

            string datestr = $"{staryear + starmonth}01000000";
            DateTime dateTime = DateTime.ParseExact(datestr, "yyyyMMddHHmmss", null);
            startDateTime.Value = dateTime;


            string stopdatestr = $"{DateTime.Today.Year}{DateTime.Today.Month:d2}01000000";
            stopDateTime.Value = DateTime.ParseExact(stopdatestr, "yyyyMMddHHmmss", null).AddDays(-1); //將時間(時分)歸零
            //stopDateTime.Value = DateTime.Parse("23:59");


            setDateTime.Value = DateTime.Today; //將時間(時分)歸零





        }

        private void SnapShoting(object sender, System.Timers.ElapsedEventArgs e)
        {



            bool SnapOK =
            axGVSinglePlayer1.SnapShot(savepath + "\\image" + GetThisTime + ".jpg");

            WriteList(savepath + "\\list.txt","file image" + GetThisTime + ".jpg");

            SetSanp();
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
            Startwork();
        }

        private void Startwork()
        {
            savepath = Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) +
"\\TimeLeapsecam" + txtCamNo.Text;

            // Determine whether the directory exists.
            if (Directory.Exists(savepath))
            {
                Console.WriteLine("That path exists already.");
                //return;
            }

            // Try to create the directory.
            DirectoryInfo di = Directory.CreateDirectory(savepath);

            startDateTime.Enabled = false;
            stopDateTime.Enabled = false;

            setDateTime.Value = startDateTime.Value;
            setdatetime = setDateTime.Value;
            SetSanp();


            //axGVSinglePlayer1.SnapShot(Environment.GetFolderPath(Environment.SpecialFolder.MyPictures) + "\\image.jpg");
        }

        private void button2_Click(object sender, EventArgs e)
        {

            setDateTime.Value = setDateTime.Value.AddMinutes(20);



        }

        private void axGVSinglePlayer1_SearchEvent(object sender, AxGVSINGLEPLAYERLib._DGVSinglePlayerEvents_SearchEvent e)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            GetThisTime = e.lpNowTime;



            if (e.bOK)
            {
                setDateTime.Value = DateTime.ParseExact(GetThisTime, "yyyyMMddHHmmssfff", provider);

                System.Timers.Timer SnapTime = new System.Timers.Timer(5000); //傳入調閱時間
                SnapTime.Elapsed += SnapShoting;
                SnapTime.AutoReset = false;
                SnapTime.Start();
                
                label5.Text = "Search OK!  " + e.lpNowTime;

            }
            else
            {
                SetSanp();
                label5.Text = "No Data!";
            }




        }

        private void button3_Click(object sender, EventArgs e)
        {
            SetSanp();
        }

        private delegate void addMinutesDelegate(int minut);
        private void addMinut(int miunt)
        {
            setDateTime.Value = setDateTime.Value.AddMinutes(miunt); // 每次呼叫增加 miunt 分鐘
        }

        private delegate void labelTextUpdate(string str);
        private void AddMessage(string sMessage)
        {
            if (this.InvokeRequired)
            {
                labelTextUpdate del = new labelTextUpdate(AddMessage);
                this.Invoke(del, sMessage);
            }
            else
            {
                this.label5.Text += sMessage;
            }
        }

        private delegate void uiup(Control control, string str);
        private void contstr(Control control, string str)
        {
            if (this.InvokeRequired)
            {
                uiup del = new uiup(contstr);
                this.Invoke(del, control, str);
            }
            else
            {
                control.Text = str;
            }
        }


        private void SetSanp()
        {
            int HostType = 0;
            int nDBType = 0; //Default value is 0. Reserved.
            int nCamera = int.Parse(txtCamNo.Text);
            string lpDateTime;
            //setdatetime = setDateTime.Value;

            if (setdatetime.Date.CompareTo(stopDateTime.Value.Date) <= 0) //比較設定時間與目表時間關係
            {

                int comp2 = setdatetime.Hour.CompareTo(8);
                int comp3 = setdatetime.Hour.CompareTo(17);


                bool isWorkingTime = false;


                while (!isWorkingTime)
                {
                    if (comp2 >= 0)
                    {
                        if (comp3 < 0)
                        {
                            isWorkingTime = true;
                        }
                    }
                    else isWorkingTime = false;

                    //addMinutesDelegate minutesDelegate = new addMinutesDelegate(addMinut);
                    //BeginInvoke(minutesDelegate, new object[] { 20 });
                    setdatetime = setdatetime.AddMinutes(20); // 每次呼叫增加20分鐘

                    comp2 = setdatetime.Hour.CompareTo(8);
                    comp3 = setdatetime.Hour.CompareTo(17);

                }

                lpDateTime = setdatetime.ToString("yyyyMMddHHmmss") + "002";

                axGVSinglePlayer1.SearchAndPlay(HostType, nDBType, nCamera, lpDateTime);
            }
            else
            {
                //label5.Text = "complet~";


                int i = int.Parse(txtCamNo.Text);
                i++;

                if (i <= 12)
                {


                    contstr(txtCamNo, i.ToString());
                    //txtCamNo.Text = i.ToString();


                    //timer1.Start();

                    AddMessage("complet~");
                }




            }


        }

        private void axGVSinglePlayer1_Picture(object sender, AxGVSINGLEPLAYERLib._DGVSinglePlayerEvents_PictureEvent e)
        {
            Console.WriteLine("test");
        }


        private void txtCamNo_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(txtCamNo.Text);

            Startwork();
            timer1.Enabled = false;
            Console.WriteLine("Restart new mission");
            Console.WriteLine(txtCamNo.Text);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //Startwork();
            //timer1.Enabled = false;
            //Console.WriteLine("Restart new mission");
            //Console.WriteLine(txtCamNo.Text);

        }
        /// <summary>
        /// 寫入TXT 資料
        /// </summary>
        /// <param name="title">檔名或路徑</param>
        /// <param name="value">寫入內容</param>
        private static void WriteList(string title, string value)
        {
            StreamWriter sw = new StreamWriter(title, true, System.Text.Encoding.ASCII);

            sw.WriteLine(value);
            sw.Close();
        }
    }
}
