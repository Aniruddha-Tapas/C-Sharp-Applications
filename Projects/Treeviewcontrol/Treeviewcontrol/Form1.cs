using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Treeviewcontrol
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            treeView1.Nodes.Add("People");
            treeView1.Nodes.Add("Animals");
            treeView1.Nodes[0].Nodes.Add("A"); //index is 0 for People
            treeView1.Nodes[0].Nodes.Add("B");
            treeView1.Nodes[0].Nodes.Add("C");
            treeView1.Nodes[1].Nodes.Add("x"); //index is 1 for Animals
            treeView1.Nodes[1].Nodes.Add("y");
            treeView1.Nodes[1].Nodes[0].Nodes.Add("1");
            treeView1.Nodes[1].Nodes[0].Nodes.Add("2");

        }

        private void button2_Click(object sender, EventArgs e)
        {
            //treeView1.SelectedNode.Remove(); //remove selected node
            //treeView1.Nodes.Clear(); //Clear all
            removeChecked(treeView1.Nodes);
        }

        List<TreeNode> tnList = new List<TreeNode>();

        void removeChecked(TreeNodeCollection tnc)
        {
            foreach (TreeNode tn in tnc)
                if (tn.Checked)
                    tnList.Add(tn);
                else if (tn.Nodes.Count != 0)
                    removeChecked(tn.Nodes);
            foreach (TreeNode tn in tnList)
                treeView1.Nodes.Remove(tn);

        }

        private void button3_Click(object sender, EventArgs e)
        {
            TreeNode tn1 = new TreeNode();
            tn1.Text = "Person 1";
            tn1.ImageIndex = 0;
            tn1.SelectedImageIndex = 0;
            treeView1.Nodes.Add(tn1);
            
            TreeNode tn2 = new TreeNode();
            tn2.Text = "Person 2";
            tn2.ImageIndex = 1;
            tn2.SelectedImageIndex = 1;
            treeView1.Nodes.Add(tn2);

            
        }
    }
}
