using FarmaStead_V2._0_.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FarmaStead_V2._0_.Model.Stock;

namespace FarmaStead_V2._0_.Model
{
    class Services
    {
        public class Service_Details : INotifyPropertyChanged
        {
            //---loans, debit bala bala

            public event PropertyChangedEventHandler PropertyChanged;
            private void OnPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

            private DataTable dataTable;
            public DataTable DataTable
            {
                get { return dataTable; }
                set { dataTable = value; OnPropertyChanged("DataTable"); }

            }

            public DataTable getdata_Loan()
            {
                DataTable dataTable = new DataTable();
                try
                {
                    SqlCommand sql = new SqlCommand("FarmerLoanDetails", Connection.con);
                    sql.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql);
                    Service_Details serviceDetails = new Service_Details();
                    sqlDataAdapter.Fill(dataTable);
                    serviceDetails.DataTable = dataTable;
                    Connection.con.Close();
                }
                catch (Exception ex)
                {
                    Connection.con.Close();
                    MessageBox.Show(ex.Message);
                }
                return dataTable;
            }

            public DataTable getdata_Farmers()
            {
                DataTable dataTable = new DataTable();
                try
                {
                    SqlCommand sql = new SqlCommand("FarmerDetails", Connection.con);
                    sql.CommandType = CommandType.StoredProcedure;
                    SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql);
                    Service_Details serviceDetails = new Service_Details();
                    sqlDataAdapter.Fill(dataTable);
                    serviceDetails.DataTable = dataTable;
                    Connection.con.Close();
                }
                catch (Exception ex)
                {
                    Connection.con.Close();
                    MessageBox.Show(ex.Message);
                }
                return dataTable;
            }
        }
    }
}