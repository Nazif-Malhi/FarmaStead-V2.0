
namespace FarmaStead_V2._0_.Components.SmallCards
{
    partial class Earning_UserControl
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
            this.goToServices_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.goToServices_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // goToServices_PictureBox
            // 
            this.goToServices_PictureBox.BackgroundImage = global::FarmaStead_V2._0_.Properties.Resources.EarningAnalyticsButton;
            this.goToServices_PictureBox.Location = new System.Drawing.Point(65, 214);
            this.goToServices_PictureBox.Name = "goToServices_PictureBox";
            this.goToServices_PictureBox.Size = new System.Drawing.Size(106, 27);
            this.goToServices_PictureBox.TabIndex = 0;
            this.goToServices_PictureBox.TabStop = false;
            this.goToServices_PictureBox.Click += new System.EventHandler(this.gotToServices_PictureBox_Click);
            this.goToServices_PictureBox.MouseEnter += new System.EventHandler(this.gotToServices_PictureBox_MouseEnter);
            this.goToServices_PictureBox.MouseLeave += new System.EventHandler(this.gotToServices_PictureBox_MouseLeave);
            // 
            // Earning_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::FarmaStead_V2._0_.Properties.Resources.Earning;
            this.Controls.Add(this.goToServices_PictureBox);
            this.DoubleBuffered = true;
            this.Name = "Earning_UserControl";
            this.Size = new System.Drawing.Size(252, 273);
            ((System.ComponentModel.ISupportInitialize)(this.goToServices_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox goToServices_PictureBox;
    }
}
