using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace DFPPClass
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {   
        
        //* Directory Files 
            
            /*
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string[] files = Directory.GetFiles(fbd.SelectedPath);
                foreach (string s in files)
                    MessageBox.Show(s);
            }
             */
            /*
            string[] drives = Directory.GetLogicalDrives(); 
            foreach (string s in drives)
                MessageBox.Show(s);  //Gives drive names C:,D:..
             */
            /*    
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(Directory.GetCreationTime(fbd.SelectedPath).ToString()); //gives time of creation
                MessageBox.Show(Directory.GetLastWriteTime(fbd.SelectedPath).ToString()); //gives time of last editing of file
                MessageBox.Show(Directory.GetParent(fbd.SelectedPath).ToString()); //gives parent folder 
            }
             */
            /*
            FolderBrowserDialog fbd = new FolderBrowserDialog();
            if (fbd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Directory.CreateDirectory(fbd.SelectedPath + "\\Ani"); //creates folder named Ani 
                //Directory.Move(fbd.SelectedPath, "C:\\Users\\ANIRUDDHA\\Desktop\\Ani\\MoveAni"); //moves folder named MoveAni into Ani 
                Directory.Delete(fbd.SelectedPath);   
            }
             */

        //* File Class

            /*
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //MessageBox.Show(File.Exists(ofd.FileName).ToString());  //check whether the file exists 
                //File.Delete(ofd.FileName);  //deletes the file 
                //File.Copy(ofd.FileName,"C:\\Users\\ANIRUDDHA\\Desktop\\Ani\\MoveAni\\textdoc.txt"); Copy the selected file in the location and name it textdoc.txt
                File.Move(ofd.FileName, "C:\\Users\\ANIRUDDHA\\Desktop\\Ani\\MoveAni\\textdoc2.txt");
            }
            */

        //* Path Class

            /*
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                MessageBox.Show(Path.GetDirectoryName(ofd.FileName).ToString());  //gives the path 
                MessageBox.Show(Path.GetExtension(ofd.FileName).ToString());  //gives the extention of the file opened in the path 
                MessageBox.Show(Path.GetFileName(ofd.FileName).ToString());  //gives the name of the file opened in the path 
                MessageBox.Show(Path.GetFileNameWithoutExtension(ofd.FileName).ToString());  //gives the name of the file opened in the path with no extention
                MessageBox.Show(Path.GetFullPath(ofd.FileName).ToString());  //gives the full path same as ofd.FileName
                MessageBox.Show(Path.HasExtension(ofd.FileName).ToString());  //checks presence of extention
             }
             */

        //* Process Class (using System.Diagnostics instead of using System.IO;)

            /*
            OpenFileDialog ofd = new OpenFileDialog();
            if (ofd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //Process.Start(ofd.FileName); //Opens an Application in the selected path
            }
            
            //Process.Start("notepad.exe"); //Opens notepad, no path required
            //Process.Start("cmd"); //Opens notepad, no path required

            //MessageBox.Show(Process.GetCurrentProcess().ProcessName); //Get process name
            Process.GetCurrentProcess().Kill(); //Kills the current process
            
            foreach (Process p in Process.GetProcesses())
                //MessageBox.Show(p.ProcessName); Get names of all processes
                MessageBox.Show(p.Responding.ToString());
            
        //task manager
            foreach (Process p in Process.GetProcesses()) //Process.GetProcessesByName searches processes by name..
                if(!p.Responding)p.Kill();
             * 
             */ 

        //* Null Coalesce Operator

            /* string myString = "Ani"; //null
            if (myString == null)
                MessageBox.Show("String is null");
            else MessageBox.Show(myString); */

            string myString = null;
            MessageBox.Show(myString ?? "String is null"); // prints out myString iff String is not null

        }
    }
}

