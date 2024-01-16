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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btTim_Click(object sender, EventArgs e)
        {
            try
            {
                int a = int.Parse(txtNumber1.Text);
                int b = int.Parse(txtNumber2.Text);

                if(a <= 0 || b <= 0)
                {
                    MessageBox.Show("Vui lòng nhập hai số nguyên dương.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                int uscln = FindGCD(a, b);
                int uscnn = a * b / uscln;

                if (rdBtnLN.Checked)
                {
                    txtKetqua.Text = uscln.ToString();
                }
                else
                {
                    txtKetqua.Text = uscnn.ToString();
                }
            }
            catch (FormatException)
            {
                MessageBox.Show("Vui lòng nhập hai số nguyên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    
        private int FindGCD(int a, int b)
        {
            while(b != 0) { 
            int temp = b;
                b = a % b;
                a = temp;
            }
            return a;
        }

        private void btClose_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show("Bạn Có Chắc Chắn THoát Chương Trình ? ", "Thoát", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if(result == DialogResult.OK)
            {
                Application.Exit();
            }
        }

        private void btBoqua_Click(object sender, EventArgs e)
        {
            txtNumber1.Text = string.Empty;
            txtNumber2.Text = string.Empty;
            txtKetqua.Text = string.Empty;
        }
    }
}
