using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using MyNamespace;

namespace WindowsFormsApplication2Classes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            //mc.name;
            /* MyClass.ShowMessage("Hello");
               MyClass.ShowMessage("20"); */

            /* MyClass mc = new MyClass("Ani");
            //mc.Name = "";
            MessageBox.Show(mc.Name);
            
            try
            {
                MyClass.CheckString("");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            
            MySecondClass msc = new MySecondClass();
            //msc.MessageBoxSpecial();   
            msc.ShowMessage("Hey there");
            msc.MyVoid();
             
            //Indexers
            MyClass mc = new MyClass();
            mc[1] = "b";
            MessageBox.Show(mc[1]);
        

            //Structs
            Client client1 = new Client();
            client1.Name = "A";
            client1.age = 19;

            Client client2 = new Client();
            client2.Name = "B";
            client2.age = 20;
            

            //Partials
            MyClass mc = new MyClass();
            mc.ShowMessage("Ani");
            
            //Abstracts
            //Delegates
            MyClass mc = new MyClass();
            mc.ShowThoseMessages();
          

            //Events

            MyClass mc = new MyClass();
            mc.OnPropertyChanged += new EventHandler(mc_OnPropertyChanged);
            mc.Name = "Ani";
         }

        void mc_OnPropertyChanged(object sender, EventArgs e)
        {
            MessageBox.Show("The property has changed");
        }
        */
    }
}
