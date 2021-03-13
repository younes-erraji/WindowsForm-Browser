using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UBrowser
{
    public partial class FormUBrowser : Form
    {
        public FormUBrowser()
        {
            InitializeComponent();
        }
        /*
        private void textBox_URL_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyData.ToString()=="Return, Control")
            {
                textBox_URL.Text = "www." + textBox_URL.Text + ".com";
                webUBrowser.Navigate(textBox_URL.Text);
            }
            if (e.KeyData.ToString() == "Return")
            {
                webUBrowser.Navigate(textBox_URL.Text);
            }
        }
        */
        private void toolStripButton_Back_Click(object sender, EventArgs e)
        {
            webUBrowser.GoBack();
        }

        private void toolStripButton_Forward_Click(object sender, EventArgs e)
        {
            webUBrowser.GoForward();
        }

        private void toolStripButton_Home_Click(object sender, EventArgs e)
        {
            //webUBrowser.Navigate("www.google.com");
            webUBrowser.GoHome();
        }

        private void toolStripButton_Refresh_Click(object sender, EventArgs e)
        {
            webUBrowser.Refresh();
        }

        private void toolStripButton_Go_Click(object sender, EventArgs e)
        {
            webUBrowser.Navigate("https://" + textBox_URL.Text);
        }

        private void toolStripButton_Stop_Click(object sender, EventArgs e)
        {
            webUBrowser.Stop();
        }
        /*
        private void webUBrowser_ProgressChanged(object sender, WebBrowserProgressChangedEventArgs e)
        {
            try
            {
                progressBar_URL.Value = Convert.ToByte(e.CurrentProgress);
                progressBar_URL.Maximum = Convert.ToByte(e.MaximumProgress);
            }
            catch(Exception ex) { }
        }
        */
        private void FormUBrowser_Load(object sender, EventArgs e)
        {

        }
    }
}
