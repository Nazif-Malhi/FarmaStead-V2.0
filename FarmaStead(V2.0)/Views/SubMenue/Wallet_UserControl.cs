using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaStead_V2._0_.Components.SubMenue
{
    public partial class Wallet_UserControl : UserControl
    {
        public bool selected = false;
        private bool loan, bill, balance, maintance;
        public Wallet_UserControl()
        {
            InitializeComponent();
        }
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams handleParam = base.CreateParams;
                handleParam.ExStyle |= 0x02000000;   // WS_EX_COMPOSITED       
                return handleParam;
            }
        }
        private void loan_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true)
            {

                
                 if (bill == true) { this.BackgroundImage = Properties.Resources.WBL; }
                else if (balance == true) { this.BackgroundImage = Properties.Resources.WBAL; }
                else if (maintance == true) { this.BackgroundImage = Properties.Resources.WML; }
            }
            else
            {
                this.BackgroundImage = Properties.Resources.Wallet__HoverLoan;
            }
        }

        private void loan_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) { refresh(); }
            else
            {
                this.BackgroundImage = Properties.Resources.Wallet;
            }
        }

        private void Bills_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true)
            {

                if (loan == true) { this.BackgroundImage = Properties.Resources.WLB; }
                else if (balance == true) { this.BackgroundImage = Properties.Resources.WBAB; }
                else if (maintance == true) { this.BackgroundImage = Properties.Resources.WMB; }
            }
            else
            {
                this.BackgroundImage = Properties.Resources.Wallet__HoverBills;
            }
        }

        private void Bills_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) { refresh(); }
            else
            {
                this.BackgroundImage = Properties.Resources.Wallet;
            }
        }

        private void balance_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true)
            {

                if (loan == true) { this.BackgroundImage = Properties.Resources.WLBA; }
                else if (bill == true) { this.BackgroundImage = Properties.Resources.WBBA; }
                else if (maintance == true) { this.BackgroundImage = Properties.Resources.WMBA; }
            }
            else
            {
                this.BackgroundImage = Properties.Resources.Wallet__HoverBalance;
            }
        }
        private void balance_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) { refresh(); }
            else
            {
                this.BackgroundImage = Properties.Resources.Wallet;
            }
        }
        private void maiant_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true)
            {

                if (loan == true) { this.BackgroundImage = Properties.Resources.WLM; }
                else if (bill == true) { this.BackgroundImage = Properties.Resources.WBM; }
                else if (balance == true) { this.BackgroundImage = Properties.Resources.WBAM; }
            }
            else
            {
                this.BackgroundImage = Properties.Resources.Wallet__HoverMaintainceCost;
            }
        }

        private void maiant_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) { refresh(); }
            else
            {
                this.BackgroundImage = Properties.Resources.Wallet;
            }
        }

        private void loan_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Wallet__SelectedLoan;
            selected = true;
            loan = true;
            bill = false;
            balance = false;
            maintance = false;
        }

        private void Bills_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Wallet__SelectedBills;
            selected = true;
            loan = false;
            bill = true;
            balance = false;
            maintance = false;
        }

        

        private void balance_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Wallet__SelectedBalance;
            selected = true;
            loan = false;
            bill = false;
            balance = true;
            maintance = false;
        }
       
        private void maiant_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Wallet__SelectedMaintananceCost;
            selected = true;
            loan = false;
            bill = false;
            balance = false;
            maintance = true;
        }
        private void refresh() {
            if (loan == true) { this.BackgroundImage = Properties.Resources.Wallet__SelectedLoan; }
            else if (bill == true) { this.BackgroundImage = Properties.Resources.Wallet__SelectedBills; }
            else if (balance == true) { this.BackgroundImage = Properties.Resources.Wallet__SelectedBalance; }
            else if (maintance == true) { this.BackgroundImage = Properties.Resources.Wallet__SelectedMaintananceCost; }
        }
    }
}
