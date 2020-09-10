using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        string url = "-1";
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            string s = "Https://youtube.com";
            comboBox1.Text = s;
            Uri myURL = new Uri(s);
            webBrowser1.Url = myURL;
        }
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            {
                url = comboBox1.Text;
                if (url.Equals("-1") == false)

                {
                    if (url.StartsWith("httpa://"))

                    {
                        Uri myURL = new Uri(url);
                        webBrowser1.Url = myURL;

                    }
                    else
                    {
                        if (url.StartsWith("www."))
                        {
                            url = "httpa://+url";

                            Uri myURL = new Uri(url);
                            webBrowser1.Url = myURL;

                        }
                        else
                        {
                            url = "https://www." + url;
                            Uri myURL = new Uri(url);
                            webBrowser1.Url = myURL;

                        }
                    }

                    comboBox1.Text = url;
                }
            }
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            webBrowser1.GoForward();  //GoForward//
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            webBrowser1.GoBack();     //GoBack///
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {
            webBrowser1.Stop();       //Stop//
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            webBrowser1.Refresh();       //Refresh//
        }

    }
}
