
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
            System.Windows.Forms.TreeNode treeNode1 = new System.Windows.Forms.TreeNode("파일");
            System.Windows.Forms.TreeNode treeNode2 = new System.Windows.Forms.TreeNode("경로");
            System.Windows.Forms.TreeNode treeNode3 = new System.Windows.Forms.TreeNode("환경 설정", new System.Windows.Forms.TreeNode[] {
            treeNode1,
            treeNode2});
            this.tvwOption = new System.Windows.Forms.TreeView();
            this.pnlOption = new System.Windows.Forms.Panel();
            this.btnSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tvwOption
            // 
            this.tvwOption.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.tvwOption.Location = new System.Drawing.Point(8, 96);
            this.tvwOption.Margin = new System.Windows.Forms.Padding(2);
            this.tvwOption.Name = "tvwOption";
            treeNode1.Name = "nodeFile";
            treeNode1.Text = "파일";
            treeNode2.Name = "nodePath";
            treeNode2.Text = "경로";
            treeNode3.Checked = true;
            treeNode3.Name = "노드0";
            treeNode3.Text = "환경 설정";
            this.tvwOption.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode3});
            this.tvwOption.Size = new System.Drawing.Size(199, 340);
            this.tvwOption.TabIndex = 0;
            this.tvwOption.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.tvwOption_AfterSelect);
            this.tvwOption.NodeMouseClick += new System.Windows.Forms.TreeNodeMouseClickEventHandler(this.tvwOption_NodeMouseClick);
            // 
            // pnlOption
            // 
            this.pnlOption.Location = new System.Drawing.Point(211, 54);
            this.pnlOption.Margin = new System.Windows.Forms.Padding(2);
            this.pnlOption.Name = "pnlOption";
            this.pnlOption.Size = new System.Drawing.Size(498, 381);
            this.pnlOption.TabIndex = 1;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(612, 12);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(96, 37);
            this.btnSave.TabIndex = 2;
            this.btnSave.Text = "저장";
            this.btnSave.UseVisualStyleBackColor = true;
            // 
            // formOption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(720, 443);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.pnlOption);
            this.Controls.Add(this.tvwOption);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "formOption";
            this.Text = "Option";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView tvwOption;
        private System.Windows.Forms.Panel pnlOption;
        private System.Windows.Forms.Button btnSave;
    }
}