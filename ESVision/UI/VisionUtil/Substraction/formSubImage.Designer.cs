
namespace ESVision
{
    partial class formSubImage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formSubImage));
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnNewBackgroundImg = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnOpenSourceImg = new System.Windows.Forms.Button();
            this.btnNewSourceImg = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.btnExecuteSubImg = new System.Windows.Forms.Button();
            this.btnCloseFormSub = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.picSourceImg = new System.Windows.Forms.PictureBox();
            this.picSourceImage = new System.Windows.Forms.PictureBox();
            this.btnOpenBackgroundImg = new System.Windows.Forms.Button();
            this.picBackgroundImg = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSourceImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSourceImage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackgroundImg)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Background Image";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnNewBackgroundImg);
            this.groupBox1.Controls.Add(this.btnOpenBackgroundImg);
            this.groupBox1.Controls.Add(this.picBackgroundImg);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(250, 326);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // btnNewBackgroundImg
            // 
            this.btnNewBackgroundImg.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewBackgroundImg.ImageIndex = 0;
            this.btnNewBackgroundImg.ImageList = this.imageList1;
            this.btnNewBackgroundImg.Location = new System.Drawing.Point(17, 263);
            this.btnNewBackgroundImg.Name = "btnNewBackgroundImg";
            this.btnNewBackgroundImg.Size = new System.Drawing.Size(27, 26);
            this.btnNewBackgroundImg.TabIndex = 5;
            this.btnNewBackgroundImg.UseVisualStyleBackColor = false;
            this.btnNewBackgroundImg.Click += new System.EventHandler(this.btnNewBackgroundImg_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnOpenSourceImg);
            this.groupBox2.Controls.Add(this.btnNewSourceImg);
            this.groupBox2.Controls.Add(this.picSourceImg);
            this.groupBox2.Controls.Add(this.picSourceImage);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(268, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(250, 326);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            // 
            // btnOpenSourceImg
            // 
            this.btnOpenSourceImg.ImageIndex = 1;
            this.btnOpenSourceImg.ImageList = this.imageList1;
            this.btnOpenSourceImg.Location = new System.Drawing.Point(50, 261);
            this.btnOpenSourceImg.Name = "btnOpenSourceImg";
            this.btnOpenSourceImg.Size = new System.Drawing.Size(27, 26);
            this.btnOpenSourceImg.TabIndex = 7;
            this.btnOpenSourceImg.UseVisualStyleBackColor = true;
            this.btnOpenSourceImg.Click += new System.EventHandler(this.btnOpenSourceImg_Click);
            // 
            // btnNewSourceImg
            // 
            this.btnNewSourceImg.ImageIndex = 0;
            this.btnNewSourceImg.ImageList = this.imageList1;
            this.btnNewSourceImg.Location = new System.Drawing.Point(17, 261);
            this.btnNewSourceImg.Name = "btnNewSourceImg";
            this.btnNewSourceImg.Size = new System.Drawing.Size(27, 26);
            this.btnNewSourceImg.TabIndex = 6;
            this.btnNewSourceImg.UseVisualStyleBackColor = true;
            this.btnNewSourceImg.Click += new System.EventHandler(this.btnNewSourceImg_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(15, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 12);
            this.label2.TabIndex = 0;
            this.label2.Text = "Source Image";
            // 
            // btnExecuteSubImg
            // 
            this.btnExecuteSubImg.Location = new System.Drawing.Point(539, 306);
            this.btnExecuteSubImg.Name = "btnExecuteSubImg";
            this.btnExecuteSubImg.Size = new System.Drawing.Size(97, 32);
            this.btnExecuteSubImg.TabIndex = 5;
            this.btnExecuteSubImg.Text = "Execute";
            this.btnExecuteSubImg.UseVisualStyleBackColor = true;
            this.btnExecuteSubImg.Click += new System.EventHandler(this.btnExecuteSubImg_Click);
            // 
            // btnCloseFormSub
            // 
            this.btnCloseFormSub.Location = new System.Drawing.Point(642, 306);
            this.btnCloseFormSub.Name = "btnCloseFormSub";
            this.btnCloseFormSub.Size = new System.Drawing.Size(97, 32);
            this.btnCloseFormSub.TabIndex = 1;
            this.btnCloseFormSub.Text = "Close";
            this.btnCloseFormSub.UseVisualStyleBackColor = true;
            this.btnCloseFormSub.Click += new System.EventHandler(this.btnCloseFormSub_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Black;
            this.imageList1.Images.SetKeyName(0, "newDocument.png");
            this.imageList1.Images.SetKeyName(1, "openFolder.png");
            this.imageList1.Images.SetKeyName(2, "saveFile.png");
            // 
            // picSourceImg
            // 
            this.picSourceImg.BackColor = System.Drawing.SystemColors.Control;
            this.picSourceImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSourceImg.Location = new System.Drawing.Point(17, 39);
            this.picSourceImg.Name = "picSourceImg";
            this.picSourceImg.Size = new System.Drawing.Size(216, 216);
            this.picSourceImg.TabIndex = 5;
            this.picSourceImg.TabStop = false;
            // 
            // picSourceImage
            // 
            this.picSourceImage.BackColor = System.Drawing.SystemColors.Control;
            this.picSourceImage.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picSourceImage.Location = new System.Drawing.Point(17, 41);
            this.picSourceImage.Name = "picSourceImage";
            this.picSourceImage.Size = new System.Drawing.Size(216, 216);
            this.picSourceImage.TabIndex = 2;
            this.picSourceImage.TabStop = false;
            // 
            // btnOpenBackgroundImg
            // 
            this.btnOpenBackgroundImg.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenBackgroundImg.ImageIndex = 1;
            this.btnOpenBackgroundImg.ImageList = this.imageList1;
            this.btnOpenBackgroundImg.Location = new System.Drawing.Point(50, 263);
            this.btnOpenBackgroundImg.Name = "btnOpenBackgroundImg";
            this.btnOpenBackgroundImg.Size = new System.Drawing.Size(27, 26);
            this.btnOpenBackgroundImg.TabIndex = 4;
            this.btnOpenBackgroundImg.UseVisualStyleBackColor = false;
            this.btnOpenBackgroundImg.Click += new System.EventHandler(this.btnOpenBackgroundImg_Click);
            // 
            // picBackgroundImg
            // 
            this.picBackgroundImg.BackColor = System.Drawing.SystemColors.Control;
            this.picBackgroundImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBackgroundImg.Location = new System.Drawing.Point(17, 41);
            this.picBackgroundImg.Name = "picBackgroundImg";
            this.picBackgroundImg.Size = new System.Drawing.Size(216, 216);
            this.picBackgroundImg.TabIndex = 2;
            this.picBackgroundImg.TabStop = false;
            // 
            // formSubImage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(751, 350);
            this.Controls.Add(this.btnCloseFormSub);
            this.Controls.Add(this.btnExecuteSubImg);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "formSubImage";
            this.Text = "Subtraction ";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picSourceImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picSourceImage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBackgroundImg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox picBackgroundImg;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.PictureBox picSourceImage;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnExecuteSubImg;
        private System.Windows.Forms.Button btnCloseFormSub;
        private System.Windows.Forms.Button btnNewBackgroundImg;
        private System.Windows.Forms.Button btnOpenBackgroundImg;
        private System.Windows.Forms.Button btnOpenSourceImg;
        private System.Windows.Forms.Button btnNewSourceImg;
        private System.Windows.Forms.PictureBox picSourceImg;
        private System.Windows.Forms.ImageList imageList1;
    }
}