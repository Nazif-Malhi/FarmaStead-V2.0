using FarmaStead_V2._0_.Commands;
using FarmaStead_V2._0_.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static FarmaStead_V2._0_.Model.Stock;

namespace FarmaStead_V2._0_.ViewModels
{
    class StockViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName)
        {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


        StockServices stockService;

        public StockDetails currentStock;
        public StockViewModel()
        {
            stockService = new StockServices();
            LoadData();
            currentStock = new StockDetails();
        }

        private DataTable stockDetailsList;

        public DataTable StockDetailsList
        {
            get { return stockDetailsList; ; }
            set { stockDetailsList = value; OnPropertyChanged("DataTable"); }
        }
        private void LoadDataAll()
        {
            StockDetailsList = stockService.getdata();
        }

        private void LoadDataFer()
        {
            StockDetailsList = stockService.getfertilizerdata();
        }


        private void LoadDataPest()
        {
            StockDetailsList = stockService.getpesticidedata();
        }


        private void LoadDataMach()
        {
            StockDetailsList = stockService.getmachinerydata();
        }

        
        private void LoadDataSeed()
        {
            StockDetailsList = stockService.getseeddata();
        }

        private void LoadDataHCrop()
        {
            StockDetailsList = stockService.geth_cropdata();
        }
        private StockDetails CurrentStock
        {
            get { return currentStock; }
            set { currentStock = value; OnPropertyChanged("Current Stock"); }
        }


        //for fertilizerssss   
        public void savedFer()
        {
            try
            {
                var IsSaved = stockService.addFertilizer(CurrentStock);
                LoadData();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void deleteFer()
        {
            try
            {
                var IsSaved = stockService.deleteFertilizer(CurrentStock);
                LoadData();
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void updateer()
        {
            try
            {
                var IsSaved = stockService.updateFertilizer(CurrentStock);
                LoadData();
                MessageBox.Show("update");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        //for pesticides  
        public void savedPest()
        {
            try
            {
                var IsSaved = stockService.addPesticide(CurrentStock);
                LoadData();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void deletePest()
        {
            try
            {
                var IsSaved = stockService.deletePesticide(CurrentStock);
                LoadData();
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void updatePest()
        {
            try
            {
                var IsSaved = stockService.updatePesticide(CurrentStock);
                LoadData();
                MessageBox.Show("update");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        //for machinery 
        public void savedMachin()
        {
            try
            {
                var IsSaved = stockService.addMachinery(CurrentStock);
                LoadData();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void deleteMachin()
        {
            try
            {
                var IsSaved = stockService.deleteMachinery(CurrentStock);
                LoadData();
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void updateMachin()
        {
            try
            {
                var IsSaved = stockService.updateMachinery(CurrentStock);
                LoadData();
                MessageBox.Show("update");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        //for seed
        public void savedseed()
        {
            try
            {
                var IsSaved = stockService.addSeed(CurrentStock);
                LoadData();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void deleteSeed()
        {
            try
            {
                var IsSaved = stockService.deleteSeed(CurrentStock);
                LoadData();
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void updateSeed()
        {
            try
            {
                var IsSaved = stockService.updateSeed(CurrentStock);
                LoadData();
                MessageBox.Show("update");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        //for harvested crop 
        public void savedHCrop()
        {
            try
            {
                var IsSaved = stockService.addH_Crop(CurrentStock);
                LoadData();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void deleteHCrop()
        {
            try
            {
                var IsSaved = stockService.deleteHarvestedCrop(CurrentStock);
                LoadData();
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void updateHcrop()
        {
            try
            {
                var IsSaved = stockService.updateHarvestedCrop(CurrentStock);
                LoadData();
                MessageBox.Show("update");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

    }
}