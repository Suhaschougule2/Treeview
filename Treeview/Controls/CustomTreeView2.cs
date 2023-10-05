using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Treeview.Controls
{
    public class CustomTreeView2 : TreeView
    {
        public CustomTreeView2()
        {
            InitializeComponent();
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // CustomTreeView2
            // 
            this.BackColor = Color.Lavender;
            var node = this.Nodes.Add("One");
            node.ForeColor = SystemColors.GrayText;
          //  this.ResumeLayout(false);

        }

        public void AddGreenNode(string text)
        {
            var node = this.Nodes.Add(text);
            node.ForeColor = System.Drawing.Color.Green;
            node.BackColor = System.Drawing.Color.Yellow;
        }

        public void AddBlueNode(string text)
        {
            var node = this.Nodes.Add(text);
            node.ForeColor = System.Drawing.Color.Blue;
            node.BackColor = Color.Black;
        }

        //Only upper for Customization





        //Adding Nodes into CustomTreeView
        public void AddNode(string text, CustomTreeView2 treeview)
        {
            TreeNode node = new TreeNode(text);
            try
            {
                treeview.SelectedNode.Nodes.Add(node);
                node.ImageIndex = 1;

            }
            catch
            {
                treeview.Nodes.Add(node);
                node.ImageIndex = 0;
            }
        }

        //Edit
        public void EditNode(string text, CustomTreeView2 treeview)
        {
            treeview.SelectedNode.Text = text;
        }


        //Delete
        public void RemoveNode(string text, CustomTreeView2 treeview)
        {
           // treeview.SelectedNode.Remove();
            RemovedCheckedNodes(treeview.Nodes);
        }


        //Delete using Checkbox
        private void RemovedCheckedNodes(TreeNodeCollection nodes)
        {
            List<TreeNode> checkedNodes = new List<TreeNode>();

            foreach (TreeNode tnode in nodes)
            {
                if (tnode.Checked)
                {
                    checkedNodes.Add(tnode);
                }
                else
                {
                    RemovedCheckedNodes(tnode.Nodes);
                }
            }
            foreach (TreeNode tnode in checkedNodes)
            {
                nodes.Remove(tnode);
            }
        }

        //Add new Root
        public  void AddNewRoot(string text, CustomTreeView2 treeview)
        {
            treeview.Nodes.Add(text);
        }

        //Display Node
        public void Save(string text, CustomTreeView2 treeview)
        {
            
        }

    }
}
