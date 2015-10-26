using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Bitwiseoperators
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //short myShort = ~3; //inverse of 3
            //short myShort = 3 & 5; //011 & 101 = ...001 hence 1
            //short myShort = 3 | 5; //011 | 101 = ...111 hence 11
            //short myShort = 3 ^ 5; //011 ^ 101 = 110 hence 110
            //short myShort = 5>>1; //Shifts bits 101>>1 = 10
            short myShort = 5 << 1; //Shifts bits 101<<1 = 1010
            MessageBox.Show(Convert.ToString(myShort,2));
        }
    }
}
