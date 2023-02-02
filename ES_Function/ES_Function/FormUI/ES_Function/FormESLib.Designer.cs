
namespace ES_Function.FormUI
{
    partial class FormESLib
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
            this.components = new System.ComponentModel.Container();
            this.imageViewerEx1 = new Engion.ImageViewerEx();
            this.logViewer1 = new Engion.LogViewer(this.components);
            this.btnOpenImg = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // imageViewerEx1
            // 
            this.imageViewerEx1.BackColor = System.Drawing.SystemColors.Control;
            this.imageViewerEx1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.imageViewerEx1.DisplayImageRect = new System.Drawing.Rectangle(0, 0, 0, 0);
            this.imageViewerEx1.DrawShape = null;
            this.imageViewerEx1.EnhanceImage = false;
            this.imageViewerEx1.EnhanceLevel = 1D;
            this.imageViewerEx1.EnhanceOffset = 0;
            this.imageViewerEx1.EnhanceRefLevel = 100;
            this.imageViewerEx1.EnhanceWhenMouseClick = true;
            this.imageViewerEx1.Image = null;
            this.imageViewerEx1.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.Default;
            this.imageViewerEx1.Location = new System.Drawing.Point(12, 63);
            this.imageViewerEx1.MouseMode = Engion.ImageViewerEx.MouseModes.Panning;
            this.imageViewerEx1.Name = "imageViewerEx1";
            this.imageViewerEx1.ScrollPosition = new System.Drawing.Point(0, 0);
            this.imageViewerEx1.ShowDrawShape = false;
            this.imageViewerEx1.Size = new System.Drawing.Size(921, 395);
            this.imageViewerEx1.TabIndex = 0;
            this.imageViewerEx1.UseFastDisplay = false;
            this.imageViewerEx1.Zoom = 1D;
            // 
            // logViewer1
            // 
            this.logViewer1.Format = "[{0:MM-dd HH:mm:ss.fff}] {3}";
            this.logViewer1.Location = new System.Drawing.Point(12, 464);
            this.logViewer1.Log = null;
            this.logViewer1.Name = "logViewer1";
            this.logViewer1.ReadOnly = true;
            this.logViewer1.Size = new System.Drawing.Size(921, 96);
            this.logViewer1.TabIndex = 1;
            this.logViewer1.Text = "";
            this.logViewer1.WordWrap = false;
            // 
            // btnOpenImg
            // 
            this.btnOpenImg.Location = new System.Drawing.Point(829, 12);
            this.btnOpenImg.Name = "btnOpenImg";
            this.btnOpenImg.Size = new System.Drawing.Size(104, 45);
            this.btnOpenImg.TabIndex = 2;
            this.btnOpenImg.Text = "Image Open";
            this.btnOpenImg.UseVisualStyleBackColor = true;
            // 
            // FormESLib
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(945, 572);
            this.Controls.Add(this.btnOpenImg);
            this.Controls.Add(this.logViewer1);
            this.Controls.Add(this.imageViewerEx1);
            this.Name = "FormESLib";
            this.Text = "FormESLib";
            this.Load += new System.EventHandler(this.FormESLib_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Engion.ImageViewerEx imageViewerEx1;
        private Engion.LogViewer logViewer1;
        private System.Windows.Forms.Button btnOpenImg;
    }
}