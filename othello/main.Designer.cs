
namespace othello
{
    partial class frm_main
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
            this.btn_ReStart = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.picBox_GameBoard = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_GameBoard)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_ReStart
            // 
            this.btn_ReStart.Location = new System.Drawing.Point(3, 40);
            this.btn_ReStart.Name = "btn_ReStart";
            this.btn_ReStart.Size = new System.Drawing.Size(91, 29);
            this.btn_ReStart.TabIndex = 2;
            this.btn_ReStart.Text = "재시작";
            this.btn_ReStart.UseVisualStyleBackColor = true;
            // 
            // btn_Start
            // 
            this.btn_Start.Location = new System.Drawing.Point(3, 3);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(91, 31);
            this.btn_Start.TabIndex = 1;
            this.btn_Start.Text = "시작";
            this.btn_Start.UseVisualStyleBackColor = true;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 3;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 16.1103F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 83.88969F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 102F));
            this.tableLayoutPanel1.Controls.Add(this.picBox_GameBoard, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 2, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(879, 652);
            this.tableLayoutPanel1.TabIndex = 3;
            // 
            // picBox_GameBoard
            // 
            this.picBox_GameBoard.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox_GameBoard.Location = new System.Drawing.Point(128, 3);
            this.picBox_GameBoard.Name = "picBox_GameBoard";
            this.picBox_GameBoard.Size = new System.Drawing.Size(645, 646);
            this.picBox_GameBoard.TabIndex = 0;
            this.picBox_GameBoard.TabStop = false;
            this.picBox_GameBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_GameBoard_Paint);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btn_Start);
            this.panel2.Controls.Add(this.btn_ReStart);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(779, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(97, 646);
            this.panel2.TabIndex = 2;
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(879, 652);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Name = "frm_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Othello";
            this.Load += new System.EventHandler(this.frm_main_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_GameBoard)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btn_ReStart;
        private System.Windows.Forms.Button btn_Start;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox picBox_GameBoard;
        private System.Windows.Forms.Panel panel2;
    }
}

