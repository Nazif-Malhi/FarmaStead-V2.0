
namespace FarmaStead_V2._0_.Views.ViewControllers
{
    partial class BaseDataGridView_UserControl
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.add_PictureBox = new System.Windows.Forms.PictureBox();
            this.update_PictureBox = new System.Windows.Forms.PictureBox();
            this.delete_PictureBox = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(1002, 567);
            this.dataGridView1.TabIndex = 0;
            // 
            // add_PictureBox
            // 
            this.add_PictureBox.BackgroundImage = global::FarmaStead_V2._0_.Properties.Resources.AddBtn;
            this.add_PictureBox.Location = new System.Drawing.Point(556, 7);
            this.add_PictureBox.Name = "add_PictureBox";
            this.add_PictureBox.Size = new System.Drawing.Size(103, 30);
            this.add_PictureBox.TabIndex = 1;
            this.add_PictureBox.TabStop = false;
            this.add_PictureBox.Click += new System.EventHandler(this.add_PictureBox_Click);
            this.add_PictureBox.MouseEnter += new System.EventHandler(this.add_PictureBox_MouseEnter);
            this.add_PictureBox.MouseLeave += new System.EventHandler(this.add_PictureBox_MouseLeave);
            // 
            // update_PictureBox
            // 
            this.update_PictureBox.BackgroundImage = global::FarmaStead_V2._0_.Properties.Resources.UpdateBtn;
            this.update_PictureBox.Location = new System.Drawing.Point(692, 7);
            this.update_PictureBox.Name = "update_PictureBox";
            this.update_PictureBox.Size = new System.Drawing.Size(103, 30);
            this.update_PictureBox.TabIndex = 2;
            this.update_PictureBox.TabStop = false;
            this.update_PictureBox.Click += new System.EventHandler(this.update_PictureBox_Click);
            this.update_PictureBox.MouseEnter += new System.EventHandler(this.update_PictureBox_MouseEnter);
            this.update_PictureBox.MouseLeave += new System.EventHandler(this.update_PictureBox_MouseLeave);
            // 
            // delete_PictureBox
            // 
            this.delete_PictureBox.BackgroundImage = global::FarmaStead_V2._0_.Properties.Resources.DeleteBtn;
            this.delete_PictureBox.Location = new System.Drawing.Point(832, 7);
            this.delete_PictureBox.Name = "delete_PictureBox";
            this.delete_PictureBox.Size = new System.Drawing.Size(103, 30);
            this.delete_PictureBox.TabIndex = 3;
            this.delete_PictureBox.TabStop = false;
            this.delete_PictureBox.Click += new System.EventHandler(this.delete_PictureBox_Click);
            this.delete_PictureBox.MouseEnter += new System.EventHandler(this.delete_PictureBox_MouseEnter);
            this.delete_PictureBox.MouseLeave += new System.EventHandler(this.delete_PictureBox_MouseLeave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 30);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // BaseDataGridView_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(51)))), ((int)(((byte)(81)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.delete_PictureBox);
            this.Controls.Add(this.update_PictureBox);
            this.Controls.Add(this.add_PictureBox);
            this.Controls.Add(this.dataGridView1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BaseDataGridView_UserControl";
            this.Size = new System.Drawing.Size(1008, 617);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.add_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.update_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.delete_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox add_PictureBox;
        private System.Windows.Forms.PictureBox update_PictureBox;
        private System.Windows.Forms.PictureBox delete_PictureBox;
        public System.Windows.Forms.Label label1;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}
