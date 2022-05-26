using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Net;
using System.Net.Sockets;
using System.Net.WebSockets;
using System.IO;


namespace task1Webserver
{
    public partial class Bai1 : Form
    {
        public Bai1()
        {
            InitializeComponent();
        }

        private void btn_get_Click(object sender, EventArgs e)
        {
            string szURL = txb_url.Text;
            string html = getHTML(szURL);
            rtxb_HTML.Text = html;
        }

        private string getHTML(string szURL)
        {
            WebRequest request = WebRequest.Create(szURL);
            WebResponse response = request.GetResponse();
            Stream dataStream = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream); 
            string responseFromServer = reader.ReadToEnd();
            response.Close();
            return responseFromServer;
        }
    }
}
