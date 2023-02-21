
namespace ESVision
{
    partial class formOption
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
            System.Windows.Forms.TreeNode treeNode4 = new System.Windows.Forms.TreeNode("경로");
            System.Windows.Forms.TreeNode treeNode5 = new System.Windows.Forms.TreeNode("파일");
            System.Windows.Forms.TreeNode treeNode6 = new System.Windows.Forms.TreeNode("환경 설정", new System.Windows.Forms.TreeNode[] {
            treeNode4,
            treeNode5});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.treeView1.Location = new System.Drawing.Point(12, 109);
            this.treeView1.Name = "treeView1";
            treeNode4.Name = "노드1";
            treeNode4.Text = "경로";
            treeNode5.Name = "노드0";
            treeNode5.Text = "파일";
            treeNode6.Checked = true;
            treeNode6.Name = "노드0";
            treeNode6.Text = "환경 설정";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode6});
            this.treeView1.Size = new System.Drawing.Size(283, 543);
            this.treeView1.TabIndex = 0;
            // 
            // pnlOption
            // 
            this.pnlOption.Location = new System.Drawing.Point(301, 51);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(715, 601);
            this.pnlOption.TabIndex = 1;
            // 
            // formOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1028, 664);
            this.Controls.Add(this.pnlOption);
            this.Controls.Add(this.treeView1);
            this.Name = "formOption";
            this.Text = "Option";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Panel pnlOption;
    }
}