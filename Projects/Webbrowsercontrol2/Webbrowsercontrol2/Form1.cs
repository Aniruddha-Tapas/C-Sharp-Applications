using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Webbrowsercontrol2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        WebBrowser wb = new WebBrowser();
        private void button1_Click(object sender, EventArgs e)
        {
            wb.Navigate("https://www.google.co.in/search?q=" + textBox1.Text + "&oq=" + textBox1.Text + "&aqs=chrome..69i57j0l5.1026j0j8&sourceid=chrome&es_sm=93&ie=UTF-8");
            wb.DocumentCompleted += new WebBrowserDocumentCompletedEventHandler(wb_DocumentCompleted);
        }

        void wb_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
           label1.Text =   wb.Document.GetElementById("gb_70").InnerText;
        }
    }
}
