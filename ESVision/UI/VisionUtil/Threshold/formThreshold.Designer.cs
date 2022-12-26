
namespace ESVision
{
    partial class formThreshold
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(formThreshold));
            this.txtBaseImgPath = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCloseFormSub = new System.Windows.Forms.Button();
            this.btnExecuteSubImg = new System.Windows.Forms.Button();
            this.trbThreshold = new System.Windows.Forms.TrackBar();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.txtThresholdValue = new System.Windows.Forms.TextBox();
            this.btnNewBaseImg = new System.Windows.Forms.Button();
            this.btnOpenBaseImg = new System.Windows.Forms.Button();
            this.picBaseImg = new System.Windows.Forms.PictureBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtResultImgPath = new System.Windows.Forms.TextBox();
            this.btnNewResultImg = new System.Windows.Forms.Button();
            this.btnOpenResultImg = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.trbThreshold)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBaseImg)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBaseImgPath
            // 
            this.txtBaseImgPath.Location = new System.Drawing.Point(6, 42);
            this.txtBaseImgPath.Name = "txtBaseImgPath";
            this.txtBaseImgPath.ReadOnly = true;
            this.txtBaseImgPath.Size = new System.Drawing.Size(185, 21);
            this.txtBaseImgPath.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "Base Image";
            // 
            // btnCloseFormSub
            // 
            this.btnCloseFormSub.Location = new System.Drawing.Point(732, 285);
            this.btnCloseFormSub.Name = "btnCloseFormSub";
            this.btnCloseFormSub.Size = new System.Drawing.Size(97, 32);
            this.btnCloseFormSub.TabIndex = 8;
            this.btnCloseFormSub.Text = "Close";
            this.btnCloseFormSub.UseVisualStyleBackColor = true;
            // 
            // btnExecuteSubImg
            // 
            this.btnExecuteSubImg.Location = new System.Drawing.Point(629, 285);
            this.btnExecuteSubImg.Name = "btnExecuteSubImg";
            this.btnExecuteSubImg.Size = new System.Drawing.Size(97, 32);
            this.btnExecuteSubImg.TabIndex = 11;
            this.btnExecuteSubImg.Text = "Execute";
            this.btnExecuteSubImg.UseVisualStyleBackColor = true;
            this.btnExecuteSubImg.Click += new System.EventHandler(this.btnExecuteSubImg_Click);
            // 
            // trbThreshold
            // 
            this.trbThreshold.Location = new System.Drawing.Point(185, 14);
            this.trbThreshold.Maximum = 255;
            this.trbThreshold.Name = "trbThreshold";
            this.trbThreshold.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trbThreshold.Size = new System.Drawing.Size(45, 247);
            this.trbThreshold.TabIndex = 15;
            this.trbThreshold.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trbThreshold.Scroll += new System.EventHandler(this.trbThreshold_Scroll);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.txtThresholdValue);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.trbThreshold);
            this.groupBox1.Location = new System.Drawing.Point(593, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(236, 267);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 12);
            this.label2.TabIndex = 16;
            this.label2.Text = "Threshold Value : ";
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "newDocument.png");
            this.imageList1.Images.SetKeyName(1, "openFolder.png");
            this.imageList1.Images.SetKeyName(2, "saveFile.png");
            // 
            // txtThresholdValue
            // 
            this.txtThresholdValue.Location = new System.Drawing.Point(122, 14);
            this.txtThresholdValue.Name = "txtThresholdValue";
            this.txtThresholdValue.Size = new System.Drawing.Size(42, 21);
            this.txtThresholdValue.TabIndex = 17;
            this.txtThresholdValue.Text = "0";
            this.txtThresholdValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnNewBaseImg
            // 
            this.btnNewBaseImg.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewBaseImg.ImageIndex = 0;
            this.btnNewBaseImg.ImageList = this.imageList1;
            this.btnNewBaseImg.Location = new System.Drawing.Point(209, 38);
            this.btnNewBaseImg.Name = "btnNewBaseImg";
            this.btnNewBaseImg.Size = new System.Drawing.Size(27, 26);
            this.btnNewBaseImg.TabIndex = 10;
            this.btnNewBaseImg.UseVisualStyleBackColor = false;
            // 
            // btnOpenBaseImg
            // 
            this.btnOpenBaseImg.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenBaseImg.ImageIndex = 1;
            this.btnOpenBaseImg.ImageList = this.imageList1;
            this.btnOpenBaseImg.Location = new System.Drawing.Point(242, 38);
            this.btnOpenBaseImg.Name = "btnOpenBaseImg";
            this.btnOpenBaseImg.Size = new System.Drawing.Size(27, 26);
            this.btnOpenBaseImg.TabIndex = 9;
            this.btnOpenBaseImg.UseVisualStyleBackColor = false;
            this.btnOpenBaseImg.Click += new System.EventHandler(this.btnOpenBaseImg_Click);
            // 
            // picBaseImg
            // 
            this.picBaseImg.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBaseImg.Location = new System.Drawing.Point(7, 86);
            this.picBaseImg.Name = "picBaseImg";
            this.picBaseImg.Size = new System.Drawing.Size(263, 220);
            this.picBaseImg.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBaseImg.TabIndex = 0;
            this.picBaseImg.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtBaseImgPath);
            this.groupBox2.Controls.Add(this.btnNewBaseImg);
            this.groupBox2.Controls.Add(this.btnOpenBaseImg);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.picBaseImg);
            this.groupBox2.Location = new System.Drawing.Point(12, 9);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(280, 312);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtResultImgPath);
            this.groupBox3.Controls.Add(this.btnNewResultImg);
            this.groupBox3.Controls.Add(this.btnOpenResultImg);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.pictureBox1);
            this.groupBox3.Location = new System.Drawing.Point(307, 9);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(280, 312);
            this.groupBox3.TabIndex = 19;
            this.groupBox3.TabStop = false;
            // 
            // txtResultImgPath
            // 
            this.txtResultImgPath.Location = new System.Drawing.Point(8, 42);
            this.txtResultImgPath.Name = "txtResultImgPath";
            this.txtResultImgPath.ReadOnly = true;
            this.txtResultImgPath.Size = new System.Drawing.Size(185, 21);
            this.txtResultImgPath.TabIndex = 12;
            // 
            // btnNewResultImg
            // 
            this.btnNewResultImg.BackColor = System.Drawing.SystemColors.Control;
            this.btnNewResultImg.ImageIndex = 0;
            this.btnNewResultImg.ImageList = this.imageList1;
            this.btnNewResultImg.Location = new System.Drawing.Point(211, 38);
            this.btnNewResultImg.Name = "btnNewResultImg";
            this.btnNewResultImg.Size = new System.Drawing.Size(27, 26);
            this.btnNewResultImg.TabIndex = 10;
            this.btnNewResultImg.UseVisualStyleBackColor = false;
            // 
            // btnOpenResultImg
            // 
            this.btnOpenResultImg.BackColor = System.Drawing.SystemColors.Control;
            this.btnOpenResultImg.ImageIndex = 1;
            this.btnOpenResultImg.ImageList = this.imageList1;
            this.btnOpenResultImg.Location = new System.Drawing.Point(244, 38);
            this.btnOpenResultImg.Name = "btnOpenResultImg";
            this.btnOpenResultImg.Size = new System.Drawing.Size(27, 26);
            this.btnOpenResultImg.TabIndex = 9;
            this.btnOpenResultImg.UseVisualStyleBackColor = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Result Image";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Location = new System.Drawing.Point(6, 86);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 220);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // formThreshold
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 333);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCloseFormSub);
            this.Controls.Add(this.btnExecuteSubImg);
            this.Name = "formThreshold";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "formThreshold";
            ((System.ComponentModel.ISupportInitialize)(this.trbThreshold)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBaseImg)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBaseImg;
        private System.Windows.Forms.TextBox txtBaseImgPath;
        private System.Windows.Forms.Button btnNewBaseImg;
        private System.Windows.Forms.Button btnOpenBaseImg;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCloseFormSub;
        private System.Windows.Forms.Button btnExecuteSubImg;
        private System.Windows.Forms.TrackBar trbThreshold;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtThresholdValue;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtResultImgPath;
        private System.Windows.Forms.Button btnNewResultImg;
        private System.Windows.Forms.Button btnOpenResultImg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}