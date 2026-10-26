namespace BaiTHLab2
{
    partial class Form2
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.btnRead = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.txtSize = new System.Windows.Forms.TextBox();
            this.txtURL = new System.Windows.Forms.TextBox();
            this.txtLineCount = new System.Windows.Forms.TextBox();
            this.txtWordCount = new System.Windows.Forms.TextBox();
            this.txtCharCount = new System.Windows.Forms.TextBox();
            this.rtbDisplay = new System.Windows.Forms.RichTextBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Labels & TextBoxes Layout
            // 
            this.lbl1.Text = "File name"; this.lbl1.Location = new System.Drawing.Point(20, 70);
            this.txtFileName.Location = new System.Drawing.Point(120, 67); this.txtFileName.Size = new System.Drawing.Size(200, 23);

            this.lbl2.Text = "Size"; this.lbl2.Location = new System.Drawing.Point(20, 110);
            this.txtSize.Location = new System.Drawing.Point(120, 107); this.txtSize.Size = new System.Drawing.Size(200, 23);

            this.lbl3.Text = "URL"; this.lbl3.Location = new System.Drawing.Point(20, 150);
            this.txtURL.Location = new System.Drawing.Point(120, 147); this.txtURL.Size = new System.Drawing.Size(200, 23);

            this.lbl4.Text = "Line count"; this.lbl4.Location = new System.Drawing.Point(20, 190);
            this.txtLineCount.Location = new System.Drawing.Point(120, 187); this.txtLineCount.Size = new System.Drawing.Size(200, 23);

            this.lbl5.Text = "Words count"; this.lbl5.Location = new System.Drawing.Point(20, 230);
            this.txtWordCount.Location = new System.Drawing.Point(120, 227); this.txtWordCount.Size = new System.Drawing.Size(200, 23);

            this.lbl6.Text = "Char count"; this.lbl6.Location = new System.Drawing.Point(20, 270);
            this.txtCharCount.Location = new System.Drawing.Point(120, 267); this.txtCharCount.Size = new System.Drawing.Size(200, 23);
            // 
            // Buttons
            // 
            this.btnRead.Location = new System.Drawing.Point(20, 20); this.btnRead.Size = new System.Drawing.Size(300, 35);
            this.btnRead.Text = "Read from File";
            this.btnRead.Click += new System.EventHandler(this.btnRead_Click);

            this.btnExit.Location = new System.Drawing.Point(20, 310); this.btnExit.Size = new System.Drawing.Size(300, 40);
            this.btnExit.Text = "Exit";
            this.btnExit.BackColor = System.Drawing.Color.LightGreen;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // rtbDisplay
            // 
            this.rtbDisplay.Location = new System.Drawing.Point(340, 20);
            this.rtbDisplay.Size = new System.Drawing.Size(420, 330);
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(780, 370);
            this.Controls.AddRange(new System.Windows.Forms.Control[] {
                this.btnRead, this.btnExit, this.txtFileName, this.txtSize, this.txtURL,
                this.txtLineCount, this.txtWordCount, this.txtCharCount, this.rtbDisplay,
                this.lbl1, this.lbl2, this.lbl3, this.lbl4, this.lbl5, this.lbl6
            });
            this.Name = "Form2";
            this.Text = "Bài 02 - Đọc thông tin file .txt";
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button btnRead;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.TextBox txtSize;
        private System.Windows.Forms.TextBox txtURL;
        private System.Windows.Forms.TextBox txtLineCount;
        private System.Windows.Forms.TextBox txtWordCount;
        private System.Windows.Forms.TextBox txtCharCount;
        private System.Windows.Forms.RichTextBox rtbDisplay;
        private System.Windows.Forms.Label lbl1, lbl2, lbl3, lbl4, lbl5, lbl6;
    }
}
