using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace makingconversionoperator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Item i = (Item)3;//Explicit
                //MessageBox.Show(i.Price.ToString());
            Item item = 3; //Implicit
                MessageBox.Show(item.Price.ToString());
        }
    }

    class Item
    {
        public int Price
        {
            get;
            set;
        }

        //public static explicit operator Item(int itemPrice)
        //{
        //    Item i = new Item();
        //    i.Price = itemPrice;
        //    return i;
        //}

        public static implicit operator Item(int itemPrice)
        {
            Item i = new Item();
            i.Price = itemPrice;
            return i;
        }
    }
}
