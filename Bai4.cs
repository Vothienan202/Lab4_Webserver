using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using HtmlAgilityPack;

namespace task1Webserver
{
    public partial class Bai4 : Form
    {
        public static Bai4 instance;
        public TextBox tb1;
        public Bai4()
        {
            InitializeComponent();
            instance = this;
            tb1 = txt_URL;
        }

        private void btn_HOME_Click(object sender, EventArgs e)
        {
            WebBrowser.GoHome();
        }

        private void btn_BACK_Click(object sender, EventArgs e)
        {
            WebBrowser.GoBack();
        }

        private void btn_FORWARD_Click(object sender, EventArgs e)
        {
            WebBrowser.GoForward();
        }

        private void btn_REFRESH_Click(object sender, EventArgs e)
        {
            WebBrowser.Refresh();
        }

        private void btn_SEARCH_Click(object sender, EventArgs e)
        {
            string WebPage = txt_URL.Text.Trim();
            WebBrowser.Navigate(WebPage);
        }

        private void btn_SOURCE_Click(object sender, EventArgs e)
        {
            source source = new source();
            source.Show();
        }

        private void Bai4_Load(object sender, EventArgs e)
        {

        }
    }
}
