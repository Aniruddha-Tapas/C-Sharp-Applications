using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Ionic.Zip;

namespace ZippingFilesandFolders
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            //Make a zipped file
            //if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            //{
            //    ZipFile zf = new ZipFile("C:\\Users\\ANIRUDDHA\\Desktop\\MyZipfile.zip");
            //    zf.AddDirectoryByName("Ani"); 
            //    zf.AddFile(ofd.FileName,"Ani");
            //    zf.Save();
            //}
            //Make a zipped folder
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                ZipFile zf = new ZipFile("C:\\Users\\ANIRUDDHA\\Desktop\\MyZipfile.zip");
                zf.AddDirectory(fbd.SelectedPath, "");
                zf.Save();
            }
        }
    }
}
