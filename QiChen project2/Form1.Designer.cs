﻿namespace QiChen_project2
{
    partial class EmployeeRecordsForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listView1 = new System.Windows.Forms.ListView();
            this.statusBar1 = new System.Windows.Forms.StatusBar();
            this.statusBarPanel1 = new System.Windows.Forms.StatusBarPanel();
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).BeginInit();
            this.SuspendLayout();
            // 
            // treeView1
            // 
<<<<<<< HEAD
            this.treeView1.Location = new System.Drawing.Point(0, 0);
            this.treeView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.treeView1.Name = "treeView1";
            this.treeView1.Size = new System.Drawing.Size(358, 561);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
=======
            this.treeView1.Location = new System.Drawing.Point(12, 12);
            this.treeView1.Name = "treeView1";
            this.treeView1.ShowLines = false;
            this.treeView1.Size = new System.Drawing.Size(240, 352);
            this.treeView1.TabIndex = 0;
>>>>>>> 210ada9b4d35b05369defcecf333f0d203d71945
            // 
            // listView1
            // 
            this.listView1.Activation = System.Windows.Forms.ItemActivation.TwoClick;
            this.listView1.HideSelection = false;
<<<<<<< HEAD
            this.listView1.Location = new System.Drawing.Point(369, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(637, 561);
=======
            this.listView1.Location = new System.Drawing.Point(258, 12);
            this.listView1.MultiSelect = false;
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(435, 352);
>>>>>>> 210ada9b4d35b05369defcecf333f0d203d71945
            this.listView1.TabIndex = 1;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // statusBar1
            // 
<<<<<<< HEAD
            this.statusBar1.Location = new System.Drawing.Point(0, 561);
            this.statusBar1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.ShowPanels = true;
            this.statusBar1.Size = new System.Drawing.Size(1065, 35);
            this.statusBar1.TabIndex = 2;
            this.statusBar1.Text = "statusBar1";
=======
            this.statusBar1.Location = new System.Drawing.Point(0, 364);
            this.statusBar1.Name = "statusBar1";
            this.statusBar1.Panels.AddRange(new System.Windows.Forms.StatusBarPanel[] {
            this.statusBarPanel1});
            this.statusBar1.Size = new System.Drawing.Size(693, 105);
            this.statusBar1.TabIndex = 2;
            this.statusBar1.Text = "Click the employee code to view details";
>>>>>>> 210ada9b4d35b05369defcecf333f0d203d71945
            // 
            // statusBarPanel1
            // 
            this.statusBarPanel1.Name = "statusBarPanel1";
            this.statusBarPanel1.Text = "Click the employee code to view details";
            this.statusBarPanel1.Width = 240;
            // 
            // EmployeeRecordsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1099, 578);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeRecordsForm";
            this.Text = "Employee Records Monitoring System ";
            this.Load += new System.EventHandler(this.EmployeeRecordsForm_Load);
=======
            this.ClientSize = new System.Drawing.Size(702, 337);
            this.Controls.Add(this.statusBar1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.treeView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EmployeeRecordsForm";
            this.Text = "Employee Records Monitoring System";
>>>>>>> 210ada9b4d35b05369defcecf333f0d203d71945
            ((System.ComponentModel.ISupportInitialize)(this.statusBarPanel1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.StatusBar statusBar1;
        private System.Windows.Forms.StatusBarPanel statusBarPanel1;
    }
<<<<<<< HEAD
}
=======
}

>>>>>>> 210ada9b4d35b05369defcecf333f0d203d71945
