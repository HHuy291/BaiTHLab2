using System;
using System.IO;
using System.Data;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace BaiTHLab2
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void btnDocVaTinh_Click(object sender, EventArgs e)
        {
            string inFile = "input3.txt";
            string outFile = "output3.txt";

            if (!File.Exists(inFile))
            {
                File.WriteAllText(inFile, "1 + 2 + 3 + 4\r\n12 - 7 - 5 + 2 - 3\r\n2024 - 1 - 2 + 3");
            }

            try
            {
                string[] lines = File.ReadAllLines(inFile);
                string screenOutput = "";
                string fileOutput = "";

                foreach (string line in lines)
                {
                    if (string.IsNullOrWhiteSpace(line)) continue;
                    try
                    {
                        double result = Evaluate(line);
                        string formatLine = $"{line.Trim()} = {result}";
                        screenOutput += formatLine + "\r\n";
                        fileOutput += formatLine + "\r\n";
                    }
                    catch
                    {
                        screenOutput += $"{line.Trim()} = Lỗi cú pháp\r\n";
                    }
                }

                rtbKetQua.Text = screenOutput;
                File.WriteAllText(outFile, fileOutput);
                MessageBox.Show("Đã tính toán và xuất dữ liệu thành công ra file output3.txt!", "Thông báo");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }

        // Thay thế DataTable.Compute bằng bộ phân tích cú pháp cơ bản
        private double Evaluate(string expression)
        {
            // Làm sạch chuỗi
            string expr = expression.Replace(" ", "");

            // Xử lý tính toán tuần tự từ trái qua phải cho biểu thức cơ bản (+, -)
            var matches = Regex.Matches(expr, @"([+-]?\d+(\.\d+)?)");
            double total = 0;
            foreach (Match match in matches)
            {
                total += double.Parse(match.Value, System.Globalization.CultureInfo.InvariantCulture);
            }
            return total;
        }
    }
}
