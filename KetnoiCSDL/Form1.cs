using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace KetnoiCSDL
{
    public partial class Form1 : Form
    {

        SqlConnection connection;
        SqlCommand command;

        string str = @"Data Source=DESKTOP-IFEAUMD;Initial Catalog=QL-NHANSU;Integrated Security=True";
        SqlDataAdapter adapter = new SqlDataAdapter();
        DataTable table= new DataTable();

        void loaddata()
        {
            command = connection.CreateCommand();
            command.CommandText = "select * from thongtinnv";
            adapter.SelectCommand = command;
            table.Clear();
            adapter.Fill(table);

            dgvshow.DataSource = table;
        }
        public Form1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            connection = new SqlConnection(str);
            connection.Open();
            loaddata();
        }

        private void dgvshow_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           /* connection = new SqlConnection(str);
            connection.Open();
            loaddata();*/
        }
    }
}
