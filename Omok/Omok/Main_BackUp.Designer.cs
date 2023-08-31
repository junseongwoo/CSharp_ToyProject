
namespace Omok
{
    partial class Main_Backup
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.mspMain = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.보기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.그리기ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.이미지ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pnlMain.SuspendLayout();
            this.mspMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.mspMain);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(800, 450);
            this.pnlMain.TabIndex = 0;
            this.pnlMain.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlMain_Paint);
            this.pnlMain.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pnlMain_MouseDown);
            // 
            // mspMain
            // 
            this.mspMain.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.mspMain.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.mspMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.보기ToolStripMenuItem});
            this.mspMain.Location = new System.Drawing.Point(0, 0);
            this.mspMain.Name = "mspMain";
            this.mspMain.Size = new System.Drawing.Size(800, 33);
            this.mspMain.TabIndex = 0;
            this.mspMain.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.파일ToolStripMenuItem.Text = "파일";
            // 
            // 보기ToolStripMenuItem
            // 
            this.보기ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.그리기ToolStripMenuItem,
            this.이미지ToolStripMenuItem});
            this.보기ToolStripMenuItem.Name = "보기ToolStripMenuItem";
            this.보기ToolStripMenuItem.Size = new System.Drawing.Size(64, 29);
            this.보기ToolStripMenuItem.Text = "보기";
            // 
            // 그리기ToolStripMenuItem
            // 
            this.그리기ToolStripMenuItem.Name = "그리기ToolStripMenuItem";
            this.그리기ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.그리기ToolStripMenuItem.Text = "그리기";
            this.그리기ToolStripMenuItem.Click += new System.EventHandler(this.그리기ToolStripMenuItem_Click);
            // 
            // 이미지ToolStripMenuItem
            // 
            this.이미지ToolStripMenuItem.Name = "이미지ToolStripMenuItem";
            this.이미지ToolStripMenuItem.Size = new System.Drawing.Size(270, 34);
            this.이미지ToolStripMenuItem.Text = "이미지";
            this.이미지ToolStripMenuItem.Click += new System.EventHandler(this.이미지ToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pnlMain);
            this.MainMenuStrip = this.mspMain;
            this.Name = "Main";
            this.Text = "Main";
            this.pnlMain.ResumeLayout(false);
            this.pnlMain.PerformLayout();
            this.mspMain.ResumeLayout(false);
            this.mspMain.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.MenuStrip mspMain;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 보기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 그리기ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 이미지ToolStripMenuItem;
    }
}

