using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FarmaStead_V2._0_.Model
{
    public class EmployeeDetails:INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        private int employeeID;

        private string employeeName;
        private string employeeAddress;
        private string employeePhone;
        private string salary;
        private int password;
        private string employeeJobTitle;

        private int delivered_stock;
        private int ordered_stock;

        private string serive_area;
        private string farmers_serviced;




        private DataTable dataTable;
        public int EmployeeID
        {
            get { return employeeID; }
            set { employeeID = value; OnPropertyChanged("Id"); }
        }
        public string EmployeeName
        {
            get { return employeeName; }
            set { employeeName = value; OnPropertyChanged("Name"); }
        }
        public string EmployeeAddress
        {
            get { return employeeAddress; }
            set { employeeAddress = value; OnPropertyChanged("Address"); }
        }
        public string EmployeePhone
        {
            get { return employeePhone; }
            set { employeePhone = value; OnPropertyChanged("Phone"); }
        }
        public string Salary
        {
            get { return salary; }
            set { salary = value; OnPropertyChanged("Salary"); }
        }
        public string EmployeeJobTitle
        {
            get { return employeeJobTitle; }
            set { employeeJobTitle = value; OnPropertyChanged("Title"); }
        }
        public int Password
        {
            get { return password; }
            set { password = value; OnPropertyChanged("Password"); }
        }

        public int Stock_Ordered
        {
            get { return ordered_stock; }
            set { ordered_stock = value; OnPropertyChanged("Stock Ordered"); }
        }

        public int Stock_Delivered
        {
            get { return delivered_stock; }
            set { delivered_stock = value; OnPropertyChanged("Stock Delivered"); }
        }



        public DataTable DataTable
        {
            get { return dataTable; }
            set { dataTable = value; OnPropertyChanged("DataTable"); }
        }





    }
}
