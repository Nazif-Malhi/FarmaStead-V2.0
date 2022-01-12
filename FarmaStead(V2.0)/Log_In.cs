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
    public partial class Log_In : Form
    {
        public Log_In()
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
        private void LogIn_pictureBox_MouseEnter(object sender, EventArgs e)
        {
            LogIn_pictureBox.BackgroundImage = Properties.Resources.LogInBtnHover;
        }

        private void LogIn_pictureBox_MouseLeave(object sender, EventArgs e)
        {
            LogIn_pictureBox.BackgroundImage = Properties.Resources.LogInBtn;
        }

        private void Cancel_PictureBox_MouseEnter(object sender, EventArgs e)
        {
            Cancel_PictureBox.BackgroundImage = Properties.Resources.CancelBtnHover;
        }

        private void Cancel_PictureBox_MouseLeave(object sender, EventArgs e)
        {
            Cancel_PictureBox.BackgroundImage = Properties.Resources.CancelBtn;
        }

        private void LogIn_pictureBox_Click(object sender, EventArgs e)
        {
            MainForm mainForm = new MainForm();
            this.Hide();
            mainForm.Show();
        }

        private void Cancel_PictureBox_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
