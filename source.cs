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
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;


namespace task1Webserver
{
    public partial class source : Form
    {
        public source instance;
        public source()
        {
            InitializeComponent();
            instance = this;
        }

        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }


        private void btn_view_Click(object sender, EventArgs e)
        {
            string url_source = Bai4.instance.tb1.Text;
            txt_sourceURL.Text = url_source;
            string htmlSource = GetSource(url_source);
            rxtb_source.Text = htmlSource;
        }

        private string GetSource(string url_source)
        {
            WebRequest request1 = WebRequest.Create(url_source);
            WebResponse response1 = request1.GetResponse();
            Stream dataStream = response1.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream);
            string responseFromServer = reader.ReadToEnd();
            response1.Close();
            return responseFromServer;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = txt_sourceURL.Text;
            string fileurl = txt_path.Text;
            WebClient myClient = new WebClient();
            Stream response = myClient.OpenRead(url);
            myClient.DownloadFile(url, fileurl);
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                StreamReader sr = new StreamReader(ofd.FileName);
                rxtb_source.Text = sr.ReadToEnd();
            }
        }
    }
}

   

