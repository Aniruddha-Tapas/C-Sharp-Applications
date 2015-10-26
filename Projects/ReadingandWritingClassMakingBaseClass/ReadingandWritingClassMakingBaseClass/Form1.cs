using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AniIO;

namespace ReadingandWritingClassMakingBaseClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /* 
            //Using Reader Class
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Reader r = new Reader(ofd.FileName);
                MessageBox.Show(r.ReadInt32().ToString("X"));
            }
             */
            //Using Writer Class
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Writer w = new Writer(ofd.FileName);
                //w.ChangeByteOrder(BaseIO.ByteOrder.LittleEndian); //Change the byteorder to little endian (reverse)
                w.Position = 0x20;
                //w.WriteUnicodeString("Ani");
                w.WriteUInt32(0xFFFEFDFC);
                w.Close();
            }
        }
    }
}
