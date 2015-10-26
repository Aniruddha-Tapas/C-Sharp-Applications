using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;


namespace WindowsFormsApplication1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            /*
            button1.Text = "Click me";
            button1.Enabled = false;
            
            if (textBox1.Text == "Ani")
            {
                if (checkBox1.Checked)
                {
                    MessageBox.Show("Hello Ani. Just Do It!");
                }
                else
                {
                    MessageBox.Show("Hello Ani");
                }
            }
            else {
                MessageBox.Show("Who d h r u?");
            }
            
            switch (textBox1.Text) { 
                case "Ani" :
                    MessageBox.Show("Hello Ani");
                    break;
                case "Aki":
                    MessageBox.Show("Hello Aki");
                    break;
                default :
                    MessageBox.Show("Who d h r u?");
                    //break;
                    goto case "Ani";

            }
             */
            #region Goto Keyword
            for (; ; )
            {
                goto MyCode;
            }
            MyCode:
            {
                MessageBox.Show("Test");
            }
            #endregion


            /*
            //textBox1.MaxLength = 2;
            
            int a = 3;
            int b = 32;
            int c = 4;
            int d = 4;

            textBox1.Text = (a*d + b / c).ToString();
            MessageBox.Show((a--).ToString());
            MessageBox.Show((++b).ToString());
            
            string name = "Aniruddha Tapas";
            int no = 20;
            bool info = true;
            object myObj1 = "Objects can hold anything like string,nos or bolean values For example : ";
            object myObj2 = 9;
            object myObj3 = false;
            MessageBox.Show("Hi " + name + " aged " + no.ToString() + " which is " + info.ToString() + " and btw " + myObj1.ToString() + myObj2.ToString() + myObj3.ToString());
            
            try
            {
                string[] Names = { "A", "B", "C" };
                MessageBox.Show(Names[4]);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally {
                MessageBox.Show("Your code is done");
            }
            
            string[] Names2 = new string[5];
            Names2[0] = "X";
            Names2[1] = "Y";
            Names2[2] = "Z";
            Names2[3] = "W";
            Names2[4] = "V";
            MessageBox.Show(Names2[3]);
            
            List<string> Names = new List<string>(); 
            Names.Add("A");
            Names.Add("B");
            MessageBox.Show(Names[0]);
            
            for (int i = 0; i < 10; i++)
            {
                if (i == 2) continue; //continue
                MessageBox.Show("Hello " + i.ToString());
            }
            
            string[] Names = { "A", "B", "C" };
            foreach (string s in Names)
            {
                MessageBox.Show(s);
            }
            
            int i = 0;
            while (i < 10) 
            {
                textBox1.Text += i.ToString();
                i++;
            }
            int j = 11;
            do
            {
                textBox1.Text += j.ToString();
                j++;
            }
            while (j < 10);
            
            Message("Hello" , "Title");

            textBox1.Text = MyMethod("Ani");
            */ 


        }
        
            private void button2_Click(object sender, EventArgs e)
            {
                //Message("Hello There", "Title");
            }
        /*
            //Method1
            void Message(string msg, string title)
            {
                MessageBox.Show(msg,title);
            }
            //Method2
            string MyMethod(string name) 
            {
                return name;
            }
        */
    }
}
