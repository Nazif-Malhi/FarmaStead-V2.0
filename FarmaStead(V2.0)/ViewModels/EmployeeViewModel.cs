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

namespace FarmaStead_V2._0_.ViewModels
{
    public class EmployeeViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        private void OnPropertyChanged(string propertyName) {
            if (PropertyChanged != null) PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }


        EmployeeService employeeService;
        public EmployeeViewModel() {
            employeeService = new EmployeeService();
            LoadData();
            currentEmployee = new EmployeeDetails();
        }
        private DataTable employeeDetailsList;

        public DataTable EmployeeDetailsList
        {
            get { return employeeDetailsList; }
            set { employeeDetailsList = value; OnPropertyChanged("DataTable"); }
        }
        private void LoadData() {
         EmployeeDetailsList= employeeService.getdata();
        }

        private void LoadDataStEmp()
        {
            EmployeeDetailsList = employeeService.getSEmp();
        }

        private void LoadDataSrEmp()
        {
            EmployeeDetailsList = employeeService.getSrEmp();
        }

        private void LoadDataTEmp()
        {
            EmployeeDetailsList = employeeService.getTEmp();
        }
        public EmployeeDetails currentEmployee;

        private EmployeeDetails CurrentEmployee
        {
            get { return currentEmployee; }
            set { currentEmployee = value;OnPropertyChanged("Current Emplyee"); }
        }

        //stock manager
        public void savedSEmp() {
            try
            {
                var IsSaved = employeeService.addSEmp(CurrentEmployee);
                LoadData();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void deleteSEmp()
        {
            try
            {
                var IsSaved = employeeService.deleteSEmp(CurrentEmployee);
                LoadData();
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void updateSEmp()
        {
            try
            {
                var IsSaved = employeeService.updateSEmp(CurrentEmployee);
                LoadData();
                MessageBox.Show("update");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        //ser provider

        public void savedSrEmp()
        {
            try
            {
                var IsSaved = employeeService.addSrEmp(CurrentEmployee);
                LoadData();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void deleteSrEmp()
        {
            try
            {
                var IsSaved = employeeService.deleteSrEmp(CurrentEmployee);
                LoadData();
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void updateSrEmp()
        {
            try
            {
                var IsSaved = employeeService.updateSrEmp(CurrentEmployee);
                LoadData();
                MessageBox.Show("update");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        //test employee

        public void savedTEmp()
        {
            try
            {
                var IsSaved = employeeService.addTEmp(CurrentEmployee);
                LoadData();
                MessageBox.Show("Saved");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void deleteTEmp()
        {
            try
            {
                var IsSaved = employeeService.deleteTEmp(CurrentEmployee);
                LoadData();
                MessageBox.Show("Deleted");
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        public void updateTEmp()
        {
            try
            {
                var IsSaved = employeeService.updateTEmp(CurrentEmployee);
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
