﻿
namespace ES_Function.FormUI
{
    partial class FormRS232
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnOpenRS232 = new System.Windows.Forms.Button();
            this.btnCheckRS232 = new System.Windows.Forms.Button();
            this.cboPortNumRS232 = new System.Windows.Forms.ComboBox();
            this.cboBaudrateRS232 = new System.Windows.Forms.ComboBox();
            this.btnSendRS232 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.bwRS232 = new System.ComponentModel.BackgroundWorker();
            this.lblLogFilePath = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblSendCheck = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(12, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "RS232              ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(12, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "Port";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(12, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "baudrate";
            // 
            // btnOpenRS232
            // 
            this.btnOpenRS232.Location = new System.Drawing.Point(113, 124);
            this.btnOpenRS232.Name = "btnOpenRS232";
            this.btnOpenRS232.Size = new System.Drawing.Size(74, 32);
            this.btnOpenRS232.TabIndex = 5;
            this.btnOpenRS232.Text = "Open";
            this.btnOpenRS232.UseVisualStyleBackColor = true;
            this.btnOpenRS232.Click += new System.EventHandler(this.btnOpenRS232_Click);
            // 
            // btnCheckRS232
            // 
            this.btnCheckRS232.BackColor = System.Drawing.Color.Red;
            this.btnCheckRS232.Location = new System.Drawing.Point(168, 15);
            this.btnCheckRS232.Name = "btnCheckRS232";
            this.btnCheckRS232.Size = new System.Drawing.Size(23, 24);
            this.btnCheckRS232.TabIndex = 6;
            this.btnCheckRS232.UseVisualStyleBackColor = false;
            // 
            // cboPortNumRS232
            // 
            this.cboPortNumRS232.FormattingEnabled = true;
            this.cboPortNumRS232.Items.AddRange(new object[] {
            "COM1",
            "COM2",
            "COM3",
            "COM4",
            "COM5",
            "COM6",
            "COM7",
            "COM8",
            "COM9",
            "COM10",
            "COM11",
            "COM12",
            "COM13",
            "COM14",
            "COM15",
            "COM16",
            "COM17",
            "COM18",
            "COM19",
            "COM20"});
            this.cboPortNumRS232.Location = new System.Drawing.Point(83, 61);
            this.cboPortNumRS232.Name = "cboPortNumRS232";
            this.cboPortNumRS232.Size = new System.Drawing.Size(104, 20);
            this.cboPortNumRS232.TabIndex = 7;
            // 
            // cboBaudrateRS232
            // 
            this.cboBaudrateRS232.FormattingEnabled = true;
            this.cboBaudrateRS232.Items.AddRange(new object[] {
            "9600",
            "14400",
            "19200",
            "115200",
            "128000"});
            this.cboBaudrateRS232.Location = new System.Drawing.Point(83, 86);
            this.cboBaudrateRS232.Name = "cboBaudrateRS232";
            this.cboBaudrateRS232.Size = new System.Drawing.Size(104, 20);
            this.cboBaudrateRS232.TabIndex = 8;
            // 
            // btnSendRS232
            // 
            this.btnSendRS232.Location = new System.Drawing.Point(347, 124);
            this.btnSendRS232.Name = "btnSendRS232";
            this.btnSendRS232.Size = new System.Drawing.Size(74, 32);
            this.btnSendRS232.TabIndex = 9;
            this.btnSendRS232.Text = "Send Start";
            this.btnSendRS232.UseVisualStyleBackColor = true;
            this.btnSendRS232.Click += new System.EventHandler(this.btnSendRS232_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(253, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Send              ";
            // 
            // bwRS232
            // 
            this.bwRS232.WorkerReportsProgress = true;
            this.bwRS232.WorkerSupportsCancellation = true;
            this.bwRS232.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwRS232_DoWork);
            // 
            // lblLogFilePath
            // 
            this.lblLogFilePath.AutoSize = true;
            this.lblLogFilePath.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblLogFilePath.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLogFilePath.Location = new System.Drawing.Point(308, 89);
            this.lblLogFilePath.Name = "lblLogFilePath";
            this.lblLogFilePath.Size = new System.Drawing.Size(109, 12);
            this.lblLogFilePath.TabIndex = 11;
            this.lblLogFilePath.Text = "C:\\                    ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(255, 89);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data : ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Desktop;
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(255, 64);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "Start Check : ";
            // 
            // lblSendCheck
            // 
            this.lblSendCheck.AutoSize = true;
            this.lblSendCheck.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblSendCheck.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSendCheck.Location = new System.Drawing.Point(385, 64);
            this.lblSendCheck.Name = "lblSendCheck";
            this.lblSendCheck.Size = new System.Drawing.Size(32, 12);
            this.lblSendCheck.TabIndex = 14;
            this.lblSendCheck.Text = "false";
            // 
            // FormRS232
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(497, 211);
            this.Controls.Add(this.lblSendCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLogFilePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSendRS232);
            this.Controls.Add(this.cboBaudrateRS232);
            this.Controls.Add(this.cboPortNumRS232);
            this.Controls.Add(this.btnCheckRS232);
            this.Controls.Add(this.btnOpenRS232);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormRS232";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormRS232";
            this.Load += new System.EventHandler(this.FormRS232_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnOpenRS232;
        private System.Windows.Forms.Button btnCheckRS232;
        private System.Windows.Forms.ComboBox cboPortNumRS232;
        private System.Windows.Forms.ComboBox cboBaudrateRS232;
        private System.Windows.Forms.Button btnSendRS232;
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker bwRS232;
        private System.Windows.Forms.Label lblLogFilePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSendCheck;
    }
}