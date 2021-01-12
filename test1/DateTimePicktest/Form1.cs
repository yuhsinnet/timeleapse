using System;
using System.Windows.Forms;

namespace DateTimePicktest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            setdateTimePicker.Value = startDateTimePicker.Value; //設定起始時間

            timer1.Enabled = true;


        }
        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Enabled = false; //計時器暫停
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int comp = setdateTimePicker.Value.CompareTo(stopDateTimePicker.Value);

            textBox1.AppendText(string.Format("comp:{0}\r\n", comp));


            if (comp < 0) //比較設定時間與目表時間關係
            {
                
                setdateTimePicker.Value = setdateTimePicker.Value.AddMinutes(20); // 每次呼叫增加20分鐘

            }
            else
            {

                timer1.Enabled = false; //計時器暫停


            }


        }

        private void Form1_Load(object sender, EventArgs e)
        {


            startDateTimePicker.Value = DateTime.Today.AddDays(-30);
            stopDateTimePicker.Value = DateTime.Today; //將時間(時分)歸零

            setdateTimePicker.Value = DateTime.Today; //將時間(時分)歸零
        }
    }
}
