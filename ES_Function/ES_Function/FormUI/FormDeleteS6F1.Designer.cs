
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
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(12, 12);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(150, 61);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // btnChangeContents
            // 
            this.btnChangeContents.Location = new System.Drawing.Point(638, 12);
            this.btnChangeContents.Name = "btnChangeContents";
            this.btnChangeContents.Size = new System.Drawing.Size(150, 61);
            this.btnChangeContents.TabIndex = 1;
            this.btnChangeContents.Text = "Delete S6F1";
            this.btnChangeContents.UseVisualStyleBackColor = true;
            this.btnChangeContents.Click += new System.EventHandler(this.btnChangeContents_Click);
            // 
            // FormDeleteS6F1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 244);
            this.Controls.Add(this.btnChangeContents);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "FormDeleteS6F1";
            this.Text = "Delete S6F1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.Button btnChangeContents;
    }
}