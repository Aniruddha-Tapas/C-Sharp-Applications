using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ClipBoardClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            pictureBox1.ImageLocation = "C:\\Users\\ANIRUDDHA\\Desktop\\Barcaaaaaa\\FC Barcelona.jpg";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = Clipboard.GetText();
            pictureBox2.Image = Clipboard.GetImage();
            //Clipboard.GetData(DataFormats.Rtf);
            try
            {
                Clipboard.SetText("ani");
                Clipboard.SetImage(pictureBox1.Image);
            }
            catch { }
            Clipboard.Clear();
        }
    }
}
