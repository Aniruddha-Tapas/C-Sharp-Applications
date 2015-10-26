using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RefandOut
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int Age = 3; //in case of ref, variables must be assigned
            string name; //in case of out, variables need not be assigned
            Modify(ref Age, out name);
            MessageBox.Show(Age.ToString() + " " + name);

        }
        void Modify(ref int age,out string Name)
        {
            Name = "Ani"; //however in the method, variables must be assigned.
            age += 5;
            //MessageBox.Show(age.ToString());
        }
    }
}
