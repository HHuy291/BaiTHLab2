namespace BaiTHLab2
{
    partial class Form7
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.listBoxFiles = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(20, 20);
            this.treeView1.Size = new System.Drawing.Size(300, 360);
            this.treeView1.NodeMouseDoubleClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.treeView1_NodeMouseDoubleClick);
            // 
            // listBoxFiles
            // 
            this.listBoxFiles.Location = new System.Drawing.Point(340, 20);
            this.listBoxFiles.Size = new System.Drawing.Size(320, 355);
            // 
            // Form7
            // 
            this.ClientSize = new System.Drawing.Size(680, 400);
            this.Controls.Add(this.listBoxFiles);
            this.Controls.Add(this.treeView1);
            this.Name = "Form7";
            this.Text = "Bài 07 - Duyệt thư mục cây máy tính";
            this.Load += new System.EventHandler(this.Form7_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.ListBox listBoxFiles;
    }
}
