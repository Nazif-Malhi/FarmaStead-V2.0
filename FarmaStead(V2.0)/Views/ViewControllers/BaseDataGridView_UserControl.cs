using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaStead_V2._0_.Views.ViewControllers
{
    public partial class BaseDataGridView_UserControl : UserControl
    {
        public BaseDataGridView_UserControl()
        {
            InitializeComponent();
            InitializeGrid();
            
        }
        private void InitializeGrid() {
            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;
            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
        }

        private void add_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            add_PictureBox.BackgroundImage = Properties.Resources.AddBtnHover;
        }

        private void add_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            add_PictureBox.BackgroundImage = Properties.Resources.AddBtn;
        }

        private void update_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            add_PictureBox.BackgroundImage = Properties.Resources.UpdateBtnHover;
        }

        private void update_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            add_PictureBox.BackgroundImage = Properties.Resources.UpdateBtn;
        }

        private void delete_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            add_PictureBox.BackgroundImage = Properties.Resources.DeleteBtnHover;
        }

        private void delete_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            add_PictureBox.BackgroundImage = Properties.Resources.DeleteBtn;
        }

        private void add_PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void update_PictureBox_Click(object sender, EventArgs e)
        {

        }

        private void delete_PictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
