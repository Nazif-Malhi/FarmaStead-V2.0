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
    public partial class EarningThisMonth_UserControl : UserControl
    {
        public EarningThisMonth_UserControl()
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

        private void statment_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            statment_PictureBox.BackgroundImage = Properties.Resources.StatementButtonsHover;
        }

        private void statment_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            statment_PictureBox.BackgroundImage = Properties.Resources.StatementButtons;
        }

        private void statment_PictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
