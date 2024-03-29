﻿
namespace ES_Function
{
    partial class FormReceiveRS232
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
            this.label4 = new System.Windows.Forms.Label();
            this.bwReceiveRS232 = new System.ComponentModel.BackgroundWorker();
            this.label7 = new System.Windows.Forms.Label();
            this.lblLogFilePath = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnReceiveStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(232, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Receive              ";
            // 
            // bwReceiveRS232
            // 
            this.bwReceiveRS232.WorkerReportsProgress = true;
            this.bwReceiveRS232.WorkerSupportsCancellation = true;
            this.bwReceiveRS232.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwReceiveRS232_DoWork);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Desktop;
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(144, 189);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(36, 12);
            this.label7.TabIndex = 14;
            this.label7.Text = "False";
            this.label7.Visible = false;
            // 
            // lblLogFilePath
            // 
            this.lblLogFilePath.AutoSize = true;
            this.lblLogFilePath.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblLogFilePath.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLogFilePath.Location = new System.Drawing.Point(62, 214);
            this.lblLogFilePath.Name = "lblLogFilePath";
            this.lblLogFilePath.Size = new System.Drawing.Size(29, 12);
            this.lblLogFilePath.TabIndex = 11;
            this.lblLogFilePath.Text = "C:\\";
            this.lblLogFilePath.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(14, 214);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 12);
            this.label5.TabIndex = 12;
            this.label5.Text = "Data : ";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Desktop;
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(14, 189);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 12);
            this.label6.TabIndex = 13;
            this.label6.Text = "Start Check : ";
            this.label6.Visible = false;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dataGridView1.Location = new System.Drawing.Point(236, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(303, 338);
            this.dataGridView1.TabIndex = 15;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "SVID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 60;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "SVNAME";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Value";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // btnReceiveStart
            // 
            this.btnReceiveStart.Location = new System.Drawing.Point(435, 11);
            this.btnReceiveStart.Name = "btnReceiveStart";
            this.btnReceiveStart.Size = new System.Drawing.Size(103, 33);
            this.btnReceiveStart.TabIndex = 16;
            this.btnReceiveStart.Text = "Receive Start";
            this.btnReceiveStart.UseVisualStyleBackColor = true;
            this.btnReceiveStart.Click += new System.EventHandler(this.btnReceiveStart_Click);
            // 
            // FormReceiveRS232
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(560, 411);
            this.Controls.Add(this.btnReceiveStart);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLogFilePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboBaudrateRS232);
            this.Controls.Add(this.cboPortNumRS232);
            this.Controls.Add(this.btnCheckRS232);
            this.Controls.Add(this.btnOpenRS232);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormReceiveRS232";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormReceiveRS232";
            this.Load += new System.EventHandler(this.FormReceiveRS232_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private System.Windows.Forms.Label label4;
        private System.ComponentModel.BackgroundWorker bwReceiveRS232;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label lblLogFilePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Button btnReceiveStart;
    }
}