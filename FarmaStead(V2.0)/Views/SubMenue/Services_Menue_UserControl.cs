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
    public partial class Services_Menue_UserControl : UserControl
    {
        public bool selected = false;
        private bool loan, stock, machinery, govt = false;

     

        public Services_Menue_UserControl()
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
       

        private void loan_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true) {
               
                 if (stock == true) { this.BackgroundImage = Properties.Resources.SSL; }
                else if (machinery == true) { this.BackgroundImage = Properties.Resources.SML; }
                else if (govt == true) { this.BackgroundImage = Properties.Resources.SGL; }
            }
            else
            {
                this.BackgroundImage = Properties.Resources.Services_HoverLoan;
            }
        }
        private void loan_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) { refresh(); }
            else
            {
                this.BackgroundImage = Properties.Resources.Services;
            }
        }
        private void stock_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true) {
                if (loan == true) { this.BackgroundImage = Properties.Resources.SLS; }
                else if (machinery == true) { this.BackgroundImage = Properties.Resources.SMS; }
                else if (govt == true) { this.BackgroundImage = Properties.Resources.SGS; }
            }
            else
            {
                this.BackgroundImage = Properties.Resources.Services_HoverStock;
            }
        }

        private void stock_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) { refresh(); }
            else
            {
                this.BackgroundImage = Properties.Resources.Services;
            }
        }

        private void machinery_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true) {
                if (loan == true) { this.BackgroundImage = Properties.Resources.SLM; }
                else if (stock == true) { this.BackgroundImage = Properties.Resources.SSM; }
                else if (govt == true) { this.BackgroundImage = Properties.Resources.SGM; }
            }
            else
            {
                this.BackgroundImage = Properties.Resources.Services_HoverMachinery;
            }
        }

      
        private void machinery_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) { refresh(); }
            else
            {
                this.BackgroundImage = Properties.Resources.Services;
            }
        }

     
        private void govt_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true) {
                if (loan == true) { this.BackgroundImage = Properties.Resources.SLG; }
                else if (stock == true) { this.BackgroundImage = Properties.Resources.SSG; }
                else if (machinery == true) { this.BackgroundImage = Properties.Resources.SMG; }
            }
            else
            {
                this.BackgroundImage = Properties.Resources.Services_HoverGovt;
            }
        }

        private void govt_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) { refresh(); }
            else
            {
                this.BackgroundImage = Properties.Resources.Services;
            }
        }
        private void loan_pictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Services_SelectedLoan;
            selected = true;
            loan = true;
            stock = false;
            machinery = false;
            govt = false;
        }
        private void stock_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Services_SelectedStock;
            selected = true;
            loan = false;
            stock = true;
            machinery = false;
            govt = false;
        }

        private void machinery_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Services_SelectedMachinery;
            selected = true;
            loan = false;
            stock = false;
            machinery = true;
            govt = false;
        }

        private void govt_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.Services_SelectedGovt;
            selected = true;
            loan = false;
            stock = false;
            machinery = false;
            govt = true;
        }

        private void refresh() {
            if (loan == true) { this.BackgroundImage = Properties.Resources.Services_SelectedLoan; }
            else if (stock == true) { this.BackgroundImage = Properties.Resources.Services_SelectedStock; }
            else if (machinery == true) { this.BackgroundImage = Properties.Resources.Services_SelectedMachinery; }
            else if (govt == true) { this.BackgroundImage = Properties.Resources.Services_SelectedGovt; }
        }

    }
}
