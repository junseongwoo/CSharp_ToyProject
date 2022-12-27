
namespace ESVision
{
    partial class formOpenImage
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.picOpenImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picOpenImg)).BeginInit();
            this.SuspendLayout();
            // 
            // picOpenImg
            // 
            this.picOpenImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picOpenImg.Location = new System.Drawing.Point(0, 0);
            this.picOpenImg.Name = "picOpenImg";
            this.picOpenImg.Size = new System.Drawing.Size(700, 360);
            this.picOpenImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picOpenImg.TabIndex = 0;
            this.picOpenImg.TabStop = false;
            this.picOpenImg.Click += new System.EventHandler(this.picOpenImg_Click);
            // 
            // formOpenImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 360);
            this.Controls.Add(this.picOpenImg);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "formOpenImage";
            this.Text = "Image";
            this.Click += new System.EventHandler(this.formOpenImage_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picOpenImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picOpenImg;
    }
}