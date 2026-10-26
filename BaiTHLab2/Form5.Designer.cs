namespace BaiTHLab2
{
    partial class Form5
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnXuLy = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.rtbThongKe = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnXuLy
            // 
            this.btnXuLy.Location = new System.Drawing.Point(30, 20);
            this.btnXuLy.Size = new System.Drawing.Size(420, 40);
            this.btnXuLy.Text = "Đọc input5.txt & Tính toán Thống kê vào output5.txt";
            this.btnXuLy.Click += new System.EventHandler(this.btnXuLy_Click);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(30, 80);
            this.progressBar1.Size = new System.Drawing.Size(420, 23);
            // 
            // rtbThongKe
            // 
            this.rtbThongKe.Location = new System.Drawing.Point(30, 120);
            this.rtbThongKe.Size = new System.Drawing.Size(420, 200);
            // 
            // Form5
            // 
            this.ClientSize = new System.Drawing.Size(480, 350);
            this.Controls.Add(this.rtbThongKe);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.btnXuLy);
            this.Name = "Form5";
            this.Text = "Bài 05 - Quản lý phòng vé";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnXuLy;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.RichTextBox rtbThongKe;
    }
}
