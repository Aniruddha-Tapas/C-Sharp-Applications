using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace binaryrw
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
                button3.Enabled = true;
                path = ofd.FileName;
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            BinaryReader br = new BinaryReader(File.OpenRead(path));
            br.BaseStream.Position = 0x00;
            //textBox1.Text = br.ReadChar().ToString();
            foreach(char mychar in br.ReadChars(5)) textBox1.Text += mychar; 
             
            /*
            br.BaseStream.Position = 0x1E;
            textBox1.Text = br.ReadInt16().ToString("X");
            br.Dispose();
            */
            /*
            br.BaseStream.Position = 0x1E;
            byte[] buffer = br.ReadBytes(2);
            Array.Reverse(buffer);
            textBox1.Text = BitConverter.ToInt16(buffer, 0).ToString("X");
            //buffer = BitConverter.GetBytes(4312);
            br.Dispose();
            */ 
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BinaryWriter bw = new BinaryWriter(File.OpenWrite(path));
            //bw.Write(textBox1.Text);
            short myshort = 1;
            byte[] buffer = BitConverter.GetBytes(myshort);
            Array.Reverse(buffer);
            bw.Dispose();
        }
    }
}
