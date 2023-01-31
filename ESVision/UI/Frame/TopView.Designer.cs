
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TopView));
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
            this.toolStriptxtZoomRatio = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.btn_UpZoomRatio = new System.Windows.Forms.Button();
            this.btn_DownZoomRatio = new System.Windows.Forms.Button();
            this.resizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.rotateToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.flipToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.horliToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.verticalToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.imageToolStripMenuItem,
            this.imageToolsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(1946, 36);
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
            this.imageToolStripMenuItem.Size = new System.Drawing.Size(79, 29);
            this.imageToolStripMenuItem.Text = "Image";
            // 
            // newImageToolStripMenuItem
            // 
            this.newImageToolStripMenuItem.Name = "newImageToolStripMenuItem";
            this.newImageToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.newImageToolStripMenuItem.Text = "New Image";
            this.newImageToolStripMenuItem.Click += new System.EventHandler(this.newImageToolStripMenuItem_Click);
            // 
            // openImageToolStripMenuItem
            // 
            this.openImageToolStripMenuItem.Name = "openImageToolStripMenuItem";
            this.openImageToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.openImageToolStripMenuItem.Text = "Open Image";
            this.openImageToolStripMenuItem.Click += new System.EventHandler(this.openImageToolStripMenuItem_Click);
            // 
            // saveImageToolStripMenuItem
            // 
            this.saveImageToolStripMenuItem.Name = "saveImageToolStripMenuItem";
            this.saveImageToolStripMenuItem.Size = new System.Drawing.Size(216, 34);
            this.saveImageToolStripMenuItem.Text = "Save Image";
            // 
            // imageToolsToolStripMenuItem
            // 
            this.imageToolsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.resizeToolStripMenuItem,
            this.rotateToolStripMenuItem,
            this.thresholdToolStripMenuItem,
            this.imageSubtractionToolStripMenuItem,
            this.flipToolStripMenuItem});
            this.imageToolsToolStripMenuItem.Name = "imageToolsToolStripMenuItem";
            this.imageToolsToolStripMenuItem.Size = new System.Drawing.Size(129, 30);
            this.imageToolsToolStripMenuItem.Text = "Image Tools";
            // 
            // imageSubtractionToolStripMenuItem
            // 
            this.imageSubtractionToolStripMenuItem.Name = "imageSubtractionToolStripMenuItem";
            this.imageSubtractionToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.imageSubtractionToolStripMenuItem.Text = "Image Substraction";
            this.imageSubtractionToolStripMenuItem.Click += new System.EventHandler(this.imageSubtractionToolStripMenuItem_Click);
            // 
            // thresholdToolStripMenuItem
            // 
            this.thresholdToolStripMenuItem.Name = "thresholdToolStripMenuItem";
            this.thresholdToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
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
            this.toolStriptxtZoomRatio,
            this.toolStripButton1,
            this.toolStripButton2});
            this.toolStrip1.Location = new System.Drawing.Point(0, 36);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Padding = new System.Windows.Forms.Padding(0, 0, 3, 0);
            this.toolStrip1.Size = new System.Drawing.Size(1946, 38);
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
            this.toolStripSaveBtn.Size = new System.Drawing.Size(34, 28);
            this.toolStripSaveBtn.Text = "Save";
            // 
            // toolStripNewOpenBtn
            // 
            this.toolStripNewOpenBtn.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripNewOpenBtn.Image = global::ESVision.Properties.Resources.newDocument;
            this.toolStripNewOpenBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripNewOpenBtn.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripNewOpenBtn.Name = "toolStripNewOpenBtn";
            this.toolStripNewOpenBtn.Size = new System.Drawing.Size(34, 28);
            this.toolStripNewOpenBtn.Text = "New Image";
            // 
            // toolStripBtnOpenImg
            // 
            this.toolStripBtnOpenImg.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnOpenImg.Image = global::ESVision.Properties.Resources.openFolder;
            this.toolStripBtnOpenImg.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnOpenImg.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripBtnOpenImg.Name = "toolStripBtnOpenImg";
            this.toolStripBtnOpenImg.Size = new System.Drawing.Size(34, 28);
            this.toolStripBtnOpenImg.Text = "Open Image";
            this.toolStripBtnOpenImg.Click += new System.EventHandler(this.toolStripBtnOpenImg_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 31);
            // 
            // toolStripBtnZoom
            // 
            this.toolStripBtnZoom.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripBtnZoom.Image = global::ESVision.Properties.Resources.zoom;
            this.toolStripBtnZoom.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripBtnZoom.Margin = new System.Windows.Forms.Padding(3, 1, 0, 2);
            this.toolStripBtnZoom.Name = "toolStripBtnZoom";
            this.toolStripBtnZoom.Size = new System.Drawing.Size(34, 28);
            this.toolStripBtnZoom.Text = "Zoom";
            // 
            // toolStriptxtZoomRatio
            // 
            this.toolStriptxtZoomRatio.BackColor = System.Drawing.SystemColors.Control;
            this.toolStriptxtZoomRatio.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStriptxtZoomRatio.Font = new System.Drawing.Font("맑은 고딕", 9F);
            this.toolStriptxtZoomRatio.Margin = new System.Windows.Forms.Padding(4, 0, 1, 0);
            this.toolStriptxtZoomRatio.Name = "toolStriptxtZoomRatio";
            this.toolStriptxtZoomRatio.ReadOnly = true;
            this.toolStriptxtZoomRatio.Size = new System.Drawing.Size(63, 31);
            this.toolStriptxtZoomRatio.Text = "1:1";
            this.toolStriptxtZoomRatio.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.Size = new System.Drawing.Size(34, 26);
            this.toolStripButton1.Text = "toolStripButton1";
            this.toolStripButton1.Visible = false;
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.None;
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(34, 26);
            this.toolStripButton2.Text = "toolStripButton2";
            this.toolStripButton2.Visible = false;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "Up.png");
            this.imageList1.Images.SetKeyName(1, "Down.png");
            // 
            // btn_UpZoomRatio
            // 
            this.btn_UpZoomRatio.ImageIndex = 0;
            this.btn_UpZoomRatio.ImageList = this.imageList1;
            this.btn_UpZoomRatio.Location = new System.Drawing.Point(249, 36);
            this.btn_UpZoomRatio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_UpZoomRatio.Name = "btn_UpZoomRatio";
            this.btn_UpZoomRatio.Size = new System.Drawing.Size(31, 22);
            this.btn_UpZoomRatio.TabIndex = 2;
            this.btn_UpZoomRatio.TabStop = false;
            this.btn_UpZoomRatio.UseVisualStyleBackColor = true;
            this.btn_UpZoomRatio.Click += new System.EventHandler(this.btn_UpZoomRatio_Click);
            // 
            // btn_DownZoomRatio
            // 
            this.btn_DownZoomRatio.ImageIndex = 1;
            this.btn_DownZoomRatio.ImageList = this.imageList1;
            this.btn_DownZoomRatio.Location = new System.Drawing.Point(249, 56);
            this.btn_DownZoomRatio.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_DownZoomRatio.Name = "btn_DownZoomRatio";
            this.btn_DownZoomRatio.Size = new System.Drawing.Size(31, 21);
            this.btn_DownZoomRatio.TabIndex = 3;
            this.btn_DownZoomRatio.TabStop = false;
            this.btn_DownZoomRatio.UseVisualStyleBackColor = true;
            this.btn_DownZoomRatio.Click += new System.EventHandler(this.btn_DownZoomRatio_Click);
            // 
            // resizeToolStripMenuItem
            // 
            this.resizeToolStripMenuItem.Name = "resizeToolStripMenuItem";
            this.resizeToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.resizeToolStripMenuItem.Text = "Resize";
            // 
            // rotateToolStripMenuItem
            // 
            this.rotateToolStripMenuItem.Name = "rotateToolStripMenuItem";
            this.rotateToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.rotateToolStripMenuItem.Text = "Rotate";
            // 
            // flipToolStripMenuItem
            // 
            this.flipToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.horliToolStripMenuItem,
            this.verticalToolStripMenuItem});
            this.flipToolStripMenuItem.Name = "flipToolStripMenuItem";
            this.flipToolStripMenuItem.Size = new System.Drawing.Size(271, 34);
            this.flipToolStripMenuItem.Text = "Flip";
            // 
            // horliToolStripMenuItem
            // 
            this.horliToolStripMenuItem.Name = "horliToolStripMenuItem";
            this.horliToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.horliToolStripMenuItem.Text = "Horlizontal ";
            // 
            // verticalToolStripMenuItem
            // 
            this.verticalToolStripMenuItem.Name = "verticalToolStripMenuItem";
            this.verticalToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.verticalToolStripMenuItem.Text = "Vertical";
            // 
            // TopView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1946, 76);
            this.Controls.Add(this.btn_DownZoomRatio);
            this.Controls.Add(this.btn_UpZoomRatio);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
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
        private System.Windows.Forms.ToolStripTextBox toolStriptxtZoomRatio;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button btn_UpZoomRatio;
        private System.Windows.Forms.Button btn_DownZoomRatio;
        private System.Windows.Forms.ToolStripMenuItem resizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem rotateToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem flipToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem horliToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem verticalToolStripMenuItem;
    }
}