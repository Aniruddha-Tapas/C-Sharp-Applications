using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace ReadingXML
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
                // Reading xml file from the computer
             
             OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(ofd.FileName);
                MessageBox.Show(xDoc.SelectSingleNode("People/Person/Name").InnerText);
                MessageBox.Show(xDoc.SelectSingleNode("People/Person/Age").InnerText);
                MessageBox.Show(xDoc.SelectSingleNode("People/Person/Email").InnerText);
            }
             */

            /*
               // Reading xml file from the internet
             
            XmlDocument xDoc = new XmlDocument();
            xDoc.Load("..xml url link..");
            MessageBox.Show(xDoc.SelectSingleNode("People/Person/Name").InnerText);
             */

            // Reading xml file with multiple Persons from the computer

            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                XmlDocument xDoc = new XmlDocument();
                xDoc.Load(ofd.FileName);
                foreach (XmlNode node in xDoc.SelectNodes("People/Person"))
                MessageBox.Show(node.SelectSingleNode("Name").InnerText);
                
            }
        }
    }
}
