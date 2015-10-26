using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace strings
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
            //Substrings
            string Name = "Aniruddha Tapas";
            string FirstName = Name.Substring(0, 10);
            MessageBox.Show(FirstName);
            string LastName = Name.Substring(10);
            MessageBox.Show(LastName);
             */
            /*
            //IndexOf and Trim
            string Name = "Aniruddha Tapas";
            string FirstName = Name.Substring(0, Name.IndexOf(' '));
            MessageBox.Show(FirstName);
            string LastName = Name.Substring(Name.IndexOf(' ') + 1);
            MessageBox.Show(LastName);

            string name = "        Aniruddha Tapas         ";
            MessageBox.Show(name.Trim()); //name.TrimEnd name.TrimStart
             */
            /*
            //Remove and Replace
            string stmt = "Hello, What a nice day it is!";
            string after = stmt.Remove(0, 7);
            MessageBox.Show(after);
            string replace = stmt.Replace("nice", "wonderful");
            MessageBox.Show(replace);
             */
            /*
            //Split and TocharArray
            string names = "A;B;C;D;E;F";
            string[] nameArray = names.Split(';');
            foreach(string name in nameArray)
                MessageBox.Show(name);
             */
            string _letters = "abcdefghijk";
            char[] letters = _letters.ToCharArray();
            foreach(char l in letters)
                MessageBox.Show(l.ToString());
        }
    }
}
