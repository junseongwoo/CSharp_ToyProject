
namespace SemContrlloer
{
    partial class MainForm
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.cboBaudrateRS232 = new System.Windows.Forms.ComboBox();
            this.cboPortNumRS232 = new System.Windows.Forms.ComboBox();
            this.btnCheckRS232 = new System.Windows.Forms.Button();
            this.btnOpenRS232 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPortNumTCPIP = new System.Windows.Forms.ComboBox();
            this.cboIPNumTCPIP = new System.Windows.Forms.ComboBox();
            this.btnCheckTCPIP = new System.Windows.Forms.Button();
            this.btnOpenTCPIP = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.bwReceiveRS232 = new System.ComponentModel.BackgroundWorker();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
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
            this.cboBaudrateRS232.Location = new System.Drawing.Point(88, 96);
            this.cboBaudrateRS232.Name = "cboBaudrateRS232";
            this.cboBaudrateRS232.Size = new System.Drawing.Size(104, 20);
            this.cboBaudrateRS232.TabIndex = 15;
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
            this.cboPortNumRS232.Location = new System.Drawing.Point(88, 71);
            this.cboPortNumRS232.Name = "cboPortNumRS232";
            this.cboPortNumRS232.Size = new System.Drawing.Size(104, 20);
            this.cboPortNumRS232.TabIndex = 14;
            // 
            // btnCheckRS232
            // 
            this.btnCheckRS232.BackColor = System.Drawing.Color.Red;
            this.btnCheckRS232.Location = new System.Drawing.Point(173, 25);
            this.btnCheckRS232.Name = "btnCheckRS232";
            this.btnCheckRS232.Size = new System.Drawing.Size(23, 24);
            this.btnCheckRS232.TabIndex = 13;
            this.btnCheckRS232.UseVisualStyleBackColor = false;
            // 
            // btnOpenRS232
            // 
            this.btnOpenRS232.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOpenRS232.Location = new System.Drawing.Point(118, 134);
            this.btnOpenRS232.Name = "btnOpenRS232";
            this.btnOpenRS232.Size = new System.Drawing.Size(74, 32);
            this.btnOpenRS232.TabIndex = 12;
            this.btnOpenRS232.Text = "Open";
            this.btnOpenRS232.UseVisualStyleBackColor = true;
            this.btnOpenRS232.Click += new System.EventHandler(this.btnOpenRS232_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.Desktop;
            this.label3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label3.Location = new System.Drawing.Point(17, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "baudrate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.Desktop;
            this.label2.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label2.Location = new System.Drawing.Point(17, 75);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 12);
            this.label2.TabIndex = 10;
            this.label2.Text = "Port";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.Location = new System.Drawing.Point(17, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "RS232              ";
            // 
            // cboPortNumTCPIP
            // 
            this.cboPortNumTCPIP.FormattingEnabled = true;
            this.cboPortNumTCPIP.Items.AddRange(new object[] {
            "9000",
            "9001"});
            this.cboPortNumTCPIP.Location = new System.Drawing.Point(88, 283);
            this.cboPortNumTCPIP.Name = "cboPortNumTCPIP";
            this.cboPortNumTCPIP.Size = new System.Drawing.Size(104, 20);
            this.cboPortNumTCPIP.TabIndex = 22;
            // 
            // cboIPNumTCPIP
            // 
            this.cboIPNumTCPIP.FormattingEnabled = true;
            this.cboIPNumTCPIP.Items.AddRange(new object[] {
            "192.168.100.200"});
            this.cboIPNumTCPIP.Location = new System.Drawing.Point(88, 258);
            this.cboIPNumTCPIP.Name = "cboIPNumTCPIP";
            this.cboIPNumTCPIP.Size = new System.Drawing.Size(104, 20);
            this.cboIPNumTCPIP.TabIndex = 21;
            // 
            // btnCheckTCPIP
            // 
            this.btnCheckTCPIP.BackColor = System.Drawing.Color.Red;
            this.btnCheckTCPIP.Location = new System.Drawing.Point(173, 212);
            this.btnCheckTCPIP.Name = "btnCheckTCPIP";
            this.btnCheckTCPIP.Size = new System.Drawing.Size(23, 24);
            this.btnCheckTCPIP.TabIndex = 20;
            this.btnCheckTCPIP.UseVisualStyleBackColor = false;
            // 
            // btnOpenTCPIP
            // 
            this.btnOpenTCPIP.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnOpenTCPIP.Location = new System.Drawing.Point(118, 321);
            this.btnOpenTCPIP.Name = "btnOpenTCPIP";
            this.btnOpenTCPIP.Size = new System.Drawing.Size(74, 32);
            this.btnOpenTCPIP.TabIndex = 19;
            this.btnOpenTCPIP.Text = "Open";
            this.btnOpenTCPIP.UseVisualStyleBackColor = true;
            this.btnOpenTCPIP.Click += new System.EventHandler(this.btnOpenTCPIP_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.SystemColors.Desktop;
            this.label4.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label4.Location = new System.Drawing.Point(17, 286);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 12);
            this.label4.TabIndex = 18;
            this.label4.Text = "Port";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.Desktop;
            this.label5.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label5.Location = new System.Drawing.Point(17, 262);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(16, 12);
            this.label5.TabIndex = 17;
            this.label5.Text = "IP";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label6.Location = new System.Drawing.Point(17, 219);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(188, 20);
            this.label6.TabIndex = 16;
            this.label6.Text = "TCP/IP              ";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cboPortNumTCPIP);
            this.groupBox1.Controls.Add(this.cboIPNumTCPIP);
            this.groupBox1.Controls.Add(this.btnCheckTCPIP);
            this.groupBox1.Controls.Add(this.btnOpenTCPIP);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.cboBaudrateRS232);
            this.groupBox1.Controls.Add(this.cboPortNumRS232);
            this.groupBox1.Controls.Add(this.btnCheckRS232);
            this.groupBox1.Controls.Add(this.btnOpenRS232);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Control;
            this.groupBox1.Location = new System.Drawing.Point(10, 30);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(215, 377);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Connection";
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
            this.dataGridView1.Location = new System.Drawing.Point(244, 69);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(303, 338);
            this.dataGridView1.TabIndex = 25;
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("굴림", 15F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label7.Location = new System.Drawing.Point(243, 37);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(305, 20);
            this.label7.TabIndex = 26;
            this.label7.Text = "Data View                         ";
            // 
            // bwReceiveRS232
            // 
            this.bwReceiveRS232.WorkerReportsProgress = true;
            this.bwReceiveRS232.WorkerSupportsCancellation = true;
            this.bwReceiveRS232.DoWork += new System.ComponentModel.DoWorkEventHandler(this.bwReceiveRS232_DoWork);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(568, 420);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.Name = "MainForm";
            this.Text = "Sem Controller";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboBaudrateRS232;
        private System.Windows.Forms.ComboBox cboPortNumRS232;
        private System.Windows.Forms.Button btnCheckRS232;
        private System.Windows.Forms.Button btnOpenRS232;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboPortNumTCPIP;
        private System.Windows.Forms.ComboBox cboIPNumTCPIP;
        private System.Windows.Forms.Button btnCheckTCPIP;
        private System.Windows.Forms.Button btnOpenTCPIP;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.Label label7;
        private System.ComponentModel.BackgroundWorker bwReceiveRS232;
    }
}

