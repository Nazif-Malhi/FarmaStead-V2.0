
namespace FarmaStead_V2._0_.Components.SubMenue
{
    partial class Wallet_UserControl
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
            this.loan_PictureBox = new System.Windows.Forms.PictureBox();
            this.Bills_PictureBox = new System.Windows.Forms.PictureBox();
            this.maiant_PictureBox = new System.Windows.Forms.PictureBox();
            this.balance_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.loan_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bills_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.maiant_PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // loan_PictureBox
            // 
            this.loan_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.loan_PictureBox.Location = new System.Drawing.Point(58, 47);
            this.loan_PictureBox.Name = "loan_PictureBox";
            this.loan_PictureBox.Size = new System.Drawing.Size(100, 35);
            this.loan_PictureBox.TabIndex = 1;
            this.loan_PictureBox.TabStop = false;
            this.loan_PictureBox.Click += new System.EventHandler(this.loan_PictureBox_Click);
            this.loan_PictureBox.MouseEnter += new System.EventHandler(this.loan_PictureBox_MouseEnter);
            this.loan_PictureBox.MouseLeave += new System.EventHandler(this.loan_PictureBox_MouseLeave);
            // 
            // Bills_PictureBox
            // 
            this.Bills_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.Bills_PictureBox.Location = new System.Drawing.Point(52, 92);
            this.Bills_PictureBox.Name = "Bills_PictureBox";
            this.Bills_PictureBox.Size = new System.Drawing.Size(110, 35);
            this.Bills_PictureBox.TabIndex = 2;
            this.Bills_PictureBox.TabStop = false;
            this.Bills_PictureBox.Click += new System.EventHandler(this.Bills_PictureBox_Click);
            this.Bills_PictureBox.MouseEnter += new System.EventHandler(this.Bills_PictureBox_MouseEnter);
            this.Bills_PictureBox.MouseLeave += new System.EventHandler(this.Bills_PictureBox_MouseLeave);
            // 
            // maiant_PictureBox
            // 
            this.maiant_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.maiant_PictureBox.Location = new System.Drawing.Point(39, 180);
            this.maiant_PictureBox.Name = "maiant_PictureBox";
            this.maiant_PictureBox.Size = new System.Drawing.Size(137, 35);
            this.maiant_PictureBox.TabIndex = 4;
            this.maiant_PictureBox.TabStop = false;
            this.maiant_PictureBox.Click += new System.EventHandler(this.maiant_PictureBox_Click);
            this.maiant_PictureBox.MouseEnter += new System.EventHandler(this.maiant_PictureBox_MouseEnter);
            this.maiant_PictureBox.MouseLeave += new System.EventHandler(this.maiant_PictureBox_MouseLeave);
            // 
            // balance_PictureBox
            // 
            this.balance_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.balance_PictureBox.Location = new System.Drawing.Point(44, 135);
            this.balance_PictureBox.Name = "balance_PictureBox";
            this.balance_PictureBox.Size = new System.Drawing.Size(127, 35);
            this.balance_PictureBox.TabIndex = 3;
            this.balance_PictureBox.TabStop = false;
            this.balance_PictureBox.Click += new System.EventHandler(this.balance_PictureBox_Click);
            this.balance_PictureBox.MouseEnter += new System.EventHandler(this.balance_PictureBox_MouseEnter);
            this.balance_PictureBox.MouseLeave += new System.EventHandler(this.balance_PictureBox_MouseLeave);
            // 
            // Wallet_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FarmaStead_V2._0_.Properties.Resources.Wallet;
            this.Controls.Add(this.maiant_PictureBox);
            this.Controls.Add(this.balance_PictureBox);
            this.Controls.Add(this.Bills_PictureBox);
            this.Controls.Add(this.loan_PictureBox);
            this.DoubleBuffered = true;
            this.Name = "Wallet_UserControl";
            this.Size = new System.Drawing.Size(214, 283);
            ((System.ComponentModel.ISupportInitialize)(this.loan_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bills_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.maiant_PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.balance_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox loan_PictureBox;
        private System.Windows.Forms.PictureBox Bills_PictureBox;
        private System.Windows.Forms.PictureBox maiant_PictureBox;
        private System.Windows.Forms.PictureBox balance_PictureBox;
    }
}
