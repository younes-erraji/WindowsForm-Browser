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
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }
        void TitledTab()
        {
            for (int x = 0; x < tcPage.TabPages.Count - 1; x++)
            {
                Form f = (Form)tcPage.TabPages[x].Controls[0];
                WebBrowser w = (WebBrowser)f.Controls[0];
                tcPage.TabPages[x].Text = w.DocumentTitle;
            }
            tcPage.TabPages[tcPage.TabPages.Count - 1].Text = "+";
        }
        private void CallForm(int tabN) {
            FormUBrowser f = new FormUBrowser();
            f.MdiParent = this;
            tcPage.TabPages[tabN].Controls.Add(f);
            f.Show();
        }
        private void Main_Load(object sender, EventArgs e)
        {
            CallForm(0);
        }

        private void tcPage_Click(object sender, EventArgs e)
        {
            if (tcPage.SelectedIndex == tcPage.TabPages.Count-1) {
                tcPage.TabPages.Add("");
                CallForm(tcPage.TabPages.Count - 2);
                TitledTab();
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            TitledTab();
        }
    }
}
