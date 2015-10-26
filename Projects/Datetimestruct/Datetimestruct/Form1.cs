using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Datetimestruct
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DateTime dt = new DateTime(1996, 1, 20, 13,32,54);
            MessageBox.Show(dt.ToString());
            MessageBox.Show(DateTime.IsLeapYear(2012).ToString());
            MessageBox.Show(DateTime.DaysInMonth(2011,7).ToString());
            MessageBox.Show(DateTime.Now.ToFileTime().ToString("X"));
            DateTime dt2 = DateTime.FromFileTime(141241);
            MessageBox.Show(dt2.ToString());

        }
    }
}
