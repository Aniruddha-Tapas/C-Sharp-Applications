using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Overloadingoperators
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
            //+
            Item item1 = new Item();
            item1.Price = 4;
            Item item2 = new Item();
            item2.Price = 16;
            Item item3 = item1 + item2;
            MessageBox.Show(item3.Price.ToString());
             */
            /*
            //== , !=
            Item item1 = new Item();
            item1.Price = 4;
            Item item2 = new Item();
            item2.Price = 16;
            if(item1==item2)
                MessageBox.Show("Equal");
            else
                MessageBox.Show("Not Equal");
             */
            /*
            //< , >
            Item i1 = new Item();
            i1.Price = 4;
            Item i2 = new Item();
            i2.Price = 16;
            if (i1 < i2)
                MessageBox.Show(i1.Price.ToString() + " is less than" + i2.Price.ToString());
            else
                MessageBox.Show(i1.Price.ToString() + " is greater than" + i2.Price.ToString());
             */
            Item i = new Item();
            i.Price = 4;
            //i++;
            i--;
            MessageBox.Show(i.Price.ToString());
        }
    }
    class Item
    {
        public int Price
        {
            get;
            set;
        }
        //+
        public static Item operator +(Item i1, Item i2)
        {
            Item i3 = new Item();
            i3.Price = i1.Price + i2.Price;
            return i3;
        }
        //=
        public static bool operator == (Item i1, Item i2)
        {
            return (i1.Price == i2.Price ) ? true : false;
        }
        public static bool operator != (Item i1, Item i2)
        {
            return (i1.Price != i2.Price) ? true : false;
        }
        //<
        public static bool operator <(Item i1, Item i2)
        {
            return (i1.Price < i2.Price) ? true : false;
        }
        //>
        public static bool operator >(Item i1, Item i2)
        {
            return (i1.Price > i2.Price) ? true : false;
        }
        /*
        //<=
        public static bool operator <(Item i1, Item i2)
        {
            return (i1.Price <= i2.Price) ? true : false;
        }
        //>=
        public static bool operator <(Item i1, Item i2)
        {
            return (i1.Price >= i2.Price) ? true : false;
        }
         */
        public static Item operator ++(Item item)
        {
            Item i = new Item();
            i.Price = item.Price + 1;
            return i;
        }
        public static Item operator --(Item item)
        {
            Item i = new Item();
            i.Price = item.Price - 1;
            return i;
        }


        
    }
}
