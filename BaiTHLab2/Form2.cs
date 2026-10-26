using System;
using System.IO;
using System.Windows.Forms;

namespace BaiTHLab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnRead_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "Text Files (*.txt)|*.txt";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                FileInfo fileInfo = new FileInfo(ofd.FileName);
                txtFileName.Text = ofd.SafeFileName;
                txtSize.Text = fileInfo.Length + " bytes";
                txtURL.Text = ofd.FileName;

                string content = "";
                int lineCount = 0;
                int wordCount = 0;
                int charCount = 0;

                using (FileStream fs = new FileStream(ofd.FileName, FileMode.Open, FileAccess.Read))
                using (StreamReader sr = new StreamReader(fs))
                {
                    content = sr.ReadToEnd();
                }

                rtbDisplay.Text = content;
                charCount = content.Length;

                string[] lines = content.Split(new[] { "\r\n", "\r", "\n" }, StringSplitOptions.None);
                lineCount = lines.Length;

                string[] words = content.Split(new[] { ' ', '\r', '\n', '\t' }, StringSplitOptions.RemoveEmptyEntries);
                wordCount = words.Length;

                txtLineCount.Text = lineCount.ToString();
                txtWordCount.Text = wordCount.ToString();
                txtCharCount.Text = charCount.ToString();
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
