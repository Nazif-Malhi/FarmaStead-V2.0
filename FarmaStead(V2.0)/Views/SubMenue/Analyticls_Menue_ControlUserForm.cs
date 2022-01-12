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
    public partial class Analyticls_Menue_ControlUserForm : UserControl
    {
        public bool selected = false;
        private bool crop, seed, fertilizer, pesticides, spray, wether = false;
        public Analyticls_Menue_ControlUserForm()
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

        private void crop_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true)
            {
                if (seed == true)
                {
                    this.BackgroundImage = Properties.Resources.ASEEDC;
                }
                else if (fertilizer == true)
                {
                    this.BackgroundImage = Properties.Resources.AFC;
                }
                else if (pesticides == true) {
                    this.BackgroundImage = Properties.Resources.APC;
                }
                else if (spray == true) {
                    this.BackgroundImage = Properties.Resources.ASC;
                }
                else if (wether == true) {
                    this.BackgroundImage = Properties.Resources.AWC;
                }
            }
            else if (selected == false)
            {
                this.BackgroundImage = Properties.Resources.AnalyticsSelected_HoverCrop;
            }
            
        }

        private void crop_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) {
                refresh();
            }

            else if (selected == false)
            {
                this.BackgroundImage = Properties.Resources.AnalyticsUnSelected;
            }
            
        }

        private void seeds_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true) {
                if (crop == true)
                {
                    this.BackgroundImage = Properties.Resources.ACSEED;
                }
               
                else if (fertilizer == true)
                {
                    this.BackgroundImage = Properties.Resources.AFSEED;
                }
                else if (pesticides == true)
                {
                    this.BackgroundImage = Properties.Resources.APSEED;
                }
                else if (spray == true)
                {
                    this.BackgroundImage = Properties.Resources.ASSEED;
                }
                else if (wether == true)
                {
                    this.BackgroundImage = Properties.Resources.AWSEED;
                }
            }

            else if (selected == false)
            {
                this.BackgroundImage = Properties.Resources.AnalyticsSelected_HoverSeeds;
            }
            

        }

        private void seeds_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) {
                refresh();
            }
            else if (selected == false)
            {
                this.BackgroundImage = Properties.Resources.AnalyticsUnSelected;
            }
            
            
        }

        private void fertilizers_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true) {
                if (crop == true)
                {
                    this.BackgroundImage = Properties.Resources.ACF;
                }
               
                if (seed == true)
                {
                    this.BackgroundImage = Properties.Resources.ASEEDF;
                }
                
                else if (pesticides == true)
                {
                    this.BackgroundImage = Properties.Resources.APF;
                }
                else if (spray == true)
                {
                    this.BackgroundImage = Properties.Resources.ASF;
                }
                else if (wether == true)
                {
                    this.BackgroundImage = Properties.Resources.AWF;
                }
            }
            else if (selected == false)
            {
                this.BackgroundImage = Properties.Resources.AnalyticsSelected_HoverFertilizers;
            }
            

        }

        private void fertilizers_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) {
                refresh();
            }
            else if (selected == false)
            {
                this.BackgroundImage = Properties.Resources.AnalyticsUnSelected;
            }
            
        }

        private void pesticides_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true) {
                if (crop == true)
                {
                    this.BackgroundImage = Properties.Resources.ACP;
                }
               
                if (seed == true)
                {
                    this.BackgroundImage = Properties.Resources.ASEEDP;
                }
                else if (fertilizer == true)
                {
                    this.BackgroundImage = Properties.Resources.AFP;
                }
               
                else if (spray == true)
                {
                    this.BackgroundImage = Properties.Resources.ASP;
                }
                else if (wether == true)
                {
                    this.BackgroundImage = Properties.Resources.AWP;
                }
            }
            else if (selected == false)
            {
                this.BackgroundImage = Properties.Resources.AnalyticsSelected_HoverPesticides;
            }
            
        }

        private void pesticides_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true) {
                refresh();
            }
            else if (selected == false)
            {
                this.BackgroundImage = Properties.Resources.AnalyticsUnSelected;
            }
            
        }

        private void spray_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true)
            {
                if (crop == true)
                {
                    this.BackgroundImage = Properties.Resources.ACS;
                }
             
                if (seed == true)
                {
                    this.BackgroundImage = Properties.Resources.ASEEDS;
                }
                else if (fertilizer == true)
                {
                    this.BackgroundImage = Properties.Resources.AFS;
                }
                else if (pesticides == true)
                {
                    this.BackgroundImage = Properties.Resources.APS;
                }
                
                else if (wether == true)
                {
                    this.BackgroundImage = Properties.Resources.AWS;
                }
            }

            else if (selected == false)
            {
                this.BackgroundImage = Properties.Resources.AnalyticsSelected_HoverSprays;
            }
           
        }

        private void spray_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true)
            {
                refresh();
            }
            else if (selected == false)
            {
                this.BackgroundImage = Properties.Resources.AnalyticsUnSelected;
            }
           
        }

        private void weather_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selected == true) {
                if (crop == true)
                {
                    this.BackgroundImage = Properties.Resources.ACW;
                }
             
                if (seed == true)
                {
                    this.BackgroundImage = Properties.Resources.ASEEDW;
                }
                else if (fertilizer == true)
                {
                    this.BackgroundImage = Properties.Resources.AFW;
                }
                else if (pesticides == true)
                {
                    this.BackgroundImage = Properties.Resources.APW;
                }
                else if (spray == true)
                {
                    this.BackgroundImage = Properties.Resources.ASW;
                }
               
            }
            else if (selected == false)
            {
                this.BackgroundImage = Properties.Resources.AnalyticsSelected_HoverWeatherAffect;
            }
            
        }

        private void weather_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selected == true)
            {
                refresh();
            }
            else if (selected == false)
            {
                this.BackgroundImage = Properties.Resources.AnalyticsUnSelected;
            }
            
           
        }
        
        private void crop_PictureBox_Click(object sender, EventArgs e)
        {
            selected = true;
            this.BackgroundImage = Properties.Resources.AnalyticsSelected_Crop;
            crop = true;
            seed = false;
            fertilizer = false;
            pesticides = false;
            spray = false;
            wether = false;
        }
        private void seeds_pictureBox_Click(object sender, EventArgs e)
        {
            selected = true;
            this.BackgroundImage = Properties.Resources.AnalyticsSelected_Seeds;
            seed = true;
            crop = false;
            fertilizer = false;
            pesticides = false;
            spray = false;
            wether = false;
        }
        private void fertilizers_PictureBox_Click(object sender, EventArgs e)
        {
            selected = true;
            this.BackgroundImage = Properties.Resources.AnalyticsSelected_Fertilizers;
            fertilizer = true;
            seed = false;
            crop = false;
            pesticides = false;
            spray = false;
            wether = false;
        }
        private void pesticides_PictureBox_Click(object sender, EventArgs e)
        {
            selected = true;
            this.BackgroundImage = Properties.Resources.AnalyticsSelected_Pesticides;
            pesticides = true;
            seed = false;
            fertilizer = false;
            crop = false;
            spray = false;
            wether = false;
        }
        private void spray_PictureBox_Click(object sender, EventArgs e)
        {
            selected = true;
            this.BackgroundImage = Properties.Resources.AnalyticsSelected_Sprays;
            spray = true;
            seed = false;
            fertilizer = false;
            pesticides = false;
            crop = false;
            wether = false;
        }
        private void weather_PictureBox_Click(object sender, EventArgs e)
        {
            selected = true;
            this.BackgroundImage = Properties.Resources.AnalyticsSelected_WeatherAffect;
            wether = true;
            seed = false;
            fertilizer = false;
            pesticides = false;
            spray = false;
            crop = false;
        }

     
        private void refresh() {
            if (crop == true)
            {
                this.BackgroundImage = Properties.Resources.AnalyticsSelected_Crop;
            }
            if (seed == true)
            {
                this.BackgroundImage = Properties.Resources.AnalyticsSelected_Seeds;
            }
            else if (fertilizer == true)
            {
                this.BackgroundImage = Properties.Resources.AnalyticsSelected_Fertilizers;
            }
            else if (pesticides == true)
            {
                this.BackgroundImage = Properties.Resources.AnalyticsSelected_Pesticides;
            }
            else if (spray == true)
            {
                this.BackgroundImage = Properties.Resources.AnalyticsSelected_Sprays;
            }
            else if (wether == true)
            {
                this.BackgroundImage = Properties.Resources.AnalyticsSelected_WeatherAffect;
            }
        }
    }
}
