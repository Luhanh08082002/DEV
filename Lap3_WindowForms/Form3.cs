using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security;
using System.Text;
using System.Windows.Forms;

namespace Lap3_WindowForms
{
    public partial class Form3 : Form
    {
       
        private Dictionary<string, string> accessCodes = new Dictionary<string, string>()
        {
            { "1645", "Technicians" },
            { "1689", "Technicians" },
            { "8345", "Custodians" },
            { "9998", "Scientists" },
            { "1006", "Scientists" },
            { "1007", "Scientists" },
            { "1008", "Scientists" }
        };
        public Form3()
        {
            InitializeComponent();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            txtSecutityCode.Text = txtSecutityCode.Text + bt5.Text;
        }

        private void txtSecutityCode_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            txtSecutityCode.Text = txtSecutityCode.Text+bt1.Text;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            txtSecutityCode.Text = txtSecutityCode.Text + bt2.Text;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            txtSecutityCode.Text = txtSecutityCode.Text + bt3.Text;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            txtSecutityCode.Text = txtSecutityCode.Text + bt4.Text;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            txtSecutityCode.Text = txtSecutityCode.Text + bt6.Text;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            txtSecutityCode.Text = txtSecutityCode.Text + bt7.Text;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            txtSecutityCode.Text = txtSecutityCode.Text + bt8.Text;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            txtSecutityCode.Text = txtSecutityCode.Text + bt9.Text;
        }

        private void bt0_Click(object sender, EventArgs e)
        {
            txtSecutityCode.Text = txtSecutityCode.Text + bt0.Text;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btThang_Click(object sender, EventArgs e)
        {
            if (accessCodes.ContainsKey(txtSecutityCode.Text))
            {
                string group = accessCodes[txtSecutityCode.Text];
                string currentTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                string log = $"{currentTime} {group}";
                listBox.Items.Add(log);
            }
            else if (txtSecutityCode.Text.Length >= 3 || txtSecutityCode.Text.Length < 4)
            {
                string currentTime = DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss");

                string log = $"{currentTime} Restricted Access!";
                listBox.Items.Add(log);
            }

          
            txtSecutityCode.Text = "";
        }

        private void btC_Click(object sender, EventArgs e)
        {
            txtSecutityCode.Text = "";
        }
    }
    
}
