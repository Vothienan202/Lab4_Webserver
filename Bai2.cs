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
    public partial class Bai2 : Form
    {
        public Bai2()
        {
            InitializeComponent();
        }

        private void btn_POST_Click(object sender, EventArgs e)
        {
            string targetURL = "http://www.contoso.com/PostAccepter.aspx";
            string html = postHTML(targetURL);
            rtbx_HTML.Text = html;
        }

        private string postHTML (string targetURL)
        {
            WebRequest request = WebRequest.Create(targetURL);
            request.Method = "POST";
            string postData = txt_content.Text;
            byte[] byteArray = Encoding.UTF8.GetBytes(postData);
            request.ContentType = "application/x-www-form-urlencoded";
            request.ContentLength = byteArray.Length;
            Stream dataStream = request.GetRequestStream();
            dataStream.Write(byteArray, 0, byteArray.Length);
            dataStream.Close();

            WebResponse response = request.GetResponse();
            Stream dataStream1 = response.GetResponseStream();
            StreamReader reader = new StreamReader(dataStream1);
            string responseFromServer = reader.ReadToEnd();
 
            return responseFromServer;
            response.Close();         
        }
    }
}
