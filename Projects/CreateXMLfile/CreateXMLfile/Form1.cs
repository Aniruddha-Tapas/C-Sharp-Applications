using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace CreateXMLfile
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            XmlTextWriter xWriter = new XmlTextWriter("C:\\Users\\ANIRUDDHA\\Desktop\\xDoc1.xml",Encoding.UTF8);
            xWriter.Formatting = Formatting.Indented;
            xWriter.WriteStartElement("People");//People
            xWriter.WriteStartElement("Person");//Person
            xWriter.WriteStartElement("Name"); //<Name>
            xWriter.WriteString(textBox1.Text); //textbox1.Text
            xWriter.WriteEndElement(); //</Name>
            xWriter.WriteStartElement("Age"); //<Age>
            xWriter.WriteString(numericUpDown1.Value.ToString()); //numericUpDown1.Value
            xWriter.WriteEndElement(); //</Age>
            xWriter.WriteStartElement("Email"); //<Email>
            xWriter.WriteString(textBox2.Text); //textbox2.Text
            xWriter.WriteEndElement(); //</Email>
            xWriter.WriteEndElement(); //</Person>
            xWriter.WriteEndElement(); //</People>
            xWriter.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load("C:\\Users\\ANIRUDDHA\\Desktop\\xDoc1.xml");
            XmlNode person = doc.CreateElement("Person");
            XmlNode name= doc.CreateElement("Name");
            name.InnerText = textBox1.Text;
            person.AppendChild(name);
            XmlNode age = doc.CreateElement("Age");
            age.InnerText = numericUpDown1.Value.ToString();
            person.AppendChild(age);
            XmlNode email = doc.CreateElement("Email");
            email.InnerText = textBox2.Text;
            person.AppendChild(email);
            doc.DocumentElement.AppendChild(person);
            doc.Save("C:\\Users\\ANIRUDDHA\\Desktop\\xDoc1.xml");
        }
    }
}
