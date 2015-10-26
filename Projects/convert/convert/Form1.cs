using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace convert
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            try
            {
                //int myInt = Convert.ToInt32(textBox1.Text);
                //MessageBox.Show(myInt.ToString());
                char myChar = Convert.ToChar(textBox1.Text);
                MessageBox.Show(myChar.ToString());
                //bool myBool = Convert.ToBoolean(textBox1.Text);
                //MessageBox.Show(myBool.ToString());
            }
            catch { MessageBox.Show("Conversion failed!"); }
            
        }
    }
}
