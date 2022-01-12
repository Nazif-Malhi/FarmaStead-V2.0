using FarmaStead_V2._0_.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaStead_V2._0_.Views.DataForms
{
    public partial class EmployeeDataForm : Form
    {
        EmployeeViewModel employee;
        int id;
        public EmployeeDataForm()
        {
            InitializeComponent();
            employee = new EmployeeViewModel();
        }
        public EmployeeDataForm(int id) {

            this.id = id;
        
            load_components();
        }

        private void load_components() {
            ID_TextBox.Text = id.ToString();
            
        }

        private void OK_pictureBox_Click(object sender, EventArgs e)
        {
            employee.currentEmployee.EmployeeID = Convert.ToInt32(ID_TextBox.Text);
            employee.currentEmployee.EmployeeName = name_TextBox.Text;
            employee.currentEmployee.EmployeeAddress = address_TextBox.Text;
            employee.currentEmployee.EmployeePhone = phone_TextBox.Text;
            employee.currentEmployee.Salary = salary_TextBox.Text;
            employee.currentEmployee.Password = Convert.ToInt32(password_TextBox.Text);
            employee.currentEmployee.EmployeeJobTitle = title_TextBox.Text;
            employee.saved();
        }
    }
}
