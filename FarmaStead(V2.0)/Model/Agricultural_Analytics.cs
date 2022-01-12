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
    class Agricultural_Analytics : INotifyPropertyChanged
    {
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


        //show analytics
        public DataTable getdata()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand sql = new SqlCommand("SelectLandAnalytics", Connection.con);
                sql.CommandType = CommandType.StoredProcedure;
                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sql);
                StockDetails stockDetails = new StockDetails();
                sqlDataAdapter.Fill(dataTable);
                stockDetails.DataTable = dataTable;
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
