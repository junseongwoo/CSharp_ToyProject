
namespace ESVision
{
    partial class formThresholdResultImage
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
            this.picThresholdResultImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picThresholdResultImg)).BeginInit();
            this.SuspendLayout();
            // 
            // picThresholdResultImg
            // 
            this.picThresholdResultImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picThresholdResultImg.Location = new System.Drawing.Point(0, 0);
            this.picThresholdResultImg.Name = "picThresholdResultImg";
            this.picThresholdResultImg.Size = new System.Drawing.Size(485, 475);
            this.picThresholdResultImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picThresholdResultImg.TabIndex = 0;
            this.picThresholdResultImg.TabStop = false;
            // 
            // formThresholdResultImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 475);
            this.Controls.Add(this.picThresholdResultImg);
            this.Name = "formThresholdResultImage";
            this.Text = "Threshold Result Image";
            ((System.ComponentModel.ISupportInitialize)(this.picThresholdResultImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picThresholdResultImg;
    }
}