using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace EditingXMLfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string path;
        XmlDocument xDoc;
        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "XML|*.xml";
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                path = ofd.FileName;
                xDoc = new XmlDocument();
                xDoc.Load(path);
                textBox1.Text = xDoc.SelectSingleNode("People/Person/Name").InnerText;
                numericUpDown1.Value = Convert.ToInt32(xDoc.SelectSingleNode("People/Person/Age").InnerText);
                textBox2.Text = xDoc.SelectSingleNode("People/Person/Email").InnerText;

                //foreach (XmlNode node in xDoc.SelectNodes("People/Person"))
                  //  MessageBox.Show(node.SelectSingleNode("Name").InnerText);

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            xDoc.SelectSingleNode("People/Person/Name").InnerText = textBox1.Text;
            xDoc.SelectSingleNode("People/Person/Age").InnerText = numericUpDown1.Value.ToString();
            xDoc.SelectSingleNode("People/Person/Email").InnerText = textBox2.Text;
            xDoc.Save(path);
        }
    }
}
