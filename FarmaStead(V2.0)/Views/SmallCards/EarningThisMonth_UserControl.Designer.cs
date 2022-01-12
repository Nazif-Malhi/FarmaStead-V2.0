
namespace FarmaStead_V2._0_.Components.SmallCards
{
    partial class EarningThisMonth_UserControl
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
            this.statment_PictureBox = new System.Windows.Forms.PictureBox();
            this.earning_Label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.statment_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // statment_PictureBox
            // 
            this.statment_PictureBox.BackColor = System.Drawing.Color.Transparent;
            this.statment_PictureBox.BackgroundImage = global::FarmaStead_V2._0_.Properties.Resources.StatementButtons;
            this.statment_PictureBox.Location = new System.Drawing.Point(62, 216);
            this.statment_PictureBox.Name = "statment_PictureBox";
            this.statment_PictureBox.Size = new System.Drawing.Size(106, 27);
            this.statment_PictureBox.TabIndex = 0;
            this.statment_PictureBox.TabStop = false;
            this.statment_PictureBox.Click += new System.EventHandler(this.statment_PictureBox_Click);
            this.statment_PictureBox.MouseEnter += new System.EventHandler(this.statment_PictureBox_MouseEnter);
            this.statment_PictureBox.MouseLeave += new System.EventHandler(this.statment_PictureBox_MouseLeave);
            // 
            // earning_Label
            // 
            this.earning_Label.AutoSize = true;
            this.earning_Label.BackColor = System.Drawing.Color.Transparent;
            this.earning_Label.Font = new System.Drawing.Font("Segoe UI Semibold", 21.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.earning_Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(211)))), ((int)(((byte)(255)))));
            this.earning_Label.Location = new System.Drawing.Point(53, 64);
            this.earning_Label.Name = "earning_Label";
            this.earning_Label.Size = new System.Drawing.Size(122, 40);
            this.earning_Label.TabIndex = 1;
            this.earning_Label.Text = "22000.0";
            // 
            // EarningThisMonth_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::FarmaStead_V2._0_.Properties.Resources.EarningThisMonth;
            this.Controls.Add(this.earning_Label);
            this.Controls.Add(this.statment_PictureBox);
            this.DoubleBuffered = true;
            this.Name = "EarningThisMonth_UserControl";
            this.Size = new System.Drawing.Size(254, 274);
            ((System.ComponentModel.ISupportInitialize)(this.statment_PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox statment_PictureBox;
        private System.Windows.Forms.Label earning_Label;
    }
}
