
namespace ESVision
{
    partial class formImageViewer
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
            this.pnlImageViewer = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // pnlImageViewer
            // 
            this.pnlImageViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlImageViewer.Location = new System.Drawing.Point(0, 0);
            this.pnlImageViewer.Name = "pnlImageViewer";
            this.pnlImageViewer.Size = new System.Drawing.Size(800, 450);
            this.pnlImageViewer.TabIndex = 0;
            // 
            // formImageViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlImageViewer);
            this.Name = "formImageViewer";
            this.Text = "formImageViewer";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlImageViewer;
    }
}