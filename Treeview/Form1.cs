using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Xml;
using Treeview.Controls;

namespace Treeview
{
    public partial class Form1 : Form
    {
        private string xmlFilePath = "Tree.xml";
        private CustomTreeView2 custtree;
        private ExtButton extbutton;
       // TreeView treeView1 = new TreeView();
        public Form1()
        {
            InitializeComponent();

            custtree= new CustomTreeView2();
            custtree.Show();

            extbutton = new ExtButton();
            extbutton.Show();

            treeView2.ImageList = imageList1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }


        //Xml
        private void SerializeTreeViewToXml(TreeNode node, XmlWriter writer)
        {
            writer.WriteStartElement("Node");
            writer.WriteAttributeString("Text", node.Text);

            foreach (TreeNode childeNode in node.Nodes)
            {
                SerializeTreeViewToXml(childeNode, writer);
            }
            writer.WriteEndElement();
        }

        int i = 1;

        //Add Green 
        private void buttonn_Click(object sender, EventArgs e)
        {
            customTreeView2.AddGreenNode($"{i}");

        }
        //Add Blue Nodes
        private void button1_Click(object sender, EventArgs e)
        {
            customTreeView2.AddBlueNode($"{i++}");
                 
        }

        //Add
        private void button8_Click(object sender, EventArgs e)
        {
            string newNode = textBox1.Text;
            custtree.AddNode(newNode, customTreeView2);
            /*TreeNode node = new TreeNode(textBox1.Text);
            try
            {
                treeView2.SelectedNode.Nodes.Add(node);
                node.ImageIndex = 1;
            }
            catch (Exception ex)
            {
                treeView2.Nodes.Add(node);
                node.ImageIndex = 0;
            }*/
        }

        //Edit
        private void button2_Click(object sender, EventArgs e)
        {
            //treeView2.SelectedNode.Text = textBox1.Text;
            string newNode = textBox1.Text;
            custtree.EditNode(newNode, customTreeView2);
        }


        //Delete
        private void button3_Click(object sender, EventArgs e)
        {
            //treeView2.SelectedNode.Remove();
            // RemovedCheckedNodes(treeView2.Nodes);
            string newNode = textBox1.Text;
            custtree.RemoveNode(newNode, customTreeView2);
        }


        //Delete Nodes using Checkbox
       /* private void RemovedCheckedNodes(TreeNodeCollection nodes)
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
*/
       

        //New RootNode
        private void button4_Click(object sender, EventArgs e)
        {
            //  TreeNode node = new TreeNode(textBox1.Text);
            //  treeView2.Nodes.Add(node);
            string newNode = textBox1.Text;
            custtree.AddNewRoot(newNode, customTreeView2);
        }



        //Display Select Node
        private void treeView2_AfterSelect(object sender, TreeViewEventArgs e)
        {
            textBox1.Text = customTreeView2.SelectedNode.Text;
            //  string newNode = textBox1.Text;
            //  custtree.DisplayNode(newNode, customTreeView2);
        }



        //Save
        private void button5_Click(object sender, EventArgs e)
        {
           
            using (SaveFileDialog saveFileDialog = new SaveFileDialog())
            {
                saveFileDialog.Filter = "XML Files|*.xml";
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //string filename = saveFileDialog.FileName;
                    using (XmlWriter writer = XmlWriter.Create(saveFileDialog.FileName))
                    {
                        writer.WriteStartDocument();
                        writer.WriteStartElement("TreeviewData");

                        foreach (TreeNode rootNode in treeView2.Nodes)
                        {
                            SerializeTreeViewToXml(rootNode, writer);
                        }
                        writer.WriteEndElement();
                        writer.WriteEndDocument();
                    }
                }
            }
        }
    }
}
