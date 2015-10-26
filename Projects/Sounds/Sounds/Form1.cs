using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Media;

namespace Sounds
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                SoundPlayer s = new SoundPlayer(ofd.FileName);
                //s.Play();
                //s.PlayLooping(); //play on a loop
                //s.PlaySync(); //freezes the application while playing
            }
            SystemSounds.Asterisk.Play(); // SystemSounds. ..
        }
    }
}
