using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Fontdialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FontDialog fd = new FontDialog();
            fd.MinSize = 10;
            fd.MaxSize = 40;
            fd.ShowColor = true;
            fd.ShowHelp = true;
            fd.HelpRequest += new EventHandler(fd_HelpRequest);
            if (fd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                textBox1.Font = fd.Font;
                textBox1.ForeColor = fd.Color;

            }
        }

        void fd_HelpRequest(object sender, EventArgs e)
        {
            MessageBox.Show("Choose the font and the color of the text");
        }
    }
}
