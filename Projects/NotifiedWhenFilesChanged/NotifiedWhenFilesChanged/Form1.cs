using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace NotifiedWhenFilesChanged
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            FileSystemWatcher fsw = new FileSystemWatcher();
            fsw.Path = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            fsw.NotifyFilter = NotifyFilters.LastWrite | NotifyFilters.FileName;
            fsw.Changed += new FileSystemEventHandler(fsw_Changed);
            fsw.Renamed += new RenamedEventHandler(fsw_Renamed);
            fsw.EnableRaisingEvents = true;
        }

        void fsw_Renamed(object sender, RenamedEventArgs e)
        {
            MessageBox.Show("You have renamed a txt file.");
        }

        void fsw_Changed(object sender, FileSystemEventArgs e)
        {
            MessageBox.Show("You have saved a text file");
        }
    }
}
