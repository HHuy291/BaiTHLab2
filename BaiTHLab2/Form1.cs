
using System;
using System.IO;
using System.Windows.Forms;

namespace BaiTHLab2
{
    public partial class Form1 : Form
    {
        private string inputFile = "input1.txt";
        private string outputFile = "output1.txt";

        public Form1()
        {
            InitializeComponent();
        }

        private void btnDocFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (!File.Exists(inputFile))
                {
                    File.WriteAllText(inputFile, "Nguyen Van A\nMSSV: 16520001\nClass: ANTT");
                }
                using (StreamReader sr = new StreamReader(inputFile))
                {
                    rtbNoiDung.Text = sr.ReadToEnd();
                }
                MessageBox.Show("Đọc file thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        private void btnGhiFile_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(rtbNoiDung.Text)) return;
                using (StreamWriter sw = new StreamWriter(outputFile, false))
                {
                    sw.Write(rtbNoiDung.Text.ToUpper());
                }
                MessageBox.Show("Ghi dữ liệu IN HOA vào output1.txt thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
