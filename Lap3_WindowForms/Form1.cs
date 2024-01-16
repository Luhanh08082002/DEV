using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Lap3_WindowForms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btCong_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNumber1.Text);
            int m = int.Parse(txtNumber2.Text);
            int Tong = n + m;
            txtKetqua.Text = Tong.ToString();
        }

        private void BtTru_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNumber1.Text);
            int m = int.Parse(txtNumber2.Text);
            int Tru = n - m;
            txtKetqua.Text = Tru.ToString();
        }

        private void btXoa_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = "";
            txtNumber2.Text = "";
            txtKetqua.Text = "";
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btNhan_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNumber1.Text);
            int m = int.Parse(txtNumber2.Text);
            int Nhan = n * m;
            txtKetqua.Text = Nhan.ToString();

        }

        private void btChia_Click(object sender, EventArgs e)
        {
            int n = int.Parse(txtNumber1.Text);
            int m = int.Parse(txtNumber2.Text);
            int Nhan = n / m;
            txtKetqua.Text = Nhan.ToString();
        }
    }
}
