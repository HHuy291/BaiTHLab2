namespace BaiTHLab2
{
    partial class Form3
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnDocVaTinh = new System.Windows.Forms.Button();
            this.rtbKetQua = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // btnDocVaTinh
            // 
            this.btnDocVaTinh.Location = new System.Drawing.Point(30, 20);
            this.btnDocVaTinh.Size = new System.Drawing.Size(440, 40);
            this.btnDocVaTinh.Text = "Đọc file input3.txt, Tính toán & Ghi xuống output3.txt";
            this.btnDocVaTinh.Click += new System.EventHandler(this.btnDocVaTinh_Click);
            // 
            // rtbKetQua
            // 
            this.rtbKetQua.Location = new System.Drawing.Point(30, 80);
            this.rtbKetQua.Size = new System.Drawing.Size(440, 220);
            // 
            // Form3
            // 
            this.ClientSize = new System.Drawing.Size(500, 330);
            this.Controls.Add(this.rtbKetQua);
            this.Controls.Add(this.btnDocVaTinh);
            this.Name = "Form3";
            this.Text = "Bài 03 - Tính toán biểu thức";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnDocVaTinh;
        private System.Windows.Forms.RichTextBox rtbKetQua;
    }
}
