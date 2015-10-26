using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace math
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //label1.Text = Math.Abs(-4).ToString();
            //label1.Text = Math.PI.ToString();
            //label1.Text = Math.Pow(5,2).ToString();
            //label1.Text = Math.Round(3.145).ToString();
            label1.Text = Math.Round(3.74114252,2).ToString();

        }
    }
}
