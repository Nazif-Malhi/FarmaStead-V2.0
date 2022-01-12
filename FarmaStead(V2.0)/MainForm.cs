using FarmaStead_V2._0_.Views.Settings;
using FarmaStead_V2._0_.Views.ViewControllers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaStead_V2._0_
{
    public partial class MainForm : Form
    {
        private bool selectedUnderProcess = false;
        private PictureBox animated_PictureBox;
        private int top_animatedPictureBox = 125, dock_animatedPictureBox = 146;
        private Point loc_animPictBox;
        public MainForm()
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

        private void agricultureAnalytics_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selectedUnderProcess == true) return;
            this.BackgroundImage = Properties.Resources.MainBackground_Agriculture;
        }

        private void agricultureAnalytics_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selectedUnderProcess == true) return;
            this.BackgroundImage = Properties.Resources.MainBackground;
        }

        private void stockManagment_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selectedUnderProcess == true) return;
            this.BackgroundImage = Properties.Resources.MainBackground_StockManagment;
        }

        private void stockManagment_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selectedUnderProcess == true) return;
            this.BackgroundImage = Properties.Resources.MainBackground;
        }

        private void wallet_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selectedUnderProcess == true) return;
            this.BackgroundImage = Properties.Resources.MainBackground_Wallet;
        }

        private void wallet_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selectedUnderProcess == true) return;
            this.BackgroundImage = Properties.Resources.MainBackground;
        }

        private void testing_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selectedUnderProcess == true) return;
            this.BackgroundImage = Properties.Resources.MainBackground_Testing;
        }

        private void testing_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selectedUnderProcess == true) return;
            this.BackgroundImage = Properties.Resources.MainBackground;
        }

        private void services_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            if (selectedUnderProcess == true) return;
            this.BackgroundImage = Properties.Resources.MainBackground_service;
        }

        private void services_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            if (selectedUnderProcess == true) return;
            this.BackgroundImage = Properties.Resources.MainBackground;
        }










        private void agricultureAnalytics_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.SelectedUnderProcess;
            selectedUnderProcess = true;
            
            agricultureAnalytics_PictureBox.BackgroundImage = Properties.Resources.Selected_AgricultureAnalytics;
            animated_PictureBox = agricultureAnalytics_PictureBox;
            loc_animPictBox = agricultureAnalytics_PictureBox.Location;
            animated_PictureBox.Location = new Point(12, 146);
            btnAnimationTimer.Start();
            analyticls_Menue_ControlUserForm1.Visible = true;
            analyticls_Menue_ControlUserForm1.BringToFront();

        }

        private void stockManagment_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.SelectedUnderProcess;
            selectedUnderProcess = true;
            stockManagment_PictureBox.BackgroundImage = Properties.Resources.Selected_StockManagment;
            animated_PictureBox = stockManagment_PictureBox;
            animated_PictureBox.Location = new Point(12, 146);
            btnAnimationTimer.Start();
            stockManagment_UserControl1.Visible = true;
            stockManagment_UserControl1.BringToFront();
        }

        private void wallet_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.SelectedUnderProcess;
            selectedUnderProcess = true;
            wallet_PictureBox.BackgroundImage = Properties.Resources.Selected_Wallet;
            animated_PictureBox = wallet_PictureBox;
            animated_PictureBox.Location = new Point(12, 146);
            btnAnimationTimer.Start();
            wallet_UserControl1.Visible = true;
            wallet_UserControl1.BringToFront();
        }

        private void testing_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.SelectedUnderProcess;
            selectedUnderProcess = true;
            testing_PictureBox.BackgroundImage = Properties.Resources.Selected_Testing;
            animated_PictureBox = testing_PictureBox;
            animated_PictureBox.Location = new Point(12, 146);
            btnAnimationTimer.Start();

        }

        private void services_PictureBox_Click(object sender, EventArgs e)
        {
            this.BackgroundImage = Properties.Resources.SelectedUnderProcess;
            selectedUnderProcess = true;
            services_PictureBox.BackgroundImage = Properties.Resources.Selected_Services;
            animated_PictureBox = services_PictureBox;
            animated_PictureBox.Location = new Point(12, 146);
            btnAnimationTimer.Start();
            services_Menue_UserControl1.Visible = true;
            services_Menue_UserControl1.BringToFront();
        }




        private void backBtn_PictureBox_Click(object sender, EventArgs e)
        {
            selectedUnderProcess = false;
            this.BackgroundImage = Properties.Resources.MainBackground;
            btnAnimationTimer.Start();
            agricultureAnalytics_PictureBox.Location = loc_animPictBox;
            analyticls_Menue_ControlUserForm1.Visible = false;
            analyticls_Menue_ControlUserForm1.selected = false;
            services_Menue_UserControl1.Visible = false;
            services_Menue_UserControl1.selected = false;
            stockManagment_UserControl1.Visible = false;
            stockManagment_UserControl1.selected = false;
            wallet_UserControl1.Visible = false;
            wallet_UserControl1.selected = false;
            
        }


        private void setting_PictureBox_Click(object sender, EventArgs e)
        {
            
            Settings_UserControl settings_UserControl = new Settings_UserControl();
            Settings_ServerIntegration_Extension_UserControl settings_ServerIntegration_Extension_UserControl = new Settings_ServerIntegration_Extension_UserControl();

            this.Controls.Add(settings_UserControl);
            this.Controls.Add(settings_ServerIntegration_Extension_UserControl);
            settings_UserControl.Location = new Point(232, 72);
            settings_ServerIntegration_Extension_UserControl.Location = new Point(982, 97);

            settings_UserControl.BringToFront();
            settings_ServerIntegration_Extension_UserControl.BringToFront();
        }

        private void close_PictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

       
        private void btnAnimationTimer_Tick(object sender, EventArgs e)
        {
            if (selectedUnderProcess == true)
            {
                if (animated_PictureBox.Top >= top_animatedPictureBox)
                {
                    animated_PictureBox.Top -= 5;
                }
                else
                {
                    btnAnimationTimer.Stop();
                }
            }
            else
            {
                if (animated_PictureBox.Top <= dock_animatedPictureBox)
                {
                    animated_PictureBox.Top += 5;
                }
                else
                {
                    btnAnimationTimer.Stop();
                    refreshPictureBox();
                }
            }
        }

       
        private void refreshPictureBox() {
            agricultureAnalytics_PictureBox.BackgroundImage = null;
            agricultureAnalytics_PictureBox.Location = new Point(12, 146);
            stockManagment_PictureBox.BackgroundImage = null;
            stockManagment_PictureBox.Location = new Point(12, 197);
            wallet_PictureBox.BackgroundImage = null;
            wallet_PictureBox.Location = new Point(12, 249);
            testing_PictureBox.BackgroundImage = null;
            testing_PictureBox.Location = new Point(12, 300);
            services_PictureBox.BackgroundImage = null;
            services_PictureBox.Location = new Point(12, 352);
        }
    }
}
