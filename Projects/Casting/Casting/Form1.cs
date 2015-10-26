using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Casting
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //object myObj = "Ani";
            //if(myObj is string)MessageBox.Show((string)myObj);
            Control myControl = button1;
            object myObj = "Hello";
            if (myControl is Button)
            {
                //Button myButton = myControl as Button;
                string myString = myObj as string;
                MessageBox.Show(myString);
            }
        }
    }
}
