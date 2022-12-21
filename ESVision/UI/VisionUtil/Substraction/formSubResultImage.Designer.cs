
namespace ESVision
{
    partial class formSubResultImage
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
            this.picResultImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picResultImg)).BeginInit();
            this.SuspendLayout();
            // 
            // picResultImg
            // 
            this.picResultImg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picResultImg.Location = new System.Drawing.Point(0, 0);
            this.picResultImg.Name = "picResultImg";
            this.picResultImg.Size = new System.Drawing.Size(713, 527);
            this.picResultImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picResultImg.TabIndex = 0;
            this.picResultImg.TabStop = false;
            // 
            // formSubResultImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(713, 527);
            this.Controls.Add(this.picResultImg);
            this.Name = "formSubResultImage";
            this.Text = "Subtraction Result";
            ((System.ComponentModel.ISupportInitialize)(this.picResultImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picResultImg;
    }
}