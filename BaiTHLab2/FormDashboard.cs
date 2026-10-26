using System;
using System.Windows.Forms;

namespace BaiTHLab2
{
    public partial class FormDashboard : Form
    {
        public FormDashboard()
        {
            InitializeComponent();
        }

        private void btnbaitap1_Click(object sender, EventArgs e)
        {
            Form1 b1 = new Form1();
            b1.ShowDialog();
        }

        private void btnbaitap2_Click(object sender, EventArgs e)
        {
            Form2 b2 = new Form2();
            b2.ShowDialog();
        }

        private void btnbaitap3_Click(object sender, EventArgs e)
        {
            Form3 b3 = new Form3();
            b3.ShowDialog();
        }

        private void btnbaitap4_Click(object sender, EventArgs e)
        {
            Form4 b4 = new Form4();
            b4.ShowDialog();
        }

        private void btnbaitap5_Click(object sender, EventArgs e)
        {
            Form5 b5 = new Form5();
            b5.ShowDialog();
        }

        private void btnbaitap6_Click(object sender, EventArgs e)
        {
            Form6 b6 = new Form6();
            b6.ShowDialog();
        }

        private void btnbaitap7_Click(object sender, EventArgs e)
        {
            Form7 b7 = new Form7();
            b7.ShowDialog();
        }
    }
}
