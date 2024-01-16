using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GUI
{
    public partial class LybraryManagementSystem : Form
    {
        public LybraryManagementSystem()
        {
            InitializeComponent();
        }

        private void LybraryManagementSystem_Load(object sender, EventArgs e)
        {

        }
        private void MainForm_Load(object sender, EventArgs e)
        {
            // Thêm các mục vào menu
            ToolStripMenuItem systemMenuItem = new ToolStripMenuItem("System");
            ToolStripMenuItem updateMenuItem = new ToolStripMenuItem("Update");
            ToolStripMenuItem searchMenuItem = new ToolStripMenuItem("Search");
            ToolStripMenuItem helpMenuItem = new ToolStripMenuItem("Help");

            
        }


        private void systemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LybraryManagementSystem updateBook = new LybraryManagementSystem();
            updateBook.Show();
        }

        private void updateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateBook updateBook = new UpdateBook();
            updateBook.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchBooks_byName updateBook = new SearchBooks_byName();
            updateBook.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
