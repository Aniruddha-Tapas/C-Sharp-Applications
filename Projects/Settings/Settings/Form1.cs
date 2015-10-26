using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Settings
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textBox1.Text = Settings.Properties.Settings.Default.Name;
            textBox2.Text = Settings.Properties.Settings.Default.Age.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Settings.Properties.Settings.Default.Name = textBox1.Text;
            Settings.Properties.Settings.Default.Age = Convert.ToInt32(textBox2.Text);
            Settings.Properties.Settings.Default.ButtonA = button1;
            Settings.Properties.Settings.Default.Save();
        }
    }
}
