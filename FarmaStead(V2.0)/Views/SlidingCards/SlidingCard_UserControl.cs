using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaStead_V2._0_.Components.SlidingCards
{
    public partial class SlidingCard_UserControl : UserControl
    {


        private Image[] image = {
        Properties.Resources.PlayCardAgri,
        Properties.Resources.PlayCardServices,
        Properties.Resources.PlayCardStock,
        Properties.Resources.PlayCardTesting,
        Properties.Resources.PlayCardWallet
        };
        private int i = 0;
        public SlidingCard_UserControl()
        {
            InitializeComponent();
            sliding_Timer.Start();
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


        private void loadingImage() {
            if (i == 4) {
                i = 0;
            }
            this.BackgroundImage = image[i];
            i++;
        }
        private void sliding_Timer_Tick(object sender, EventArgs e)
        {
            loadingImage();
        }

        private void Click_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            sliding_Timer.Stop();
        }

        private void Click_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            sliding_Timer.Start();
        }

        private void Click_PictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
