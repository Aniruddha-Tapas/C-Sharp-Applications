using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Streamwriter
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        string path;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                button2.Enabled = true;
                path = ofd.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter(File.Create(path));
            sw.WriteLine(textBox1.Text);
            sw.WriteLine("This is a second Line");
            //sw.Write(textBox1.Text);
            
            /*
            StreamWriter sw = new StreamWriter(File.Create(path));
            sw.BaseStream.Position = 0x0A;
            byte[] buffer = { 0x08, 0x09, 0x0B};
            sw.BaseStream.Write(buffer, 0 , 3);
            sw.Dispose();
            */
        }
    }
}
