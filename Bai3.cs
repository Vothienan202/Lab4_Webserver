using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.IO;
using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.Windows.Forms;

namespace task1Webserver
{
    public partial class Bai3 : Form
    {
        public Bai3()
        {
            InitializeComponent();
        }

        private void btn_download_Click(object sender, EventArgs e)
        {
            string url = txtURL.Text;
            string fileurl = txt_path.Text;
            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(url);
            myClient.DownloadFile(url, fileurl);
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                rtbx_HTML.Text = sr.ReadToEnd();    
            }
        }
    }
}
