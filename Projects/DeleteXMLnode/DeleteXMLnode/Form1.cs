using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace DeleteXMLnode
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlDocument xdoc = new XmlDocument();
            xdoc.Load("C:\\Users\\ANIRUDDHA\\Desktop\\xDoc1.xml");
            foreach (XmlNode xNode in xdoc.SelectNodes("People/Person"))
                if (xNode.SelectSingleNode("Name").InnerText == textBox1.Text)
                    //xNode.RemoveAll(); 
                    xNode.ParentNode.RemoveChild(xNode);
            xdoc.Save("C:\\Users\\ANIRUDDHA\\Desktop\\xDoc1.xml");

        }
    }
}
