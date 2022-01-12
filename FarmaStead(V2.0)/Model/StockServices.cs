using FarmaStead_V2._0_.Commands;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FarmaStead_V2._0_.Model.Stock;

namespace FarmaStead_V2._0_.Model
{
    class StockServices
    {
        public StockServices()
        {
        }



        // this will show the general info about all stock
        public DataTable getdata()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand sql = new SqlCommand("SelectAllStock", Connection.con);
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


        //For only the stock named as fertilizer-----

        // this will show the all info about fertilizer
        public DataTable getfertilizerdata()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand sql = new SqlCommand("SelectAllFertilizer", Connection.con);
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
        public bool addFertilizer(StockDetails fertilizer)
        {
            try
            {
                //insert into fertilizer
                SqlCommand sqlCommand = new SqlCommand("InsertIntoFertilizer", Connection.con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", fertilizer.StockID);
                sqlCommand.Parameters.AddWithValue("@name", fertilizer.StockName);
                sqlCommand.Parameters.AddWithValue("@available", fertilizer.StockAvailable );
                sqlCommand.Parameters.AddWithValue("@ordered", fertilizer.StockOrdered);
                sqlCommand.Parameters.AddWithValue("@price", fertilizer.StockPrice);
                sqlCommand.Parameters.AddWithValue("@type", fertilizer.StockType);
                sqlCommand.Parameters.AddWithValue("@manufacturer", fertilizer.StockManufacturer);
                sqlCommand.Parameters.AddWithValue("@descrip", fertilizer.StockDesccription);
                sqlCommand.Parameters.AddWithValue("@emp_id", fertilizer.EmployeeID);
                Connection.con.Open();
                int res = sqlCommand.ExecuteNonQuery();
                Connection.con.Close();
                if (res > 0)
                {
                    MessageBox.Show(fertilizer.StockName + "Added Succesfully into the database", "Success");

                }
                return true;

            }
            catch (Exception)
            {
                Connection.con.Close();
                MessageBox.Show("Unable to save.\nPossible error: \nMay exist already.\nContact vendor ", "Success");
                return false;
            }
        }
        public bool deleteFertilizer(StockDetails fertilizer)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DeleteFertilizer", Connection.con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", fertilizer.StockID);
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
                MessageBox.Show("Unable to delete Role.\nPossible error: \nRole may exist already.\nContact vendor ", "Success");
                return false;
            }
        }
        public bool updateFertilizer(StockDetails fertilizer)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateFertilizer ", Connection.con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", fertilizer.StockID);
                sqlCommand.Parameters.AddWithValue("@name", fertilizer.StockName);
                sqlCommand.Parameters.AddWithValue("@available", fertilizer.StockAvailable);
                sqlCommand.Parameters.AddWithValue("@ordered", fertilizer.StockOrdered);
                sqlCommand.Parameters.AddWithValue("@price", fertilizer.StockPrice);
                sqlCommand.Parameters.AddWithValue("@type", fertilizer.StockType);
                sqlCommand.Parameters.AddWithValue("@manufacturer", fertilizer.StockManufacturer);
                sqlCommand.Parameters.AddWithValue("@descrip", fertilizer.StockDesccription);
                sqlCommand.Parameters.AddWithValue("@emp_id", fertilizer.EmployeeID); 
                Connection.con.Open();
                int res = sqlCommand.ExecuteNonQuery();
                Connection.con.Close();
                if (res > 0)
                {
                    MessageBox.Show(fertilizer.StockName + "Update Succesfully into the database", "Success");

                }
                return true;

            }
            catch (Exception)
            {
                Connection.con.Close();
                MessageBox.Show("Unable to update\nPossible error: \nRole may exist already.\nContact vendor ", "Success");
                return false;
            }
        }



        //for only the stok named as Pesticides
        // this will show the all info about pesticide
        public DataTable getpesticidedata()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand sql = new SqlCommand("SelectAllPesticide", Connection.con);
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
        public bool addPesticide(StockDetails pesticide)
        {
            try
            {
                //insert into pesticide
                SqlCommand sqlCommand = new SqlCommand("InsertIntoFertilizer", Connection.con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", pesticide.StockID);
                sqlCommand.Parameters.AddWithValue("@name", pesticide.StockName);
                sqlCommand.Parameters.AddWithValue("@available", pesticide.StockAvailable);
                sqlCommand.Parameters.AddWithValue("@ordered", pesticide.StockOrdered);
                sqlCommand.Parameters.AddWithValue("@price", pesticide.StockPrice);
                sqlCommand.Parameters.AddWithValue("@type", pesticide.StockType);
                sqlCommand.Parameters.AddWithValue("@manufacturer", pesticide.StockManufacturer);
                sqlCommand.Parameters.AddWithValue("@descrip", pesticide.StockDesccription);
                sqlCommand.Parameters.AddWithValue("@emp_id", pesticide.EmployeeID);
                Connection.con.Open();
                int res = sqlCommand.ExecuteNonQuery();
                Connection.con.Close();
                if (res > 0)
                {
                    MessageBox.Show(pesticide.StockName + "Added Succesfully into the database", "Success");

                }
                return true;

            }
            catch (Exception)
            {
                Connection.con.Close();
                MessageBox.Show("Unable to save.\nPossible error: \nMay exist already.\nContact vendor ", "Success");
                return false;
            }
        }
        public bool deletePesticide(StockDetails pesticide)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DeletePesticide", Connection.con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", pesticide.StockID);
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
                MessageBox.Show("Unable to delete Role.\nPossible error: \nRole may exist already.\nContact vendor ", "Success");
                return false;
            }
        }
        public bool updatePesticide(StockDetails pesticide)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateFertilizer ", Connection.con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", pesticide.StockID);
                sqlCommand.Parameters.AddWithValue("@name", pesticide.StockName);
                sqlCommand.Parameters.AddWithValue("@available", pesticide.StockAvailable);
                sqlCommand.Parameters.AddWithValue("@ordered", pesticide.StockOrdered);
                sqlCommand.Parameters.AddWithValue("@price", pesticide.StockPrice);
                sqlCommand.Parameters.AddWithValue("@type", pesticide.StockType);
                sqlCommand.Parameters.AddWithValue("@manufacturer", pesticide.StockManufacturer);
                sqlCommand.Parameters.AddWithValue("@descrip", pesticide.StockDesccription);
                sqlCommand.Parameters.AddWithValue("@emp_id", pesticide.EmployeeID);
                Connection.con.Open();
                int res = sqlCommand.ExecuteNonQuery();
                Connection.con.Close();
                if (res > 0)
                {
                    MessageBox.Show(pesticide.StockName + "Update Succesfully into the database", "Success");

                }
                return true;

            }
            catch (Exception)
            {
                Connection.con.Close();
                MessageBox.Show("Unable to update\nPossible error: \nRole may exist already.\nContact vendor ", "Success");
                return false;
            }
        }



        //for only the stok named as machinery
        // this will show the all info about machinery
        public DataTable getmachinerydata()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand sql = new SqlCommand("SelectAllMachinery", Connection.con);
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
        public bool addMachinery(StockDetails machinery)
        {
            try
            {
                //insert into pesticide
                SqlCommand sqlCommand = new SqlCommand("InsertIntoMachinery", Connection.con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", machinery.StockID);
                sqlCommand.Parameters.AddWithValue("@name", machinery.StockName);
                sqlCommand.Parameters.AddWithValue("@available", machinery.StockAvailable);
                sqlCommand.Parameters.AddWithValue("@ordered", machinery.StockOrdered);
                sqlCommand.Parameters.AddWithValue("@price", machinery.StockPrice);
                sqlCommand.Parameters.AddWithValue("@type", machinery.StockType);
                sqlCommand.Parameters.AddWithValue("@catagry", machinery.StockCatagory);
                sqlCommand.Parameters.AddWithValue("@manufacturer", machinery.StockManufacturer);
                sqlCommand.Parameters.AddWithValue("@emp_id", machinery.EmployeeID);
                Connection.con.Open();
                int res = sqlCommand.ExecuteNonQuery();
                Connection.con.Close();
                if (res > 0)
                {
                    MessageBox.Show(machinery.StockName + "Added Succesfully into the database", "Success");

                }
                return true;

            }
            catch (Exception)
            {
                Connection.con.Close();
                MessageBox.Show("Unable to save.\nPossible error: \nMay exist already.\nContact vendor ", "Success");
                return false;
            }
        }
        public bool deleteMachinery(StockDetails machinery)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DeleteMachinery", Connection.con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", machinery.StockID);
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
                MessageBox.Show("Unable to delete Role.\nPossible error: \nRole may exist already.\nContact vendor ", "Success");
                return false;
            }
        }
        public bool updateMachinery(StockDetails machinery)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateFertilizer ", Connection.con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", machinery.StockID);
                sqlCommand.Parameters.AddWithValue("@name", machinery.StockName);
                sqlCommand.Parameters.AddWithValue("@available", machinery.StockAvailable);
                sqlCommand.Parameters.AddWithValue("@ordered", machinery.StockOrdered);
                sqlCommand.Parameters.AddWithValue("@price", machinery.StockPrice);
                sqlCommand.Parameters.AddWithValue("@type", machinery.StockType);
                sqlCommand.Parameters.AddWithValue("@catagry", machinery.StockCatagory);
                sqlCommand.Parameters.AddWithValue("@manufacturer", machinery.StockManufacturer);
                sqlCommand.Parameters.AddWithValue("@emp_id", machinery.EmployeeID);
                Connection.con.Open();
                int res = sqlCommand.ExecuteNonQuery();
                Connection.con.Close();
                if (res > 0)
                {
                    MessageBox.Show(machinery.StockName + "Update Succesfully into the database", "Success");

                }
                return true;

            }
            catch (Exception)
            {
                Connection.con.Close();
                MessageBox.Show("Unable to update\nPossible error: \nRole may exist already.\nContact vendor ", "Success");
                return false;
            }
        }

        //for only the stok named as seed
        // this will show the all info about seed
        public DataTable getseeddata()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand sql = new SqlCommand("SelectAllSeed", Connection.con);
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
        public bool addSeed(StockDetails seed)
        {
            try
            {
                //insert into pesticide
                SqlCommand sqlCommand = new SqlCommand("InsertIntoSeed", Connection.con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", seed.StockID);
                sqlCommand.Parameters.AddWithValue("@name", seed.StockName);
                sqlCommand.Parameters.AddWithValue("@available", seed.StockAvailable);
                sqlCommand.Parameters.AddWithValue("@ordered", seed.StockOrdered);
                sqlCommand.Parameters.AddWithValue("@price", seed.StockPrice);
                sqlCommand.Parameters.AddWithValue("@type", seed.StockType);
                sqlCommand.Parameters.AddWithValue("@quality", seed.StockQuality);
                sqlCommand.Parameters.AddWithValue("@manufacturer", seed.StockManufacturer);
                sqlCommand.Parameters.AddWithValue("@emp_id", seed.EmployeeID);
                Connection.con.Open();
                int res = sqlCommand.ExecuteNonQuery();
                Connection.con.Close();
                if (res > 0)
                {
                    MessageBox.Show(seed.StockName + "Added Succesfully into the database", "Success");

                }
                return true;

            }
            catch (Exception)
            {
                Connection.con.Close();
                MessageBox.Show("Unable to save.\nPossible error: \nMay exist already.\nContact vendor ", "Success");
                return false;
            }
        }
        public bool deleteSeed(StockDetails seed)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DeleteSeed", Connection.con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", seed.StockID);
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
                MessageBox.Show("Unable to delete Role.\nPossible error: \nRole may exist already.\nContact vendor ", "Success");
                return false;
            }
        }
        public bool updateSeed(StockDetails seed)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateSeed ", Connection.con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", seed.StockID);
                sqlCommand.Parameters.AddWithValue("@name", seed.StockName);
                sqlCommand.Parameters.AddWithValue("@available", seed.StockAvailable);
                sqlCommand.Parameters.AddWithValue("@ordered", seed.StockOrdered);
                sqlCommand.Parameters.AddWithValue("@price", seed.StockPrice);
                sqlCommand.Parameters.AddWithValue("@type", seed.StockType);
                sqlCommand.Parameters.AddWithValue("@quality", seed.StockQuality);
                sqlCommand.Parameters.AddWithValue("@manufacturer", seed.StockManufacturer);
                sqlCommand.Parameters.AddWithValue("@emp_id", seed.EmployeeID);
                Connection.con.Open();
                int res = sqlCommand.ExecuteNonQuery();
                Connection.con.Close();
                if (res > 0)
                {
                    MessageBox.Show(seed.StockName + "Update Succesfully into the database", "Success");

                }
                return true;

            }
            catch (Exception)
            {
                Connection.con.Close();
                MessageBox.Show("Unable to update\nPossible error: \nRole may exist already.\nContact vendor ", "Success");
                return false;
            }
        }

   
        //for only the stok named as harvested Crop
        // this will show the all info about Harvested Crop
        public DataTable geth_cropdata()
        {
            DataTable dataTable = new DataTable();
            try
            {
                SqlCommand sql = new SqlCommand("SelectHarvestedCrop", Connection.con);
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
        public bool addH_Crop(StockDetails h_crop)
        {
            try
            {
                //insert into harvested Crop
                SqlCommand sqlCommand = new SqlCommand("InsertIntoHarvestedCrop", Connection.con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", h_crop.StockID);
                sqlCommand.Parameters.AddWithValue("@name", h_crop.StockName);
                sqlCommand.Parameters.AddWithValue("@available", h_crop.StockAvailable);
                sqlCommand.Parameters.AddWithValue("@price", h_crop.StockPrice);
                sqlCommand.Parameters.AddWithValue("@type", h_crop.StockType);
                sqlCommand.Parameters.AddWithValue("@buyer", h_crop.CropBuyer);
                sqlCommand.Parameters.AddWithValue("@farmer_id", h_crop.FarmerID);
                sqlCommand.Parameters.AddWithValue("@emp_id", h_crop.EmployeeID);
                Connection.con.Open();
                int res = sqlCommand.ExecuteNonQuery();
                Connection.con.Close();
                if (res > 0)
                {
                    MessageBox.Show(h_crop.StockName + "Added Succesfully into the database", "Success");

                }
                return true;

            }
            catch (Exception)
            {
                Connection.con.Close();
                MessageBox.Show("Unable to save.\nPossible error: \nMay exist already.\nContact vendor ", "Success");
                return false;
            }
        }
        public bool deleteHarvestedCrop(StockDetails h_crop)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("DeleteHarvested", Connection.con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", h_crop.StockID);
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
                MessageBox.Show("Unable to delete Role.\nPossible error: \nRole may exist already.\nContact vendor ", "Success");
                return false;
            }
        }
        public bool updateHarvestedCrop(StockDetails h_crop)
        {
            try
            {
                SqlCommand sqlCommand = new SqlCommand("UpdateHarvestrop", Connection.con);
                sqlCommand.CommandType = CommandType.StoredProcedure;
                sqlCommand.Parameters.AddWithValue("@id", h_crop.StockID);
                sqlCommand.Parameters.AddWithValue("@name", h_crop.StockName);
                sqlCommand.Parameters.AddWithValue("@available", h_crop.StockAvailable);
                sqlCommand.Parameters.AddWithValue("@price", h_crop.StockPrice);
                sqlCommand.Parameters.AddWithValue("@type", h_crop.StockType);
                sqlCommand.Parameters.AddWithValue("@buyer", h_crop.CropBuyer);
                sqlCommand.Parameters.AddWithValue("@farmer_id", h_crop.FarmerID);
                sqlCommand.Parameters.AddWithValue("@emp_id", h_crop.EmployeeID);
                Connection.con.Open();
                int res = sqlCommand.ExecuteNonQuery();
                Connection.con.Close();
                if (res > 0)
                {
                    MessageBox.Show(h_crop.StockName + "Update Succesfully into the database", "Success");

                }
                return true;

            }
            catch (Exception)
            {
                Connection.con.Close();
                MessageBox.Show("Unable to update\nPossible error: \nRole may exist already.\nContact vendor ", "Success");
                return false;
            }
        }





    }
}
