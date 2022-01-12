
using FarmaStead_V2._0_.Commands;
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
    public partial class SplashScreen : Form
    {
        private int timerVariable = 0;
        public SplashScreen()
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
        private void splashScreenTimer_Tick(object sender, EventArgs e)
        {
            timerVariable++;
            if (timerVariable > 99)
            {
                
                this.splashScreenTimer.Stop();
                IsStableConnection();
            }
        }

        private void IsStableConnection() {
            try
            {
                Connection connection = new Connection();
                if (connection.IsConnection) showingPanel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }
        private void showingPanel()
        {
            this.Hide();
            Log_In log_In = new Log_In();
            log_In.ShowDialog();
        }

    }
}
