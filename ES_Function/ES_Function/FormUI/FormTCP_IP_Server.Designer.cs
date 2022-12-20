
namespace ES_Function.FormUI
{
    partial class FormTCP_IP_Server
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
            this.bwTcpIpServer = new System.ComponentModel.BackgroundWorker();
            this.lblSendCheck = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblLogFilePath = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnSendTCPIP = new System.Windows.Forms.Button();
            this.cboPortNum = new System.Windows.Forms.ComboBox();
            this.cboIPNum = new System.Windows.Forms.ComboBox();
            this.btnCheckRS232 = new System.Windows.Forms.Button();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bwTcpIpServer
            // 
            this.bwTcpIpServer.WorkerReportsProgress = true;
            this.bwTcpIpServer.WorkerSupportsCancellation = true;
            this.bwTcpIpServer.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwTcpIpServer_DoWork);
            // 
            // lblSendCheck
            // 
            this.lblSendCheck.AutoSize = true;
            this.lblSendCheck.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblSendCheck.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblSendCheck.Location = new System.Drawing.Point(408, 72);
            this.lblSendCheck.Name = "lblSendCheck";
            this.lblSendCheck.Size = new System.Drawing.Size(32, 12);
            this.lblSendCheck.TabIndex = 27;
            this.lblSendCheck.Text = "false";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.SystemColors.Desktop;
            this.label6.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label6.Location = new System.Drawing.Point(278, 72);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(82, 12);
            this.label6.TabIndex = 26;
            this.label6.Text = "Start Check : ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(278, 97);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 12);
            this.label5.TabIndex = 25;
            this.label5.Text = "Data : ";
            // 
            // lblLogFilePath
            // 
            this.lblLogFilePath.AutoSize = true;
            this.lblLogFilePath.BackColor = System.Drawing.SystemColors.Desktop;
            this.lblLogFilePath.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.lblLogFilePath.Location = new System.Drawing.Point(331, 97);
            this.lblLogFilePath.Name = "lblLogFilePath";
            this.lblLogFilePath.Size = new System.Drawing.Size(109, 12);
            this.lblLogFilePath.TabIndex = 24;
            this.lblLogFilePath.Text = "C:\\                    ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label4.Location = new System.Drawing.Point(276, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 20);
            this.label4.TabIndex = 23;
            this.label4.Text = "Send              ";
            // 
            // btnSendTCPIP
            // 
            this.btnSendTCPIP.Location = new System.Drawing.Point(370, 132);
            this.btnSendTCPIP.Name = "btnSendTCPIP";
            this.btnSendTCPIP.Size = new System.Drawing.Size(74, 32);
            this.btnSendTCPIP.TabIndex = 22;
            this.btnSendTCPIP.Text = "Send Start";
            this.btnSendTCPIP.UseVisualStyleBackColor = true;
            this.btnSendTCPIP.Click += new System.EventHandler(this.btnSendTCPIP_Click);
            // 
            // cboPortNum
            // 
            this.cboPortNum.FormattingEnabled = true;
            this.cboPortNum.Items.AddRange(new object[] {
            "9000",
            "9001"});
            this.cboPortNum.Location = new System.Drawing.Point(94, 94);
            this.cboPortNum.Name = "cboPortNum";
            this.cboPortNum.Size = new System.Drawing.Size(116, 20);
            this.cboPortNum.TabIndex = 21;
            // 
            // cboIPNum
            // 
            this.cboIPNum.FormattingEnabled = true;
            this.cboIPNum.Items.AddRange(new object[] {
            "192.168.100.200",
            "192.168.100.199",
            "192.168.100.198"});
            this.cboIPNum.Location = new System.Drawing.Point(94, 69);
            this.cboIPNum.Name = "cboIPNum";
            this.cboIPNum.Size = new System.Drawing.Size(116, 20);
            this.cboIPNum.TabIndex = 20;
            // 
            // btnCheckRS232
            // 
            this.btnCheckRS232.BackColor = System.Drawing.Color.Red;
            this.btnCheckRS232.Location = new System.Drawing.Point(191, 23);
            this.btnCheckRS232.Name = "btnCheckRS232";
            this.btnCheckRS232.Size = new System.Drawing.Size(23, 24);
            this.btnCheckRS232.TabIndex = 19;
            this.btnCheckRS232.UseVisualStyleBackColor = false;
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(136, 132);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(74, 32);
            this.btnConnect.TabIndex = 18;
            this.btnConnect.Text = "Open";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(35, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 12);
            this.label3.TabIndex = 17;
            this.label3.Text = "Port";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.Desktop;
            this.label7.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label7.Location = new System.Drawing.Point(35, 73);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(16, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "IP";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("굴림", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label8.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label8.Location = new System.Drawing.Point(35, 30);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(184, 20);
            this.label8.TabIndex = 15;
            this.label8.Text = "RS232              ";
            // 
            // FormTCP_IP_Server
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(503, 213);
            this.Controls.Add(this.lblSendCheck);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.lblLogFilePath);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btnSendTCPIP);
            this.Controls.Add(this.cboPortNum);
            this.Controls.Add(this.cboIPNum);
            this.Controls.Add(this.btnCheckRS232);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label8);
            this.Name = "FormTCP_IP_Server";
            this.Text = "TCP/IP Server";
            this.Load += new System.EventHandler(this.FormTCP_IP_Server_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.ComponentModel.BackgroundWorker bwTcpIpServer;
        private System.Windows.Forms.Label lblSendCheck;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label lblLogFilePath;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnSendTCPIP;
        private System.Windows.Forms.ComboBox cboPortNum;
        private System.Windows.Forms.ComboBox cboIPNum;
        private System.Windows.Forms.Button btnCheckRS232;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
    }
}