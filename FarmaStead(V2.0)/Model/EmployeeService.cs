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
    public class EmployeeService
    {
        public EmployeeService() {
        }
        public DataTable getdata() {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand sql = new SqlCommand("SelectAllEmployees", Connection.con);
                sql.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql);
                EmployeeDetails employeeDetails = new EmployeeDetails();
                sqlDataAdapter.Fill(dataTable);
                employeeDetails.DataTable = dataTable;
                Connection.con.Close();
            }
            catch (Exception ex)
            {
                Connection.con.Close();
                MessageBox.Show(ex.Message);
            }
            return dataTable;
        }

        public bool add(EmployeeDetails employee) {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("InsertIntoStockEmployee", Connection.con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", employee.EmployeeID);
                sqlCommand.Parameters.AddWithValue("@name",employee.EmployeeName);
                sqlCommand.Parameters.AddWithValue("@address",employee.EmployeeAddress);
                sqlCommand.Parameters.AddWithValue("@phone",employee.EmployeePhone);
                sqlCommand.Parameters.AddWithValue("@salary",employee.Salary);
                sqlCommand.Parameters.AddWithValue("@title",employee.EmployeeJobTitle);
                sqlCommand.Parameters.AddWithValue("@addition",0);
                sqlCommand.Parameters.AddWithValue("@delivered",0);
                sqlCommand.Parameters.AddWithValue("@password",employee.Password);
                Connection.con.Open();
                int res = sqlCommand.ExecuteNonQuery();
                Connection.con.Close();
                if (res > 0)
                {
                   MessageBox.Show(employee.EmployeeName + "Added Succesfully into the database", "Success");
                  
                }
                return true;

            }
            catch (Exception)
            {
                Connection.con.Close();
                MessageBox.Show("Unable to save Role.\nPossible error: \nRole may exist already.\nContact vendor ", "Success");
                return false;
            }
        }
        public bool delete(EmployeeDetails employee)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DeleteStockEmployee", Connection.con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", employee.EmployeeID);
                Connection.con.Open();
                int res = sqlCommand.ExecuteNonQuery();
                Connection.con.Close();
                if (res > 0)
                {
                  MessageBox.Show("Data deleted succesfully from database", "Success");
                }
                return true;

            }
            catch (Exception)
            {
                Connection.con.Close();
                MessageBox.Show("Unable to save Role.\nPossible error: \nRole may exist already.\nContact vendor ", "Success");
                return false;
            }
        }
        public bool update(EmployeeDetails employee)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateStockEmployee", Connection.con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", employee.EmployeeID);
                sqlCommand.Parameters.AddWithValue("@name", employee.EmployeeName);
                sqlCommand.Parameters.AddWithValue("@address", employee.EmployeeAddress);
                sqlCommand.Parameters.AddWithValue("@phone", employee.EmployeePhone);
                sqlCommand.Parameters.AddWithValue("@salary", employee.Salary);
                sqlCommand.Parameters.AddWithValue("@title", employee.EmployeeJobTitle);
                sqlCommand.Parameters.AddWithValue("@addition", 0);
                sqlCommand.Parameters.AddWithValue("@delivered", 0);
                sqlCommand.Parameters.AddWithValue("@password", employee.Password);
                Connection.con.Open();
                int res = sqlCommand.ExecuteNonQuery();
                Connection.con.Close();
                if (res > 0)
                {
                    MessageBox.Show(employee.EmployeeName + "Update Succesfully into the database", "Success");

                }
                return true;

            }
            catch (Exception)
            {
                Connection.con.Close();
                MessageBox.Show("Unable to save Role.\nPossible error: \nRole may exist already.\nContact vendor ", "Success");
                return false;
            }
        }



    }
}
