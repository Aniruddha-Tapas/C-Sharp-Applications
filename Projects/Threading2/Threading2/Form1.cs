using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace Threading2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Thread t;
        string myString = "";
        private void button1_Click(object sender, EventArgs e)
        {
            t = new Thread(Write);
            object[] objA = { "Ani",500 };
            t.Start(objA);
            while (t.IsAlive) ; 
            textBox1.Text = myString; //When t is dead
        }
        void Write(object array)
        {
            object[] o = array as object[];
            for (int i = 0; i < Convert.ToUInt32(o[1]); i++)
            {
                //Thread.Sleep(10);
                myString += o[0].ToString() + i.ToString() + "\r\n";
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            t.Abort();
        }
    }
}

