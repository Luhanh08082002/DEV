

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Xml;
using BLL;
using DTO;

namespace GUI
{
    public partial class SearchBooks_byName : Form
    {
        Borreewer_BILL bor = new Borreewer_BILL();

       

        public SearchBooks_byName()
        {
            InitializeComponent();
        }


        private void groupBox1_Enter(object sender, EventArgs e)
        {
            try
            {
                dgvGV.DataSource = bor.getBorreewer();
            }
            catch(Exception ex) {
                MessageBox.Show(ex.Message);

            }
           

        }
        private void btn_KN_Click(object sender, EventArgs e)
        {
            
        }

        private void dgvGV_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
           
        }

        private void txt_search_TextChanged(object sender, EventArgs e)
        {
            string name = txt_search.Text.Trim();
            if (name == "")
            {
                groupBox1_Enter(sender, e);
            }
            if (name.Length > 0)
            {
                dgvGV.DataSource = bor.SearchBorrew(txt_search.Text);
            }
        }
    }
}

