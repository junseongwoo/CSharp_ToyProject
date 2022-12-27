
namespace ESVision
{
    partial class TopView
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.imageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.openImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageToolsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.imageSubtractionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thresholdToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripSaveBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripNewOpenBtn = new System.Windows.Forms.ToolStripButton();
            this.toolStripBtnOpenImg = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripBtnZoom = new System.Windows.Forms.ToolStripButton();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.imageToolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(5, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1900, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // imageToolStripMenuItem
            // 
            this.imageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newImageToolStripMenuItem,
            this.openImageToolStripMenuItem,
            this.saveImageToolStripMenuItem});
            this.imageToolStripMenuItem.Name = "imageToolStripMenuItem";
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // newImageToolStripMenuItem
            // 
            this.newImageToolStripMenuItem.Name = "newImageToolStripMenuItem";
            this.newImageToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.newImageToolStripMenuItem.Text = "New Image";
            this.newImageToolStripMenuItem.Click += new System.EventHandler(this.newImageToolStripMenuItem_Click);
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(140, 22);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            // 
            // imageToolsToolStripMenuItem
            // 
            this.imageToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageSubtractionToolStripMenuItem,
            this.thresholdToolStripMenuItem});
            this.imageToolsToolStripMenuItem.Name = "imageToolsToolStripMenuItem";
            this.imageToolsToolStripMenuItem.Size = new System.Drawing.Size(84, 20);
            this.imageToolsToolStripMenuItem.Text = "Image Tools";
            // 
            // imageSubtractionToolStripMenuItem
            // 
            this.imageSubtractionToolStripMenuItem.Name = "imageSubtractionToolStripMenuItem";
            this.imageSubtractionToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.imageSubtractionToolStripMenuItem.Text = "Image Substraction";
            this.imageSubtractionToolStripMenuItem.Click += new System.EventHandler(this.imageSubtractionToolStripMenuItem_Click);
            // 
            // thresholdToolStripMenuItem
            // 
            this.thresholdToolStripMenuItem.Name = "thresholdToolStripMenuItem";
            this.thresholdToolStripMenuItem.Size = new System.Drawing.Size(178, 22);
            this.thresholdToolStripMenuItem.Text = "Threshold";
            this.thresholdToolStripMenuItem.Click += new System.EventHandler(this.thresholdToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSaveBtn,
            this.toolStripNewOpenBtn,
            this.toolStripBtnOpenImg,
            this.toolStripSeparator1,
            this.toolStripBtnZoom,
            this.toolStripTextBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 24);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1900, 27);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripSaveBtn
            // 
            this.toolStripSaveBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripSaveBtn.Image = global::ESVision.Properties.Resources.saveFile;
            this.toolStripSaveBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripSaveBtn.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripSaveBtn.Name = "toolStripSaveBtn";
            this.toolStripSaveBtn.Size = new System.Drawing.Size(24, 24);
            this.toolStripSaveBtn.Text = "Save";
            // 
            // toolStripNewOpenBtn
            // 
            this.toolStripNewOpenBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNewOpenBtn.Image = global::ESVision.Properties.Resources.newDocument;
            this.toolStripNewOpenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNewOpenBtn.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripNewOpenBtn.Name = "toolStripNewOpenBtn";
            this.toolStripNewOpenBtn.Size = new System.Drawing.Size(24, 24);
            this.toolStripNewOpenBtn.Text = "New Image";
            // 
            // toolStripBtnOpenImg
            // 
            this.toolStripBtnOpenImg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnOpenImg.Image = global::ESVision.Properties.Resources.openFolder;
            this.toolStripBtnOpenImg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOpenImg.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripBtnOpenImg.Name = "toolStripBtnOpenImg";
            this.toolStripBtnOpenImg.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnOpenImg.Text = "Open Image";
            this.toolStripBtnOpenImg.Click += new System.EventHandler(this.toolStripBtnOpenImg_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 27);
            // 
            // toolStripBtnZoom
            // 
            this.toolStripBtnZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnZoom.Image = global::ESVision.Properties.Resources.zoom;
            this.toolStripBtnZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnZoom.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripBtnZoom.Name = "toolStripBtnZoom";
            this.toolStripBtnZoom.Size = new System.Drawing.Size(24, 24);
            this.toolStripBtnZoom.Text = "Zoom";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.BackColor = System.Drawing.SystemColors.Control;
            this.toolStripTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(4, 0, 1, 0);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(45, 27);
            this.toolStripTextBox1.Text = "1:1";
            this.toolStripTextBox1.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // TopView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1900, 51);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "TopView";
            this.Text = "TopView";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem imageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem openImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageToolsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem imageSubtractionToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton toolStripSaveBtn;
        private System.Windows.Forms.ToolStripButton toolStripNewOpenBtn;
        private System.Windows.Forms.ToolStripButton toolStripBtnOpenImg;
        private System.Windows.Forms.ToolStripMenuItem thresholdToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton toolStripBtnZoom;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
    }
}