using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Colordialog
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //ColorDialog

            /*
                ColorDialog cd = new ColorDialog();
                //cd.AllowFullOpen = false; // restrict custom colors
                cd.FullOpen = true;
                cd.ShowHelp = true;
                cd.HelpRequest += new EventHandler(cd_HelpRequest);
                if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                {
                    button1.BackColor = cd.Color;
                }
            }

            void cd_HelpRequest(object sender, EventArgs e)
            {
                MessageBox.Show("Choose a color for the background of your button!");
            }
            */
            //ColorStruct

            /*
            ColorDialog cd = new ColorDialog();
            if (cd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                Color c = cd.Color;
                //KnownColor. ..
                if (c.IsNamedColor) MessageBox.Show(c.Name);

            } */
            //Color c1 = Color.FromKnownColor(KnownColor.ButtonFace);
            //button1.BackColor = c1;
            //MessageBox.Show(c1.ToArgb().ToString("X"));
            Color c = Color.Black;
            int i = c.ToArgb();
            Color c2 = Color.FromArgb(i);
            button1.BackColor = c2;
        }
    }
}
