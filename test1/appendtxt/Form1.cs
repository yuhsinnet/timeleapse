using System;
using System.IO;
using System.Windows.Forms;

namespace appendtxt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string value = "file " + "image" + DateTime.Now.ToString("yyyyMMddHHmmssffff");
            WriteList("cam11.txt" ,value);

        }

        /// <summary>
        /// 寫入TXT 資料
        /// </summary>
        /// <param name="title">檔名或路徑</param>
        /// <param name="value">寫入內容</param>
        private static void WriteList(string title,string value)
        {
            StreamWriter sw = new StreamWriter(title, true, System.Text.Encoding.ASCII);

            sw.WriteLine(value);
            sw.Close();
        }
    }
}
