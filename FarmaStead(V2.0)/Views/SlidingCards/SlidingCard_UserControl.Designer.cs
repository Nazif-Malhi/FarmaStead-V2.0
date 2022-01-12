
namespace FarmaStead_V2._0_.Components.SlidingCards
{
    partial class SlidingCard_UserControl
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
            this.components = new System.ComponentModel.Container();
            this.Click_PictureBox = new System.Windows.Forms.PictureBox();
            this.sliding_Timer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Click_PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // Click_PictureBox
            // 
            this.Click_PictureBox.Location = new System.Drawing.Point(33, 251);
            this.Click_PictureBox.Name = "Click_PictureBox";
            this.Click_PictureBox.Size = new System.Drawing.Size(157, 45);
            this.Click_PictureBox.TabIndex = 0;
            this.Click_PictureBox.TabStop = false;
            this.Click_PictureBox.Click += new System.EventHandler(this.Click_PictureBox_Click);
            this.Click_PictureBox.MouseEnter += new System.EventHandler(this.Click_PictureBox_MouseEnter);
            this.Click_PictureBox.MouseLeave += new System.EventHandler(this.Click_PictureBox_MouseLeave);
            // 
            // sliding_Timer
            // 
            this.sliding_Timer.Interval = 3000;
            this.sliding_Timer.Tick += new System.EventHandler(this.sliding_Timer_Tick);
            // 
            // SlidingCard_UserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Transparent;
            this.BackgroundImage = global::FarmaStead_V2._0_.Properties.Resources.PlayCardAgri;
            this.Controls.Add(this.Click_PictureBox);
            this.DoubleBuffered = true;
            this.Name = "SlidingCard_UserControl";
            this.Size = new System.Drawing.Size(599, 368);
            ((System.ComponentModel.ISupportInitialize)(this.Click_PictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Click_PictureBox;
        private System.Windows.Forms.Timer sliding_Timer;
    }
}
