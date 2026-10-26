using System;
using System.IO;
using System.Windows.Forms;

namespace BaiTHLab2
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void btnXuLy_Click(object sender, EventArgs e)
        {
            string inFile = "input5.txt";
            string outFile = "output5.txt";

            if (!File.Exists(inFile))
            {
                File.WriteAllText(inFile, "Lat Mat 7\n80000\nPhòng chiếu 1\n50\n20");
            }

            progressBar1.Value = 10;
            try
            {
                string[] lines = File.ReadAllLines(inFile);
                progressBar1.Value = 40;

                string tenPhim = lines[0];
                int giaVeChuan = int.Parse(lines[1]);
                string phongChieu = lines[2];
                int tongVe = int.Parse(lines[3]);
                int veDaBan = int.Parse(lines[4]);

                int veTon = tongVe - veDaBan;
                long doanhThu = (long)veDaBan * giaVeChuan;
                double tiLeVeBan = ((double)veDaBan / tongVe) * 100;

                progressBar1.Value = 70;
                string result = $"Tên phim: {tenPhim}\nSố lượng vé bán ra: {veDaBan}\nSố lượng vé tồn: {veTon}\nTỉ lệ vé bán: {Math.Round(tiLeVeBan, 2)}%\nDoanh thu: {doanhThu} VND";

                rtbThongKe.Text = result;
                File.WriteAllText(outFile, result);

                progressBar1.Value = 100;
                MessageBox.Show("Thống kê phòng vé thành công!");
            }
            catch (Exception ex) { MessageBox.Show("Lỗi: " + ex.Message); }
        }
    }
}
