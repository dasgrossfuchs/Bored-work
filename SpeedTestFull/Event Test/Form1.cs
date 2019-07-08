using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Event_Test
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            

            const string tempfile = "tempfile.tmp";
            System.Net.WebClient webClient = new System.Net.WebClient();

           
            label1.Text ="Descagando....";
            System.Diagnostics.Stopwatch sw = System.Diagnostics.Stopwatch.StartNew();
            webClient.DownloadFile("http://dl.google.com/googletalk/googletalk-setup.exe", tempfile);
            sw.Stop();

            FileInfo fileInfo = new FileInfo(tempfile);
            long speed = fileInfo.Length / sw.Elapsed.Milliseconds*1000;

            //Console.WriteLine("Download duration: {0}", sw.Elapsed);
            //Console.WriteLine("File size: {0}", fileInfo.Length.ToString("N0"));
            //Console.WriteLine("Speed: {0} bps ", speed.ToString("N0"));
            string finb = speed.ToString("N0")+" bps";
            string fink= (speed/1024).ToString("N0") + " Kbps";
            string finm = (speed / 1024/1024).ToString("N0") + " Mbps";
            string fing = (speed / 1024/1024/1024).ToString("N0") + " Gbps";
            label1.Text = finb;
            label2.Text = fink;
            label3.Text = finm;
            label4.Text = fing;
            label5.Text = fileInfo.Length.ToString("N0") + " bits descargados";
            fileInfo.Delete();
            label2.Show();
            label3.Show();
            label4.Show();
            label5.Show();
            //Console.WriteLine("Press any key to continue...");
            //Console.ReadLine();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            label1.Text = "Iniciando...";
            label2.Hide();
            label3.Hide();
            label4.Hide();
            label5.Hide();
        }
    }
}
