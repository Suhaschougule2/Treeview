using Nancy.Responses;
using System;
using System.Windows.Forms;

namespace Treeview
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        /// 
       // CustomTreeView customTreeView = new CustomTreeView();
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("One");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("One");
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.treeView2 = new System.Windows.Forms.TreeView();
            this.extButton5 = new Treeview.Controls.ExtButton();
            this.extButton4 = new Treeview.Controls.ExtButton();
            this.extButton3 = new Treeview.Controls.ExtButton();
            this.extButton2 = new Treeview.Controls.ExtButton();
            this.extButton1 = new Treeview.Controls.ExtButton();
            this.customTreeView2 = new Treeview.Controls.CustomTreeView2();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "FolderImg.png");
            this.imageList1.Images.SetKeyName(1, "FileImg.png");
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.Color.Sienna;
            this.button6.Location = new System.Drawing.Point(198, 388);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(156, 36);
            this.button6.TabIndex = 1;
            this.button6.Text = "Add Blue";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.button1_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(386, 139);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(156, 36);
            this.button7.TabIndex = 1;
            this.button7.Text = "Add";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(386, 201);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(156, 36);
            this.button2.TabIndex = 2;
            this.button2.Text = "Edit";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(386, 280);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(156, 36);
            this.button3.TabIndex = 3;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(386, 45);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(156, 22);
            this.textBox1.TabIndex = 4;
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(386, 360);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(156, 36);
            this.button4.TabIndex = 5;
            this.button4.Text = "Add New";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(606, 350);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(122, 36);
            this.button5.TabIndex = 6;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Sienna;
            this.button1.Location = new System.Drawing.Point(25, 388);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(156, 36);
            this.button1.TabIndex = 8;
            this.button1.Text = "Add Green";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.buttonn_Click);
            // 
            // button8
            // 
            this.button8.Location = new System.Drawing.Point(386, 122);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(156, 36);
            this.button8.TabIndex = 9;
            this.button8.Text = "Add";
            this.button8.UseVisualStyleBackColor = true;
            this.button8.Click += new System.EventHandler(this.button8_Click);
            // 
            // treeView2
            // 
            this.treeView2.CheckBoxes = true;
            this.treeView2.Location = new System.Drawing.Point(581, 45);
            this.treeView2.Name = "treeView2";
            this.treeView2.Size = new System.Drawing.Size(164, 253);
            this.treeView2.TabIndex = 10;
            this.treeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // extButton5
            // 
            this.extButton5.BackColor = System.Drawing.Color.Crimson;
            this.extButton5.BackgroundColor = System.Drawing.Color.Crimson;
            this.extButton5.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.extButton5.BorderRadius = 20;
            this.extButton5.BorderSize = 4;
            this.extButton5.FlatAppearance.BorderSize = 0;
            this.extButton5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extButton5.ForeColor = System.Drawing.Color.Black;
            this.extButton5.Location = new System.Drawing.Point(386, 517);
            this.extButton5.Name = "extButton5";
            this.extButton5.Size = new System.Drawing.Size(92, 103);
            this.extButton5.TabIndex = 15;
            this.extButton5.Text = "extButton5";
            this.extButton5.textColor = System.Drawing.Color.Black;
            this.extButton5.UseVisualStyleBackColor = false;
            // 
            // extButton4
            // 
            this.extButton4.BackColor = System.Drawing.SystemColors.Control;
            this.extButton4.BackgroundColor = System.Drawing.SystemColors.Control;
            this.extButton4.BorderColor = System.Drawing.Color.Lime;
            this.extButton4.BorderRadius = 13;
            this.extButton4.BorderSize = 5;
            this.extButton4.FlatAppearance.BorderSize = 0;
            this.extButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extButton4.ForeColor = System.Drawing.Color.DarkOrange;
            this.extButton4.Location = new System.Drawing.Point(198, 572);
            this.extButton4.Name = "extButton4";
            this.extButton4.Size = new System.Drawing.Size(156, 69);
            this.extButton4.TabIndex = 14;
            this.extButton4.Text = "extButton4";
            this.extButton4.textColor = System.Drawing.Color.DarkOrange;
            this.extButton4.UseVisualStyleBackColor = false;
            // 
            // extButton3
            // 
            this.extButton3.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.extButton3.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.extButton3.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.extButton3.BorderRadius = 20;
            this.extButton3.BorderSize = 2;
            this.extButton3.FlatAppearance.BorderSize = 0;
            this.extButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extButton3.ForeColor = System.Drawing.Color.White;
            this.extButton3.Location = new System.Drawing.Point(42, 581);
            this.extButton3.Name = "extButton3";
            this.extButton3.Size = new System.Drawing.Size(98, 39);
            this.extButton3.TabIndex = 13;
            this.extButton3.Text = "extButton3";
            this.extButton3.textColor = System.Drawing.Color.White;
            this.extButton3.UseVisualStyleBackColor = false;
            // 
            // extButton2
            // 
            this.extButton2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.extButton2.BackgroundColor = System.Drawing.Color.MediumSlateBlue;
            this.extButton2.BorderColor = System.Drawing.Color.PaleVioletRed;
            this.extButton2.BorderRadius = 20;
            this.extButton2.BorderSize = 0;
            this.extButton2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.extButton2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.extButton2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Fuchsia;
            this.extButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extButton2.ForeColor = System.Drawing.Color.White;
            this.extButton2.Location = new System.Drawing.Point(188, 494);
            this.extButton2.Name = "extButton2";
            this.extButton2.Size = new System.Drawing.Size(166, 46);
            this.extButton2.TabIndex = 12;
            this.extButton2.Text = "extButton2";
            this.extButton2.textColor = System.Drawing.Color.White;
            this.extButton2.UseVisualStyleBackColor = false;
            // 
            // extButton1
            // 
            this.extButton1.BackColor = System.Drawing.SystemColors.Control;
            this.extButton1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.extButton1.BorderColor = System.Drawing.Color.DodgerBlue;
            this.extButton1.BorderRadius = 46;
            this.extButton1.BorderSize = 1;
            this.extButton1.FlatAppearance.BorderSize = 0;
            this.extButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.extButton1.ForeColor = System.Drawing.Color.DodgerBlue;
            this.extButton1.Location = new System.Drawing.Point(25, 494);
            this.extButton1.Name = "extButton1";
            this.extButton1.Size = new System.Drawing.Size(145, 46);
            this.extButton1.TabIndex = 11;
            this.extButton1.Text = "extButton1";
            this.extButton1.textColor = System.Drawing.Color.DodgerBlue;
            this.extButton1.UseVisualStyleBackColor = false;
            // 
            // customTreeView2
            // 
            this.customTreeView2.AllowDrop = true;
            this.customTreeView2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.customTreeView2.CheckBoxes = true;
            this.customTreeView2.ImageIndex = 0;
            this.customTreeView2.ImageList = this.imageList1;
            this.customTreeView2.ItemHeight = 20;
            this.customTreeView2.Location = new System.Drawing.Point(79, 27);
            this.customTreeView2.Name = "customTreeView2";
            treeNode1.ForeColor = System.Drawing.SystemColors.GrayText;
            treeNode1.Name = "";
            treeNode1.Text = "One";
            treeNode2.ForeColor = System.Drawing.SystemColors.GrayText;
            treeNode2.Name = "";
            treeNode2.Text = "One";
            this.customTreeView2.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.customTreeView2.SelectedImageIndex = 0;
            this.customTreeView2.Size = new System.Drawing.Size(229, 339);
            this.customTreeView2.TabIndex = 7;
            this.customTreeView2.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView2_AfterSelect);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(854, 681);
            this.Controls.Add(this.extButton5);
            this.Controls.Add(this.extButton4);
            this.Controls.Add(this.extButton3);
            this.Controls.Add(this.extButton2);
            this.Controls.Add(this.extButton1);
            this.Controls.Add(this.treeView2);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.customTreeView2);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button6);
            this.Name = "Form1";
            this.Text = "TreeView";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }



        #endregion
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        public System.Windows.Forms.TextBox textBox1; 
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.ImageList imageList1;
        private Button button1;
        private Button button8;
        private TreeView treeView2;
        private Controls.ExtButton extButton1;
        private Controls.ExtButton extButton2;
        private Controls.ExtButton extButton3;
        private Controls.ExtButton extButton4;
        private Controls.ExtButton extButton5;
        private Controls.CustomTreeView2 customTreeView2;
    }
}

