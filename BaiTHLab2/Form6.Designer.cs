namespace BaiTHLab2
{
    partial class Form6
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnRandom = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = new System.Windows.Forms.ColumnHeader();
            this.columnHeader2 = new System.Windows.Forms.ColumnHeader();
            this.SuspendLayout();
            // 
            // btnRandom
            // 
            this.btnRandom.Location = new System.Drawing.Point(20, 20);
            this.btnRandom.Size = new System.Drawing.Size(440, 40);
            this.btnRandom.Text = "Hôm nay ăn gì? (Chọn ngẫu nhiên)";
            this.btnRandom.Click += new System.EventHandler(this.btnRandom_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] { this.columnHeader1, this.columnHeader2 });
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(20, 80);
            this.listView1.Size = new System.Drawing.Size(440, 200);
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Tên Món Ăn"; this.columnHeader1.Width = 220;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Người Đóng Góp"; this.columnHeader2.Width = 200;
            // 
            // Form6
            // 
            this.ClientSize = new System.Drawing.Size(480, 300);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnRandom);
            this.Name = "Form6";
            this.Text = "Bài 06 - Hôm nay ăn gì";
            this.Load += new System.EventHandler(this.Form6_Load);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnRandom;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}
