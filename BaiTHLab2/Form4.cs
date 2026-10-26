using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace BaiTHLab2
{
    public partial class Form4 : Form
    {
        public class SinhVien
        {
            public string HoTen { get; set; }
            public string MSSV { get; set; }
            public string DienThoai { get; set; }
            public float DiemMon1 { get; set; }
            public float DiemMon2 { get; set; }
            public float DiemMon3 { get; set; }
            public float DiemTrungBinh { get; set; }
        }

        private List<SinhVien> dsNhap = new List<SinhVien>();
        private List<SinhVien> dsDoc = new List<SinhVien>();
        private int indexHienTai = 0;

        public Form4()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (!Regex.IsMatch(txtInPhone.Text, @"^0\d{9}$"))
                {
                    MessageBox.Show("Số điện thoại phải có 10 chữ số và bắt đầu bằng số 0!", "Cảnh báo");
                    return;
                }
                if (!Regex.IsMatch(txtInID.Text, @"^\d{8}$"))
                {
                    MessageBox.Show("Mã số sinh viên phải là một số có 8 chữ số!", "Cảnh báo");
                    return;
                }

                float c1 = float.Parse(txtInC1.Text);
                float c2 = float.Parse(txtInC2.Text);
                float c3 = float.Parse(txtInC3.Text);

                if (c1 < 0 || c1 > 10 || c2 < 0 || c2 > 10 || c3 < 0 || c3 > 10)
                {
                    MessageBox.Show("Điểm của từng học phần phải từ 0 đến 10!", "Cảnh báo");
                    return;
                }

                SinhVien sv = new SinhVien
                {
                    HoTen = txtInName.Text,
                    MSSV = txtInID.Text,
                    DienThoai = txtInPhone.Text,
                    DiemMon1 = c1,
                    DiemMon2 = c2,
                    DiemMon3 = c3
                };

                dsNhap.Add(sv);

                // Hiển thị ngay lên RichTextBox ở giữa theo cấu trúc từng dòng một cách trực quan
                rtbList.AppendText($"{sv.HoTen}\n{sv.MSSV}\n{sv.DienThoai}\n{sv.DiemMon1}\n{sv.DiemMon2}\n{sv.DiemMon3}\n\n");

                txtInName.Clear(); txtInID.Clear(); txtInPhone.Clear(); txtInC1.Clear(); txtInC2.Clear(); txtInC3.Clear();
            }
            catch (Exception)
            {
                MessageBox.Show("Dữ liệu nhập vào không hợp lệ hoặc bị trống!", "Lỗi");
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            if (dsNhap.Count == 0)
            {
                MessageBox.Show("Danh sách sinh viên trống, vui lòng nhấn 'Add' để thêm trước!", "Cảnh báo");
                return;
            }

            try
            {
                // Sử dụng StreamWriter để ghi tuần tự dữ liệu xuống file dạng text thô
                using (StreamWriter sw = new StreamWriter("input4.txt", false))
                {
                    foreach (var sv in dsNhap)
                    {
                        sw.WriteLine(sv.HoTen);
                        sw.WriteLine(sv.MSSV);
                        sw.WriteLine(sv.DienThoai);
                        sw.WriteLine(sv.DiemMon1);
                        sw.WriteLine(sv.DiemMon2);
                        sw.WriteLine(sv.DiemMon3);
                    }
                }
                MessageBox.Show("Đã ghi mảng các sinh viên xuống file input4.txt thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi ghi file: " + ex.Message, "Lỗi");
            }
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            if (!File.Exists("input4.txt"))
            {
                MessageBox.Show("Không tìm thấy file input4.txt để đọc!", "Lỗi");
                return;
            }

            try
            {
                dsDoc.Clear();

                // Đọc file tuần tự bằng StreamReader theo cụm 6 dòng liên tiếp cho mỗi sinh viên
                using (StreamReader sr = new StreamReader("input4.txt"))
                {
                    while (!sr.EndOfStream)
                    {
                        string hoTen = sr.ReadLine();
                        if (string.IsNullOrEmpty(hoTen)) break;

                        SinhVien sv = new SinhVien
                        {
                            HoTen = hoTen,
                            MSSV = sr.ReadLine(),
                            DienThoai = sr.ReadLine(),
                            DiemMon1 = float.Parse(sr.ReadLine()),
                            DiemMon2 = float.Parse(sr.ReadLine()),
                            DiemMon3 = float.Parse(sr.ReadLine())
                        };
                        sv.DiemTrungBinh = (sv.DiemMon1 + sv.DiemMon2 + sv.DiemMon3) / 3;
                        dsDoc.Add(sv);
                    }
                }

                // Ghi dữ liệu kết quả kèm điểm trung bình sang file output4.txt
                using (StreamWriter sw = new StreamWriter("output4.txt", false))
                {
                    foreach (var sv in dsDoc)
                    {
                        sw.WriteLine(sv.HoTen);
                        sw.WriteLine(sv.MSSV);
                        sw.WriteLine(sv.DienThoai);
                        sw.WriteLine(sv.DiemMon1);
                        sw.WriteLine(sv.DiemMon2);
                        sw.WriteLine(sv.DiemMon3);
                        sw.WriteLine(Math.Round(sv.DiemTrungBinh, 2));
                    }
                }

                indexHienTai = 0;
                HienThiSinhVien(indexHienTai);
                MessageBox.Show("Đọc file và tính toán điểm trung bình thành công!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi đọc file hoặc file input4.txt sai cấu trúc dòng! " + ex.Message, "Lỗi");
            }
        }

        private void HienThiSinhVien(int idx)
        {
            if (dsDoc == null || dsDoc.Count == 0 || idx < 0 || idx >= dsDoc.Count) return;

            var sv = dsDoc[idx];
            txtOutName.Text = sv.HoTen;
            txtOutID.Text = sv.MSSV;
            txtOutPhone.Text = sv.DienThoai;
            txtOutC1.Text = sv.DiemMon1.ToString();
            txtOutC2.Text = sv.DiemMon2.ToString();
            txtOutC3.Text = sv.DiemMon3.ToString();
            txtOutAvg.Text = Math.Round(sv.DiemTrungBinh, 2).ToString();

            lblPage.Text = (idx + 1).ToString();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (indexHienTai > 0)
            {
                indexHienTai--;
                HienThiSinhVien(indexHienTai);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (indexHienTai < dsDoc.Count - 1)
            {
                indexHienTai++;
                HienThiSinhVien(indexHienTai);
            }
        }
    }
}
