#define Ani
#undef Ani
#define Aki
#undef Aki

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace PeprocessorDirectives
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
#if Ani
            MessageBox.Show("Ani is defined");
#elif Aki
            MessageBox.Show("Aki is defined");
#else 
            MessageBox.Show("Nothing is defined");
#endif 

#error Ani is defined
#warning Ani is defined
        }

    }
}
