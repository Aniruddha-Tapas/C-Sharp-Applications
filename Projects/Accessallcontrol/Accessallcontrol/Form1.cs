using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Accessallcontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //foreach (Control c in this.Controls)
            //    c.Text = "BuTToN";
            accessAll(this.Controls);
        }
        void accessAll(Control.ControlCollection cc)
        {
            foreach (Control c in cc)
            {
                //c.Enabled = false;
                //if (c is Button) c.Enabled = false;
                /*if (c is CheckBox)
                {
                    CheckBox ch = c as CheckBox;
                    ch.Checked = true;
                }*/
                if (c is Button)
                {
                    Button b = c as Button;
                    b.Click += new EventHandler(b_Click);
                }

                if (c.HasChildren)
                    accessAll(c.Controls);
            }
        }

        void b_Click(object sender, EventArgs e)
        {
            MessageBox.Show("U Clicked me!");
        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

    }
}
