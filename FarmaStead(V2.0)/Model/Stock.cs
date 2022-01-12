using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;
using System.Data;


namespace FarmaStead_V2._0_.Model
{
    class Stock
    {
        public class StockDetails : INotifyPropertyChanged
        {
            public event PropertyChangedEventHandler PropertyChanged;
            private void OnPropertyChanged(string propertyName)
            {
                if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
            }

            private int stockID;
            private string stockName;
            private string stockAvailable;
            private int stockOrdered;
            private double stockPrice;
            private int employeeID;
            private string stockType;
            private string stockManufacturer;
            private string stockDescription;
            private string stockCatagory;
            private string stockQuality;
            private int farmerID;
            private string cropBuyer;
            private DataTable dataTable;

            public int StockID
            {
                get { return stockID; }
                set { stockID = value; OnPropertyChanged("Stock ID"); }
            }

            public string StockName
            {
                get { return stockName; }
                set { stockName = value; OnPropertyChanged("Stock ID"); }
            }
            public string StockAvailable
            {
                get { return stockAvailable; }
                set { stockAvailable = value; OnPropertyChanged("Stock Avaialable"); }
            }
            public int StockOrdered
            {
                get { return stockOrdered; }
                set { stockOrdered = value; OnPropertyChanged("Stock Ordered"); }
            }
            public double StockPrice
            {
                get { return stockPrice; }
                set { stockPrice = value; OnPropertyChanged("Stock Price"); }
            }
            public int EmployeeID
            {
                get { return employeeID; }
                set { employeeID = value; OnPropertyChanged("Employee ID"); }
            }
            public string StockType
            {
                get { return stockType; }
                set { stockType = value; OnPropertyChanged("Stock Type"); }
            }
            public string StockManufacturer
            {
                get { return stockManufacturer; }
                set { stockManufacturer = value; OnPropertyChanged("Stock Manufacturer"); }
            }
            public string StockDesccription
            {
                get { return stockDescription; }
                set { stockDescription = value; OnPropertyChanged("Stock Description"); }
            }

            public string StockCatagory
            {
                get { return stockCatagory; }
                set { stockCatagory = value; OnPropertyChanged("Stock Catagory"); }
            }

            public string StockQuality
            {
                get { return stockQuality; }
                set { stockQuality = value; OnPropertyChanged("Stock Quality"); }
            }
            public string CropBuyer
            {
                get { return cropBuyer; }
                set { cropBuyer = value; OnPropertyChanged("Crop Buyer"); }
            }

            public int FarmerID
            {
                get { return farmerID; }
                set { farmerID = value; OnPropertyChanged("Farmer ID"); }
            }
            public DataTable DataTable
            {
                get { return dataTable; }
                set { dataTable = value; OnPropertyChanged("DataTable"); }
            }

        }
    }
}