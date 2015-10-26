using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;

namespace IEnumerableandYieldReturn
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (int i in GetNumbers(0, 10))
            {
                if (i == 2) break;
                MessageBox.Show(i.ToString());
            }
        }

        IEnumerable GetNumbers(int min, int max)
        {
            for (; min <= max; min++)
                yield return min; //allows use of everything inside for loop
        }
    }
}
