using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Timercontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Start();     
        }

        int i = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            //timer1.Stop();
            //MessageBox.Show("Hello");
            i++;
            textBox1.Text += i.ToString();
        }
    }
}
