
namespace ES_Function
{
    partial class FormDeleteS6F1
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.btnChangeContents = new System.Windows.Forms.Button();
            this.lblLogFilePath = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(8, 8);
            this.btnOpenFile.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(105, 41);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnChangeContents
            // 
            this.btnChangeContents.Location = new System.Drawing.Point(444, 11);
            this.btnChangeContents.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnChangeContents.Name = "btnChangeContents";
            this.btnChangeContents.Size = new System.Drawing.Size(105, 41);
            this.btnChangeContents.TabIndex = 1;
            this.btnChangeContents.Text = "Delete S6F1";
            this.btnChangeContents.UseVisualStyleBackColor = true;
            this.btnChangeContents.Click += new System.EventHandler(this.btnChangeContents_Click);
            // 
            // lblLogFilePath
            // 
            this.lblLogFilePath.AutoSize = true;
            this.lblLogFilePath.Location = new System.Drawing.Point(118, 22);
            this.lblLogFilePath.Name = "lblLogFilePath";
            this.lblLogFilePath.Size = new System.Drawing.Size(29, 12);
            this.lblLogFilePath.TabIndex = 2;
            this.lblLogFilePath.Text = "C:\\";
            // 
            // FormDeleteS6F1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(560, 163);
            this.Controls.Add(this.lblLogFilePath);
            this.Controls.Add(this.btnChangeContents);
            this.Controls.Add(this.btnOpenFile);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormDeleteS6F1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Delete S6F1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnChangeContents;
        private System.Windows.Forms.Label lblLogFilePath;
    }
}