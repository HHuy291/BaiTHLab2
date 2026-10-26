namespace BaiTHLab2
{
    partial class Form4
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.btnWrite = new System.Windows.Forms.Button();
            this.btnRead = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnNext = new System.Windows.Forms.Button();
            this.lblPage = new System.Windows.Forms.Label();
            this.rtbList = new System.Windows.Forms.RichTextBox();

            // Các ô nhập liệu bên trái
            this.txtInName = new System.Windows.Forms.TextBox();
            this.txtInID = new System.Windows.Forms.TextBox();
            this.txtInPhone = new System.Windows.Forms.TextBox();
            this.txtInC1 = new System.Windows.Forms.TextBox();
            this.txtInC2 = new System.Windows.Forms.TextBox();
            this.txtInC3 = new System.Windows.Forms.TextBox();

            // Các ô hiển thị bên phải
            this.txtOutName = new System.Windows.Forms.TextBox();
            this.txtOutID = new System.Windows.Forms.TextBox();
            this.txtOutPhone = new System.Windows.Forms.TextBox();
            this.txtOutC1 = new System.Windows.Forms.TextBox();
            this.txtOutC2 = new System.Windows.Forms.TextBox();
            this.txtOutC3 = new System.Windows.Forms.TextBox();
            this.txtOutAvg = new System.Windows.Forms.TextBox();

            // Các nhãn (Labels)
            this.lblLName = new System.Windows.Forms.Label(); this.lblLID = new System.Windows.Forms.Label();
            this.lblLPhone = new System.Windows.Forms.Label(); this.lblLC1 = new System.Windows.Forms.Label();
            this.lblLC2 = new System.Windows.Forms.Label(); this.lblLC3 = new System.Windows.Forms.Label();
            this.lblRName = new System.Windows.Forms.Label(); this.lblRID = new System.Windows.Forms.Label();
            this.lblRPhone = new System.Windows.Forms.Label(); this.lblRC1 = new System.Windows.Forms.Label();
            this.lblRC2 = new System.Windows.Forms.Label(); this.lblRC3 = new System.Windows.Forms.Label();
            this.lblRAvg = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Nút bấm chính
            this.btnWrite.Location = new System.Drawing.Point(30, 20); this.btnWrite.Size = new System.Drawing.Size(200, 35); this.btnWrite.Text = "Write to a File"; this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
            this.btnRead.Location = new System.Drawing.Point(620, 20); this.btnRead.Size = new System.Drawing.Size(220, 35); this.btnRead.Text = "Button to read a File"; this.btnRead.Click += new System.EventHandler(this.btnRead_Click);

            // Cột bên trái (Nhập liệu)
            int leftInputX = 30; int leftLabelX = 240;
            this.txtInName.Location = new System.Drawing.Point(leftInputX, 75); this.txtInName.Size = new System.Drawing.Size(195, 27);
            this.lblLName.Text = "Name"; this.lblLName.Location = new System.Drawing.Point(leftLabelX, 78);

            this.txtInID.Location = new System.Drawing.Point(leftInputX, 115); this.txtInID.Size = new System.Drawing.Size(195, 27);
            this.lblLID.Text = "ID"; this.lblLID.Location = new System.Drawing.Point(leftLabelX, 118);

            this.txtInPhone.Location = new System.Drawing.Point(leftInputX, 155); this.txtInPhone.Size = new System.Drawing.Size(195, 27);
            this.lblLPhone.Text = "Phone"; this.lblLPhone.Location = new System.Drawing.Point(leftLabelX, 158);

            this.txtInC1.Location = new System.Drawing.Point(leftInputX, 195); this.txtInC1.Size = new System.Drawing.Size(195, 27);
            this.lblLC1.Text = "Course 1"; this.lblLC1.Location = new System.Drawing.Point(leftLabelX, 198);

            this.txtInC2.Location = new System.Drawing.Point(leftInputX, 235); this.txtInC2.Size = new System.Drawing.Size(195, 27);
            this.lblLC2.Text = "Course 2"; this.lblLC2.Location = new System.Drawing.Point(leftLabelX, 238);

            this.txtInC3.Location = new System.Drawing.Point(leftInputX, 275); this.txtInC3.Size = new System.Drawing.Size(195, 27);
            this.lblLC3.Text = "Course 3"; this.lblLC3.Location = new System.Drawing.Point(leftLabelX, 278);

            this.btnAdd.Location = new System.Drawing.Point(80, 325); this.btnAdd.Size = new System.Drawing.Size(100, 35); this.btnAdd.Text = "Add"; this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);

            // Khung RichTextBox hiển thị danh sách ở giữa
            this.rtbList.Location = new System.Drawing.Point(310, 75); this.rtbList.Size = new System.Drawing.Size(280, 227);

            // Cột bên phải (Hiển thị chi tiết đọc từ file)
            int rightInputX = 620; int rightLabelX = 830;
            this.txtOutName.Location = new System.Drawing.Point(rightInputX, 75); this.txtOutName.Size = new System.Drawing.Size(195, 27); this.txtOutName.ReadOnly = true;
            this.lblRName.Text = "Name"; this.lblRName.Location = new System.Drawing.Point(rightLabelX, 78);

            this.txtOutID.Location = new System.Drawing.Point(rightInputX, 115); this.txtOutID.Size = new System.Drawing.Size(195, 27);
            this.txtOutID.ReadOnly = true;
            this.lblRID.Text = "ID"; this.lblRID.Location = new System.Drawing.Point(rightLabelX, 118);

            this.txtOutPhone.Location = new System.Drawing.Point(rightInputX, 155); this.txtOutPhone.Size = new System.Drawing.Size(195, 27);
            this.txtOutPhone.ReadOnly = true;
            this.lblRPhone.Text = "Phone"; this.lblRPhone.Location = new System.Drawing.Point(rightLabelX, 158);

            this.txtOutC1.Location = new System.Drawing.Point(rightInputX, 195); this.txtOutC1.Size = new System.Drawing.Size(195, 27);
            this.txtOutC1.ReadOnly = true;
            this.lblRC1.Text = "Course 1"; this.lblRC1.Location = new System.Drawing.Point(rightLabelX, 198);

            this.txtOutC2.Location = new System.Drawing.Point(rightInputX, 235); this.txtOutC2.Size = new System.Drawing.Size(195, 27);
            this.txtOutC2.ReadOnly = true;
            this.lblRC2.Text = "Course 2"; this.lblRC2.Location = new System.Drawing.Point(rightLabelX, 238);

            this.txtOutC3.Location = new System.Drawing.Point(rightInputX, 275); this.txtOutC3.Size = new System.Drawing.Size(195, 27);
            this.txtOutC3.ReadOnly = true;
            this.lblRC3.Text = "Course 3"; this.lblRC3.Location = new System.Drawing.Point(rightLabelX, 278);

            this.txtOutAvg.Location = new System.Drawing.Point(rightInputX, 315); this.txtOutAvg.Size = new System.Drawing.Size(195, 27);
            this.txtOutAvg.ReadOnly = true;
            this.lblRAvg.Text = "Average"; this.lblRAvg.Location = new System.Drawing.Point(rightLabelX, 318);

            // Thanh điều hướng trang bên dưới góc phải
            this.btnBack.Location = new System.Drawing.Point(620, 360); this.btnBack.Size = new System.Drawing.Size(75, 30); this.btnBack.Text = "Back"; this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            this.lblPage.Location = new System.Drawing.Point(715, 365); this.lblPage.Size = new System.Drawing.Size(30, 20); this.lblPage.Text = "1"; this.lblPage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnNext.Location = new System.Drawing.Point(760, 360); this.btnNext.Size = new System.Drawing.Size(75, 30); this.btnNext.Text = "Next"; this.btnNext.Click += new System.EventHandler(this.btnNext_Click);

            // Cấu hình Form4 tổng thể
            this.ClientSize = new System.Drawing.Size(920, 420);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                btnWrite, btnRead, btnAdd, btnBack, btnNext, lblPage, rtbList,
                txtInName, txtInID, txtInPhone, txtInC1, txtInC2, txtInC3,
                txtOutName, txtOutID, txtOutPhone, txtOutC1, txtOutC2, txtOutC3, txtOutAvg,
                lblLName, lblLID, lblLPhone, lblLC1, lblLC2, lblLC3,
                lblRName, lblRID, lblRPhone, lblRC1, lblRC2, lblRC3, lblRAvg
            });
            this.Name = "Form4";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bài 04 - Quản lý sinh viên";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion

        private System.Windows.Forms.Button btnWrite;
        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnNext;
        private System.Windows.Forms.Label lblPage;
        private System.Windows.Forms.RichTextBox rtbList;
        private System.Windows.Forms.TextBox txtInName, txtInID, txtInPhone, txtInC1, txtInC2, txtInC3;
        private System.Windows.Forms.TextBox txtOutName, txtOutID, txtOutPhone, txtOutC1, txtOutC2, txtOutC3, txtOutAvg;
        private System.Windows.Forms.Label lblLName, lblLID, lblLPhone, lblLC1, lblLC2, lblLC3;
        private System.Windows.Forms.Label lblRName, lblRID, lblRPhone, lblRC1, lblRC2, lblRC3, lblRAvg;
    }
}
