using FarmaStead_V2._0_.Commands;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FarmaStead_V2._0_.Views.Settings
{
    public partial class Settings_ServerIntegration_Extension_UserControl : UserControl
    {
        private string connection;
        public Settings_ServerIntegration_Extension_UserControl()
        {
            InitializeComponent();
        }

        private void save_Button_Click(object sender, EventArgs e)
        {
            if (security_CheckBox.Checked)
            {
                if (serverName_TextBox.Text == "" && database_TextBox.Text == "")
                {
                    MessageBox.Show("Please fill the both feilds");
                }
                else
                {
                    connection = "Data Source=" + serverName_TextBox.Text + ";Initial Catalog=" + database_TextBox.Text + ";Integrated Security=true;MultipleActiveResultSets= true;";

                    saveConnection();
                }
            }
            else
            {
                if (Restriction.checkControls(this).Count > 0)
                {
                    MessageBox.Show("All feilds are mandotory");
                }
                else
                {

                    connection = "Data Source=" + serverName_TextBox.Text +
                               ";Initial Catalog=" + database_TextBox.Text +
                               ";User ID=" + userID_TextBox.Text +
                               ";Password=" + password_TextBox.Text +
                               ";MultipleActiveResultSets= true;";
                    saveConnection();
                }

            }
        }

        private void security_CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (security_CheckBox.Checked)
            {

                userID_TextBox.Enabled = false;
                password_TextBox.Enabled = false;
                userID_TextBox.Text = "";
                password_TextBox.Text = "";
            }
            else
            {
                userID_TextBox.Enabled = true;
                password_TextBox.Enabled = true;
            }
        }
        public void saveConnection()
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\FarmaStead_db_conc";
            File.WriteAllText(path, connection);
            MessageBox.Show("Server Settings are saved");
        }

    }
}
