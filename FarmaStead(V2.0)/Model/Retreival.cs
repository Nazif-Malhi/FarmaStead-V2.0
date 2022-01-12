using FarmaStead_V2._0_.Commands;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaStead_V2._0_.Model
{
    public class Retreival
    {
        public static void getEmployes(DataGridView gv,DataGridViewColumn EmployeeIDGV, DataGridViewColumn EmployeeNameGV, DataGridViewColumn EmployeeAdressGV, DataGridViewColumn EmployeePhoneGV, DataGridViewColumn EmployeeSalaryGV) {
            try
            {
                SqlCommand sql = new SqlCommand("SelectAllEmployees", Connection.con);
                sql.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql);
                DataTable dataTable = new DataTable();
                sqlDataAdapter.Fill(dataTable);
                EmployeeIDGV.DataPropertyName = dataTable.Columns["Employee ID"].ToString();
                EmployeeNameGV.DataPropertyName = dataTable.Columns["Employee Name"].ToString();
                EmployeeAdressGV.DataPropertyName = dataTable.Columns["Employee's Address"].ToString();
                EmployeePhoneGV.DataPropertyName = dataTable.Columns["Employee Phone No."].ToString();
                EmployeeSalaryGV.DataPropertyName = dataTable.Columns["Employee's Salary"].ToString();
                gv.DataSource = dataTable;
                Connection.con.Close();
            }
            catch (Exception ex)
            {
                Connection.con.Close();
                MessageBox.Show(ex.Message);
            }
        }
    }
}
