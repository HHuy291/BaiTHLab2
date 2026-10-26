using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace BaiTHLab2
{
    public partial class Form6 : Form
    {
        private List<string[]> basicDb = new List<string[]>();

        public Form6()
        {
            InitializeComponent();
        }

        private void Form6_Load(object sender, EventArgs e)
        {
            // Khởi tạo danh sách món ăn mẫu tương tự bảng cơ sở dữ liệu
            basicDb.Add(new string[] { "Cơm tấm", "Nguyễn Văn A" });
            basicDb.Add(new string[] { "Bún bò Huế", "Trần Thị B" });
            basicDb.Add(new string[] { "Phở bò", "Lê Văn C" });
            basicDb.Add(new string[] { "Bánh mì", "Phạm Văn D" });

            foreach (var item in basicDb)
            {
                ListViewItem lvi = new ListViewItem(item[0]);
                lvi.SubItems.Add(item[1]);
                listView1.Items.Add(lvi);
            }
        }

        private void btnRandom_Click(object sender, EventArgs e)
        {
            if (basicDb.Count == 0) return;
            Random rand = new Random();
            int idx = rand.Next(basicDb.Count);
            MessageBox.Show($"Món ăn đề xuất: {basicDb[idx][0]}\nNgười đóng góp: {basicDb[idx][1]}", "Gợi ý bữa ăn");
        }
    }
}
