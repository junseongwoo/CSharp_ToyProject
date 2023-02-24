
namespace ESVision
{
    partial class FileOptionView
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
            this.prgFileOption = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // prgFileOption
            // 
            this.prgFileOption.Location = new System.Drawing.Point(12, 12);
            this.prgFileOption.Name = "prgFileOption";
            this.prgFileOption.Size = new System.Drawing.Size(426, 326);
            this.prgFileOption.TabIndex = 0;
            // 
            // FileOptionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.prgFileOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FileOptionView";
            this.Text = "FileOptionView";
            this.Load += new System.EventHandler(this.FileOptionView_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid prgFileOption;
    }
}