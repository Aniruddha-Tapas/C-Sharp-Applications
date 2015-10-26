using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Streamreader
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        /*    OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF |*.pdf | Text|*.txt";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(ofd.FileName); //gets path-name
                MessageBox.Show(ofd.SafeFileName); //gets file-name
            } */

        /*    sbyte myByte = -2;
            ushort myShort = 0;
            UInt16 int16 = 0;
            uint myInt = 0;
            UInt32 myInt32 = myInt;
            ulong myLong = 0;
            UInt64 myInt64 = myLong;

            float myFloat = 15135241;
            MessageBox.Show(myFloat.ToString());

            double d = 0.32525;

            char c = 'i';
            
           */

         /* OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));
                sr.BaseStream.Position = 0x0A; 
                byte[] buffer = new byte[3];
                sr.BaseStream.Read(buffer, 0, 3);
                foreach (byte mybyte in buffer)
                {
                    textBox1.Text += mybyte.ToString("X") + " ";
                    sr.Dispose();
                }
                //textBox1.Text = sr.BaseStream.ReadByte().ToString("X");
                  
                sr.Dispose();
            } 

            */
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                StreamReader sr = new StreamReader(File.OpenRead(ofd.FileName));
                //0
                char c = (char)sr.Peek(); //0
                char c1 = (char)sr.Read(); //1
                char c2 = (char)sr.Read();
                MessageBox.Show(c.ToString() + ";" + c1.ToString() + ";" + c2.ToString());
            } 
        }
    }
}
