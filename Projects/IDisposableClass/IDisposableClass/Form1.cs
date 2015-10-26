using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace IDisposableClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            /*
            //MyClass mc = new MyClass();
            System.IO.BinaryReader br = new System.IO.BinaryReader(System.IO.File.OpenRead(""));
            br.Dispose(); //Call the dector
             */

            using (MyClass mc = new MyClass())
            {
                //After this method is completed and form is closed , dector wont be called and the object would be disposed into the GC.
            }
        }
    }

    class MyClass : IDisposable
    {
        Image i;
        public MyClass()
        {
            //MessageBox.Show("I am the ctor");
            i = Image.FromFile("C:\\Users\\ANIRUDDHA\\Desktop\\logo.png");
        }
        /*
        ~MyClass()
        {
            MessageBox.Show("I am the deconstructor"); //Called when form1 is closed
        }
        */
        
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this); //Dector wont be called
        }

        protected virtual void Dispose(bool b)
        { 
            if(b)
            {
                i.Dispose();
            }
        }

        ~MyClass()
        {
            MessageBox.Show("I am the deconstructor"); //Called when form1 is closed
        }
    }
}
