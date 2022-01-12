using FarmaStead_V2._0_.Commands;
using FarmaStead_V2._0_.Model;
using FarmaStead_V2._0_.ViewModels;
using FarmaStead_V2._0_.Views.DataForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Linq;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaStead_V2._0_.Views.Settings
{
    public partial class Settings_UserControl : UserControl
    {
        private int edit, delete,employeeid;
        EmployeeViewModel employeeViewModel;
        int pass;
        string name, address, phone, salaray, job;
        public Settings_UserControl()
        {
            InitializeComponent();
            employeeViewModel = new EmployeeViewModel();

            EmployeeIDGV.DataPropertyName = employeeViewModel.EmployeeDetailsList.Columns["Employee ID"].ToString();
            employeeNameGV.DataPropertyName = employeeViewModel.EmployeeDetailsList.Columns["Employee Name"].ToString();
            addressGV.DataPropertyName = employeeViewModel.EmployeeDetailsList.Columns["Employee's Address"].ToString();
            phoneGV.DataPropertyName = employeeViewModel.EmployeeDetailsList.Columns["Employee Phone No."].ToString();
            salaryGV.DataPropertyName = employeeViewModel.EmployeeDetailsList.Columns["Employee's Salary"].ToString();
            dataGridView1.DataSource = employeeViewModel.EmployeeDetailsList;
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
            update_PictureBox.BackgroundImage = Properties.Resources.UpdateBtnHover;
        }

        private void update_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            update_PictureBox.BackgroundImage = Properties.Resources.UpdateBtn;
        }

        private void delete_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            delete_PictureBox.BackgroundImage = Properties.Resources.DeleteBtnHover;
        }

        private void delete_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            delete_PictureBox.BackgroundImage = Properties.Resources.DeleteBtn;
        }

        private void add_PictureBox_Click(object sender, EventArgs e)
        {
            EmployeeDataForm employeeDataForm = new EmployeeDataForm();
            employeeDataForm.ShowDialog();
        }

        private void update_PictureBox_Click(object sender, EventArgs e)
        {
            employeeViewModel.currentEmployee.EmployeeID = employeeid;
            EmployeeDataForm employeeDataForm = new EmployeeDataForm(employeeid);
            employeeDataForm.ShowDialog();

        }

        private void delete_PictureBox_Click(object sender, EventArgs e)
        {
            employeeViewModel.currentEmployee.EmployeeID = employeeid;
            employeeViewModel.delete();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex != -1 && e.ColumnIndex != -1)
            {
                edit = 1;
                delete= 1;
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                employeeid = Convert.ToInt32(row.Cells["EmployeeIDGV"].Value.ToString());
                
            }
        }
    }
}
