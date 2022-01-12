using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaStead_V2._0_.Components.SmallCards
{
    public partial class Earning_UserControl : UserControl
    {
        public Earning_UserControl()
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

        private void gotToServices_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            goToServices_PictureBox.BackgroundImage = Properties.Resources.EarningAnalyticsButtonHover;
        }

        private void gotToServices_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            goToServices_PictureBox.BackgroundImage = Properties.Resources.EarningAnalyticsButton;
        }

        private void gotToServices_PictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
