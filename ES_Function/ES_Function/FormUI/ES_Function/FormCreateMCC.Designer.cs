
namespace ES_Function
{
    partial class FormCreateMCC
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
            this.btnCreate_AMAU = new System.Windows.Forms.Button();
            this.btnCreate_LD = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreate_AMAU
            // 
            this.btnCreate_AMAU.Location = new System.Drawing.Point(250, 12);
            this.btnCreate_AMAU.Name = "btnCreate_AMAU";
            this.btnCreate_AMAU.Size = new System.Drawing.Size(105, 46);
            this.btnCreate_AMAU.TabIndex = 0;
            this.btnCreate_AMAU.Text = "AMAU Log 생성";
            this.btnCreate_AMAU.UseVisualStyleBackColor = true;
            this.btnCreate_AMAU.Click += new System.EventHandler(this.btnCreate_AMAU_Click);
            // 
            // btnCreate_LD
            // 
            this.btnCreate_LD.Location = new System.Drawing.Point(250, 95);
            this.btnCreate_LD.Name = "btnCreate_LD";
            this.btnCreate_LD.Size = new System.Drawing.Size(105, 46);
            this.btnCreate_LD.TabIndex = 1;
            this.btnCreate_LD.Text = "LD Log 생성";
            this.btnCreate_LD.UseVisualStyleBackColor = true;
            this.btnCreate_LD.Click += new System.EventHandler(this.btnCreate_LD_Click);
            // 
            // FormCreateMCC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 328);
            this.Controls.Add(this.btnCreate_LD);
            this.Controls.Add(this.btnCreate_AMAU);
            this.Name = "FormCreateMCC";
            this.Text = "Create MCC";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreate_AMAU;
        private System.Windows.Forms.Button btnCreate_LD;
    }
}