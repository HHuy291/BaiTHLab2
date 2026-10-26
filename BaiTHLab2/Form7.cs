using System;
using System.IO;
using System.Windows.Forms;

namespace BaiTHLab2
{
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            try
            {
                string[] drives = Directory.GetLogicalDrives();
                foreach (string drive in drives)
                {
                    TreeNode node = new TreeNode(drive);
                    node.Tag = drive;
                    node.Nodes.Add("...");
                    treeView1.Nodes.Add(node);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi nạp ổ đĩa: " + ex.Message);
            }
        }

        private void treeView1_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            TreeNode currentNode = e.Node;
            string path = currentNode.Tag.ToString();

            try
            {
                listBoxFiles.Items.Clear();
                currentNode.Nodes.Clear();

                // 1. Quét và hiển thị các thư mục con
                string[] dirs = Directory.GetDirectories(path);
                foreach (string dir in dirs)
                {
                    DirectoryInfo di = new DirectoryInfo(dir);
                    TreeNode subNode = new TreeNode(di.Name);
                    subNode.Tag = dir;
                    subNode.Nodes.Add("...");
                    currentNode.Nodes.Add(subNode);
                }

                // 2. Quét và hiển thị các tập tin (ĐÃ THÊM BỘ LỌC BỎ FILE .TMP)
                string[] files = Directory.GetFiles(path);
                foreach (string file in files)
                {
                    // Nếu là file hệ thống có đuôi .tmp thì bỏ qua, không hiện lên màn hình
                    if (Path.GetExtension(file).ToLower() == ".tmp") continue;

                    listBoxFiles.Items.Add(Path.GetFileName(file));
                }

                currentNode.Expand();
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Thư mục hệ thống này bị Windows từ chối quyền truy cập!", "Cảnh báo bảo mật", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Không thể mở thư mục này: " + ex.Message);
            }
        }
    }
}
