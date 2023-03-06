
namespace ESVision
{
    partial class PathOptionView
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
            this.prgPathOption = new System.Windows.Forms.PropertyGrid();
            this.SuspendLayout();
            // 
            // prgPathOption
            // 
            this.prgPathOption.Location = new System.Drawing.Point(12, 12);
            this.prgPathOption.Name = "prgPathOption";
            this.prgPathOption.Size = new System.Drawing.Size(426, 326);
            this.prgPathOption.TabIndex = 1;
            // 
            // PathOptionView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(450, 350);
            this.Controls.Add(this.prgPathOption);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "PathOptionView";
            this.Text = "PathOptionView";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PropertyGrid prgPathOption;
    }
}