
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
            this.picBox_othello = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_othello)).BeginInit();
            this.SuspendLayout();
            // 
            // picBox_othello
            // 
            this.picBox_othello.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.picBox_othello.Location = new System.Drawing.Point(28, 81);
            this.picBox_othello.Name = "picBox_othello";
            this.picBox_othello.Size = new System.Drawing.Size(652, 494);
            this.picBox_othello.TabIndex = 0;
            this.picBox_othello.TabStop = false;
            this.picBox_othello.Paint += new System.Windows.Forms.PaintEventHandler(this.picBox_othello_Paint);
            // 
            // frm_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 587);
            this.Controls.Add(this.picBox_othello);
            this.Name = "frm_main";
            this.Text = "Othello";
            this.Load += new System.EventHandler(this.frm_main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_othello)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox picBox_othello;
    }
}

