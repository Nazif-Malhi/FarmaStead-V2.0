
namespace FarmaStead_V2._0_.Components.SmallCards
{
    partial class EarningByItems_UserControl
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
            this.checkItems_PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.checkItems_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // checkItems_PictureBox
            // 
            this.checkItems_PictureBox.BackgroundImage = global::FarmaStead_V2._0_.Properties.Resources.EarningbyItemsButton;
            this.checkItems_PictureBox.Location = new System.Drawing.Point(63, 217);
            this.checkItems_PictureBox.Name = "checkItems_PictureBox";
            this.checkItems_PictureBox.Size = new System.Drawing.Size(106, 27);
            this.checkItems_PictureBox.TabIndex = 0;
            this.checkItems_PictureBox.TabStop = false;
            this.checkItems_PictureBox.Click += new System.EventHandler(this.checkItems_PictureBox_Click);
            this.checkItems_PictureBox.MouseEnter += new System.EventHandler(this.checkItems_PictureBox_MouseEnter);
            this.checkItems_PictureBox.MouseLeave += new System.EventHandler(this.checkItems_PictureBox_MouseLeave);
            // 
            // EarningByItems_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::FarmaStead_V2._0_.Properties.Resources.EarningByItems;
            this.Controls.Add(this.checkItems_PictureBox);
            this.DoubleBuffered = true;
            this.Name = "EarningByItems_UserControl";
            this.Size = new System.Drawing.Size(252, 273);
            ((System.ComponentModel.ISupportInitialize)(this.checkItems_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox checkItems_PictureBox;
    }
}
