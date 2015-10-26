using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ICloneableClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string myName = "Ani";
            //string clone = (string)myName.Clone(); //return exac copy of myName
            //MessageBox.Show(clone);
            MyClass mc = new MyClass();
            mc.Name = "Ani";
            MyClass cloneClass = (MyClass)mc.Clone();
            MessageBox.Show(cloneClass.Name);
        }
    }

    class MyClass : ICloneable
    {
        public string Name
        {
            get;
            set;
        }

        public object Clone()
        {
            return this;
        }
    }
}
