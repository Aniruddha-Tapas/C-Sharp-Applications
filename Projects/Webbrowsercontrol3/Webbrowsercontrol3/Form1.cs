using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Webbrowsercontrol3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("UHSearchBox").InnerText = textBox1.Text; //use textbox1 as the search text box of the engine
        }

        private void button2_Click(object sender, EventArgs e)
        {
            webBrowser1.Document.GetElementById("UHSearchWeb").InvokeMember("Click"); // use button2(search) as the search button of the engine
        }
    }
}

