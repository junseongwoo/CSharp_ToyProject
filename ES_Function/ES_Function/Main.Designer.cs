
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
            this.btnTCP_IP = new System.Windows.Forms.Button();
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
            this.btnRS232.Location = new System.Drawing.Point(412, 64);
            this.btnRS232.Name = "btnRS232";
            this.btnRS232.Size = new System.Drawing.Size(139, 33);
            this.btnRS232.TabIndex = 1;
            this.btnRS232.Text = "RS232 ";
            this.btnRS232.UseVisualStyleBackColor = true;
            this.btnRS232.Click += new System.EventHandler(this.btnRS232_Click);
            // 
            // btnReceiveRS232
            // 
            this.btnReceiveRS232.Location = new System.Drawing.Point(412, 120);
            this.btnReceiveRS232.Name = "btnReceiveRS232";
            this.btnReceiveRS232.Size = new System.Drawing.Size(139, 33);
            this.btnReceiveRS232.TabIndex = 2;
            this.btnReceiveRS232.Text = "Receive RS232 ";
            this.btnReceiveRS232.UseVisualStyleBackColor = true;
            this.btnReceiveRS232.Click += new System.EventHandler(this.btnReceiveRS232_Click);
            // 
            // btnTCP_IP
            // 
            this.btnTCP_IP.Location = new System.Drawing.Point(412, 176);
            this.btnTCP_IP.Name = "btnTCP_IP";
            this.btnTCP_IP.Size = new System.Drawing.Size(139, 33);
            this.btnTCP_IP.TabIndex = 3;
            this.btnTCP_IP.Text = "TCP/IP";
            this.btnTCP_IP.UseVisualStyleBackColor = true;
            this.btnTCP_IP.Click += new System.EventHandler(this.btnTCP_IP_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 363);
            this.Controls.Add(this.btnTCP_IP);
            this.Controls.Add(this.btnReceiveRS232);
            this.Controls.Add(this.btnRS232);
            this.Controls.Add(this.btnDeleteS6F1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDeleteS6F1;
        private System.Windows.Forms.Button btnRS232;
        private System.Windows.Forms.Button btnReceiveRS232;
        private System.Windows.Forms.Button btnTCP_IP;
    }
}

