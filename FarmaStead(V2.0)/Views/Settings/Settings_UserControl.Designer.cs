
namespace FarmaStead_V2._0_.Views.Settings
{
    partial class Settings_UserControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label5 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.EmployeeIDGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeNameGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addressGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phoneGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.salaryGV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delete_PictureBox = new System.Windows.Forms.PictureBox();
            this.update_PictureBox = new System.Windows.Forms.PictureBox();
            this.add_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(8, 12);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 30);
            this.label5.TabIndex = 14;
            this.label5.Text = "label5";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EmployeeIDGV,
            this.employeeNameGV,
            this.addressGV,
            this.phoneGV,
            this.salaryGV});
            this.dataGridView1.Location = new System.Drawing.Point(13, 57);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(671, 506);
            this.dataGridView1.TabIndex = 18;
            this.dataGridView1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellClick);
            // 
            // EmployeeIDGV
            // 
            this.EmployeeIDGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.ColumnHeader;
            this.EmployeeIDGV.HeaderText = "Employee ID";
            this.EmployeeIDGV.Name = "EmployeeIDGV";
            this.EmployeeIDGV.ReadOnly = true;
            this.EmployeeIDGV.Visible = false;
            // 
            // employeeNameGV
            // 
            this.employeeNameGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.employeeNameGV.HeaderText = "Employee Name";
            this.employeeNameGV.Name = "employeeNameGV";
            this.employeeNameGV.ReadOnly = true;
            // 
            // addressGV
            // 
            this.addressGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.addressGV.HeaderText = "Address";
            this.addressGV.Name = "addressGV";
            this.addressGV.ReadOnly = true;
            // 
            // phoneGV
            // 
            this.phoneGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.phoneGV.HeaderText = "Phone";
            this.phoneGV.Name = "phoneGV";
            this.phoneGV.ReadOnly = true;
            // 
            // salaryGV
            // 
            this.salaryGV.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.salaryGV.HeaderText = "Salary";
            this.salaryGV.Name = "salaryGV";
            this.salaryGV.ReadOnly = true;
            // 
            // delete_PictureBox
            // 
            this.delete_PictureBox.BackgroundImage = global::FarmaStead_V2._0_.Properties.Resources.DeleteBtn;
            this.delete_PictureBox.Location = new System.Drawing.Point(581, 12);
            this.delete_PictureBox.Name = "delete_PictureBox";
            this.delete_PictureBox.Size = new System.Drawing.Size(103, 30);
            this.delete_PictureBox.TabIndex = 17;
            this.delete_PictureBox.TabStop = false;
            this.delete_PictureBox.Click += new System.EventHandler(this.delete_PictureBox_Click);
            this.delete_PictureBox.MouseEnter += new System.EventHandler(this.delete_PictureBox_MouseEnter);
            this.delete_PictureBox.MouseLeave += new System.EventHandler(this.delete_PictureBox_MouseLeave);
            // 
            // update_PictureBox
            // 
            this.update_PictureBox.BackgroundImage = global::FarmaStead_V2._0_.Properties.Resources.UpdateBtn;
            this.update_PictureBox.Location = new System.Drawing.Point(441, 12);
            this.update_PictureBox.Name = "update_PictureBox";
            this.update_PictureBox.Size = new System.Drawing.Size(103, 30);
            this.update_PictureBox.TabIndex = 16;
            this.update_PictureBox.TabStop = false;
            this.update_PictureBox.Click += new System.EventHandler(this.update_PictureBox_Click);
            this.update_PictureBox.MouseEnter += new System.EventHandler(this.update_PictureBox_MouseEnter);
            this.update_PictureBox.MouseLeave += new System.EventHandler(this.update_PictureBox_MouseLeave);
            // 
            // add_PictureBox
            // 
            this.add_PictureBox.BackgroundImage = global::FarmaStead_V2._0_.Properties.Resources.AddBtn;
            this.add_PictureBox.Location = new System.Drawing.Point(305, 12);
            this.add_PictureBox.Name = "add_PictureBox";
            this.add_PictureBox.Size = new System.Drawing.Size(103, 30);
            this.add_PictureBox.TabIndex = 15;
            this.add_PictureBox.TabStop = false;
            this.add_PictureBox.Click += new System.EventHandler(this.add_PictureBox_Click);
            this.add_PictureBox.MouseEnter += new System.EventHandler(this.add_PictureBox_MouseEnter);
            this.add_PictureBox.MouseLeave += new System.EventHandler(this.add_PictureBox_MouseLeave);
            // 
            // Settings_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.delete_PictureBox);
            this.Controls.Add(this.update_PictureBox);
            this.Controls.Add(this.add_PictureBox);
            this.Controls.Add(this.label5);
            this.Name = "Settings_UserControl";
            this.Size = new System.Drawing.Size(693, 658);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox delete_PictureBox;
        private System.Windows.Forms.PictureBox update_PictureBox;
        private System.Windows.Forms.PictureBox add_PictureBox;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn EmployeeIDGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn employeeNameGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn addressGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn phoneGV;
        private System.Windows.Forms.DataGridViewTextBoxColumn salaryGV;
    }
}
