
namespace ES_Function
{
    partial class FrmMain
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
            this.btnDeleteS6F1 = new System.Windows.Forms.Button();
            this.btnRS232 = new System.Windows.Forms.Button();
            this.btnReceiveRS232 = new System.Windows.Forms.Button();
            this.btnTCP_IPClient = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnTCP_IPTestServer = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnCreateMCC = new System.Windows.Forms.Button();
            this.btnFunction = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnDeleteS6F1
            // 
            this.btnDeleteS6F1.Location = new System.Drawing.Point(412, 8);
            this.btnDeleteS6F1.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteS6F1.Name = "btnDeleteS6F1";
            this.btnDeleteS6F1.Size = new System.Drawing.Size(139, 33);
            this.btnDeleteS6F1.TabIndex = 0;
            this.btnDeleteS6F1.Text = "Delete S6F1 Log Contents";
            this.btnDeleteS6F1.UseVisualStyleBackColor = true;
            this.btnDeleteS6F1.Click += new System.EventHandler(this.btnDeleteS6F1_Click);
            // 
            // btnRS232
            // 
            this.btnRS232.Location = new System.Drawing.Point(15, 18);
            this.btnRS232.Name = "btnRS232";
            this.btnRS232.Size = new System.Drawing.Size(139, 33);
            this.btnRS232.TabIndex = 1;
            this.btnRS232.Text = "RS232 ";
            this.btnRS232.UseVisualStyleBackColor = true;
            this.btnRS232.Click += new System.EventHandler(this.btnRS232_Click);
            // 
            // btnReceiveRS232
            // 
            this.btnReceiveRS232.Location = new System.Drawing.Point(15, 57);
            this.btnReceiveRS232.Name = "btnReceiveRS232";
            this.btnReceiveRS232.Size = new System.Drawing.Size(139, 33);
            this.btnReceiveRS232.TabIndex = 2;
            this.btnReceiveRS232.Text = "Receive RS232 ";
            this.btnReceiveRS232.UseVisualStyleBackColor = true;
            this.btnReceiveRS232.Click += new System.EventHandler(this.btnReceiveRS232_Click);
            // 
            // btnTCP_IPClient
            // 
            this.btnTCP_IPClient.Location = new System.Drawing.Point(11, 56);
            this.btnTCP_IPClient.Name = "btnTCP_IPClient";
            this.btnTCP_IPClient.Size = new System.Drawing.Size(139, 33);
            this.btnTCP_IPClient.TabIndex = 4;
            this.btnTCP_IPClient.Text = "TCP/IP Client";
            this.btnTCP_IPClient.UseVisualStyleBackColor = true;
            this.btnTCP_IPClient.Click += new System.EventHandler(this.btnTCP_IPClient_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnTCP_IPClient);
            this.groupBox1.Controls.Add(this.btnTCP_IPTestServer);
            this.groupBox1.Location = new System.Drawing.Point(398, 245);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(160, 106);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            // 
            // btnTCP_IPTestServer
            // 
            this.btnTCP_IPTestServer.Location = new System.Drawing.Point(11, 17);
            this.btnTCP_IPTestServer.Name = "btnTCP_IPTestServer";
            this.btnTCP_IPTestServer.Size = new System.Drawing.Size(139, 33);
            this.btnTCP_IPTestServer.TabIndex = 3;
            this.btnTCP_IPTestServer.Text = "TCP/IP Server";
            this.btnTCP_IPTestServer.UseVisualStyleBackColor = true;
            this.btnTCP_IPTestServer.Click += new System.EventHandler(this.btnTCP_IPTestServer_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnReceiveRS232);
            this.groupBox2.Controls.Add(this.btnRS232);
            this.groupBox2.Location = new System.Drawing.Point(398, 140);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(160, 99);
            this.groupBox2.TabIndex = 6;
            this.groupBox2.TabStop = false;
            // 
            // btnCreateMCC
            // 
            this.btnCreateMCC.Location = new System.Drawing.Point(413, 46);
            this.btnCreateMCC.Name = "btnCreateMCC";
            this.btnCreateMCC.Size = new System.Drawing.Size(139, 33);
            this.btnCreateMCC.TabIndex = 7;
            this.btnCreateMCC.Text = "Create MCC Log";
            this.btnCreateMCC.UseVisualStyleBackColor = true;
            this.btnCreateMCC.Click += new System.EventHandler(this.btnCreateMCC_Click);
            // 
            // btnFunction
            // 
            this.btnFunction.Location = new System.Drawing.Point(12, 12);
            this.btnFunction.Name = "btnFunction";
            this.btnFunction.Size = new System.Drawing.Size(94, 36);
            this.btnFunction.TabIndex = 8;
            this.btnFunction.Text = "C# 기능 구현";
            this.btnFunction.UseVisualStyleBackColor = true;
            this.btnFunction.Click += new System.EventHandler(this.btnFunction_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 363);
            this.Controls.Add(this.btnFunction);
            this.Controls.Add(this.btnCreateMCC);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteS6F1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteS6F1;
        private System.Windows.Forms.Button btnRS232;
        private System.Windows.Forms.Button btnReceiveRS232;
        private System.Windows.Forms.Button btnTCP_IPClient;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnCreateMCC;
        private System.Windows.Forms.Button btnTCP_IPTestServer;
        private System.Windows.Forms.Button btnFunction;
    }
}

