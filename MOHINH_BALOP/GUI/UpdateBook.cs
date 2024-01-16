using System;

using System.Windows.Forms;
using DTO;
using BLL;
namespace GUI
{
  
    public partial class UpdateBook : Form
    {
        Borreewer_BILL bors = new Borreewer_BILL();
      
        public UpdateBook()
        {
            InitializeComponent();
        }

        private void btn_Exit_Click(object sender, EventArgs e)
        {
           
            DialogResult dt = MessageBox.Show("Bạn muốn Thoát chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (dt == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {

                DateTime aDateTime = DateTime.Now;
                if (txt_BookName.Text != "" && txt_Author.Text != "" && txt_Author.Text != "")
                {

                    Book_DTO bor = new Book_DTO(txt_BookID.Text,txt_BookName.Text, txt_Author.Text, aDateTime);
                    if (bors.UpdateBook(bor))
                    {

                        MessageBox.Show("CẬP NHật Thành CÔng" , "Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                       dgv_view.DataSource = bors.getBook();
                }
                    else
                    {
                    MessageBox.Show("Cập NHật Thất Bại", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                MessageBox.Show("Vui Lòng Nhập Các thông Tin Đầy Đủ", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }


        }

        private void btn_Insert_Click(object sender, EventArgs e)
        {
            
            DateTime aDateTime = DateTime.Now;            
            if (txt_BookName.Text != "" && txt_Author.Text != "" && txt_Author.Text != "")
            {
               
                Book_DTO bor = new Book_DTO(txt_BookID.Text, txt_BookName.Text, txt_Author.Text, aDateTime);
                if (bors.isCheckID(txt_BookID.Text))
                {
                    MessageBox.Show("Tên Book_Id đã Tồn Tại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                 if(bors.InsertBorreewer(bor))
                    {

                        MessageBox.Show("Thêm Thành Công !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        dgv_view.DataSource = bors.getBook();
                    }
                    else
                    {
                        MessageBox.Show("Thêm Thất Bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    }
                }
               
            }
            else
            {
                MessageBox.Show("Vui Lòng Nhập Các Thông Tin Đầy Đủ", "THÔNG BÁO ! ", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            txt_BookID.Clear();
            txt_BookName.Clear();
            txt_Author.Clear();
            txt_PubliccationYear.Clear();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            if (txt_BookID.Text != "")
            {
                DialogResult dt = MessageBox.Show("Bạn muốn Xoá 1 Item trong Bảng Không ? ", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (dt == DialogResult.Yes)
                {
                    if (bors.DeleteBook(txt_BookID.Text))
                    {
                        MessageBox.Show("Xoá Thành Công 1 Item!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        dgv_view.DataSource = bors.getBook();
                    }
                    else
                    {
                        MessageBox.Show("Xoá Thất Bại","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                }
               
            }
            else
            {
                MessageBox.Show("Vui Lòng Chọn Item Để Xoá !", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            }
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

            dgv_view.DataSource = bors.getBook();
        }

        private void dgv_view_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            dgv_view.DataSource = bors.getBook();
        }

        private void dgv_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex == -1) return;
            {
                DataGridViewRow row = new DataGridViewRow();
                row = dgv_view.Rows[e.RowIndex];
                txt_BookID.Text = Convert.ToString(row.Cells[0].Value);
                txt_BookName.Text = Convert.ToString(row.Cells[1].Value);
                txt_Author.Text = Convert.ToString(row.Cells[2].Value);
                txt_PubliccationYear.Text = Convert.ToString(row.Cells[3].Value);
            }
        }
    }
}
