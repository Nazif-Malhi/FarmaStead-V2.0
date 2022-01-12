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
    public partial class StockManagment_UserControl : UserControl
    {
        public bool selected = false;
        
        public StockManagment_UserControl()
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
        private bool warehouse, seeds, fertilizers, pesticides, moneyAssets, machinery, cropStock;
        private void wareHouse_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true)
            {
                 if (seeds == true) { this.BackgroundImage = Properties.Resources.SSW; }
                else if (fertilizers == true) { this.BackgroundImage = Properties.Resources.SFW; }
                else if (pesticides == true) { this.BackgroundImage = Properties.Resources.SPW; }
                else if (moneyAssets == true) { this.BackgroundImage = Properties.Resources.SMAW; }
                else if (machinery == true) { this.BackgroundImage = Properties.Resources.SMW; }
                else if (cropStock == true) { this.BackgroundImage = Properties.Resources.SCW; }
            }
            else {
                this.BackgroundImage = Properties.Resources.StockManagment__HoverWareHouses;
            }
        }

        private void wareHouse_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) { refresh(); }
            else
            {
                this.BackgroundImage = Properties.Resources.StockManagment;
            }
        }

        private void seeds_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true)
            {
                if (warehouse == true) { this.BackgroundImage = Properties.Resources.SWS; }
                else if (fertilizers == true) { this.BackgroundImage = Properties.Resources.SFS; }
                else if (pesticides == true) { this.BackgroundImage = Properties.Resources.SPS; }
                else if (moneyAssets == true) { this.BackgroundImage = Properties.Resources.SMAS; }
                else if (machinery == true) { this.BackgroundImage = Properties.Resources.StockMS; }
                else if (cropStock == true) { this.BackgroundImage = Properties.Resources.SCS; }
            }
            else
            {
                this.BackgroundImage = Properties.Resources.StockManagment_HoverSeeds;
            }
        }

        private void seeds_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) { refresh(); }
            else
            {
                this.BackgroundImage = Properties.Resources.StockManagment;
            }
        }

        private void fertilizers_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true)
            {
                if (warehouse == true) { this.BackgroundImage = Properties.Resources.SWF; }
                else if (seeds == true) { this.BackgroundImage = Properties.Resources.SSF; }
                else if (pesticides == true) { this.BackgroundImage = Properties.Resources.SPF; }
                else if (moneyAssets == true) { this.BackgroundImage = Properties.Resources.SMAF; }
                else if (machinery == true) { this.BackgroundImage = Properties.Resources.SMF; }
                else if (cropStock == true) { this.BackgroundImage = Properties.Resources.SCF; }
            }
            else
            {
                this.BackgroundImage = Properties.Resources.StockManagment_HoverFerilizers;
            }
        }

        private void fertilizers_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) { refresh(); }
            else
            {
                this.BackgroundImage = Properties.Resources.StockManagment;
            }
        }

        private void pesticides_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true)
            {
                if (warehouse == true) { this.BackgroundImage = Properties.Resources.SWP; }
                else if (seeds == true) { this.BackgroundImage = Properties.Resources.SSP; }
                else if (fertilizers == true) { this.BackgroundImage = Properties.Resources.SFP; }
                else if (moneyAssets == true) { this.BackgroundImage = Properties.Resources.SMAP; }
                else if (machinery == true) { this.BackgroundImage = Properties.Resources.SMP; }
                else if (cropStock == true) { this.BackgroundImage = Properties.Resources.SCP; }
            }
            else
            {
                this.BackgroundImage = Properties.Resources.StockManagment_HoverPesticides;
            }
        }

        private void pesticides_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) { refresh(); }
            else
            {
                this.BackgroundImage = Properties.Resources.StockManagment;
            }
        }

        private void money_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true)
            {
                if (warehouse == true) { this.BackgroundImage = Properties.Resources.SWMA; }
                else if (seeds == true) { this.BackgroundImage = Properties.Resources.SSMA; }
                else if (fertilizers == true) { this.BackgroundImage = Properties.Resources.SFMA; }
                else if (pesticides == true) { this.BackgroundImage = Properties.Resources.SPMA; }
                else if (machinery == true) { this.BackgroundImage = Properties.Resources.SMMA; }
                else if (cropStock == true) { this.BackgroundImage = Properties.Resources.SCMA; }
            }
            else
            {
                this.BackgroundImage = Properties.Resources.StockManagment_HoverMoneyAssets;
            }
        }

        private void money_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) { refresh(); }
            else
            {
                this.BackgroundImage = Properties.Resources.StockManagment;
            }
        }

        private void machinery_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true)
            {
                if (warehouse == true) { this.BackgroundImage = Properties.Resources.SWM; }
                else if (seeds == true) { this.BackgroundImage = Properties.Resources.StockSM; }
                else if (fertilizers == true) { this.BackgroundImage = Properties.Resources.SFM; }
                else if (pesticides == true) { this.BackgroundImage = Properties.Resources.SPM; }
                else if (moneyAssets == true) { this.BackgroundImage = Properties.Resources.SMAM; }
                else if (cropStock == true) { this.BackgroundImage = Properties.Resources.SCM; }
            }
            else
            {
                this.BackgroundImage = Properties.Resources.StockManagment_HoverMachinery;
            }
        }

        private void machinery_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) { refresh(); }
            else
            {
                this.BackgroundImage = Properties.Resources.StockManagment;
            }
        }

        private void cropstock_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true)
            {
                if (warehouse == true) { this.BackgroundImage = Properties.Resources.SWC; }
                else if (seeds == true) { this.BackgroundImage = Properties.Resources.SSC; }
                else if (fertilizers == true) { this.BackgroundImage = Properties.Resources.SFC; }
                else if (pesticides == true) { this.BackgroundImage = Properties.Resources.SPC; }
                else if (moneyAssets == true) { this.BackgroundImage = Properties.Resources.SMAC; }
                else if (machinery == true) { this.BackgroundImage = Properties.Resources.SMC; }
            }
            else
            {
                this.BackgroundImage = Properties.Resources.StockManagment_HoverCropStock;
            }
        }

        private void cropstock_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) { refresh(); }
            else
            {
                this.BackgroundImage = Properties.Resources.StockManagment;
            }
        }
        private void wareHouse_pictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.StockManagment__HoverWareHouses;
            selected = true;
            warehouse = true;
            seeds = false;
            fertilizers = false;
            pesticides = false;
            moneyAssets = false;
            machinery = false;
            cropStock = false;
        }

        private void seeds_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.StockManagment_SelectedSeeds;
            selected = true;
            warehouse = false;
            seeds = true;
            fertilizers = false;
            pesticides = false;
            moneyAssets = false;
            machinery = false;
            cropStock = false;
        }

        private void fertilizers_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.StockManagment_SelectedFerilizers;
            selected = true;
            warehouse = false;
            seeds = false;
            fertilizers = true;
            pesticides = false;
            moneyAssets = false;
            machinery = false;
            cropStock = false;
        }

        private void pesticides_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.StockManagment_SelectedPesticides;
            selected = true;
            warehouse = false;
            seeds = false;
            fertilizers = false;
            pesticides = true;
            moneyAssets = false;
            machinery = false;
            cropStock = false;
        }

        private void money_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.StockManagment_SelectedMoneyAssets;
            selected = true;
            warehouse = false;
            seeds = false;
            fertilizers = false;
            pesticides = false;
            moneyAssets = true;
            machinery = false;
            cropStock = false;
        }

        private void machinery_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.StockManagment_SelectedMachinery;
            selected = true;
            warehouse = false;
            seeds = false;
            fertilizers = false;
            pesticides = false;
            moneyAssets = false;
            machinery = true;
            cropStock = false;
        }

        private void cropstock_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.StockManagment_SelectedCropStock;
            selected = true;
            warehouse = false;
            seeds = false;
            fertilizers = false;
            pesticides = false;
            moneyAssets = false;
            machinery = false;
            cropStock = true;
        }


        private void refresh() {
           
                if (warehouse == true) { this.BackgroundImage = Properties.Resources.StockManagment__SelectedWareHouses; }
                else if (seeds == true) { this.BackgroundImage = Properties.Resources.StockManagment_SelectedSeeds; }
                else if (fertilizers == true) { this.BackgroundImage = Properties.Resources.StockManagment_SelectedFerilizers; }
                else if (pesticides == true) { this.BackgroundImage = Properties.Resources.StockManagment_SelectedPesticides; }
                else if (moneyAssets == true) { this.BackgroundImage = Properties.Resources.StockManagment_SelectedMoneyAssets; }
                else if (machinery == true) { this.BackgroundImage = Properties.Resources.StockManagment_SelectedMachinery; }
                else if (cropStock == true) { this.BackgroundImage = Properties.Resources.StockManagment_SelectedCropStock; }
           
        }
    }
}
