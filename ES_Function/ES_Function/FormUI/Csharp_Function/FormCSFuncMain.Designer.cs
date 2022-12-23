
namespace ES_Function
{
    partial class FormCSFuncMain
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
            this.btnDgv = new System.Windows.Forms.Button();
            this.btnChangeValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnDgv
            // 
            this.btnDgv.Location = new System.Drawing.Point(12, 12);
            this.btnDgv.Name = "btnDgv";
            this.btnDgv.Size = new System.Drawing.Size(103, 38);
            this.btnDgv.TabIndex = 0;
            this.btnDgv.Text = "DataGridView";
            this.btnDgv.UseVisualStyleBackColor = true;
            this.btnDgv.Click += new System.EventHandler(this.btnDgv_Click);
            // 
            // btnChangeValue
            // 
            this.btnChangeValue.Location = new System.Drawing.Point(12, 291);
            this.btnChangeValue.Name = "btnChangeValue";
            this.btnChangeValue.Size = new System.Drawing.Size(103, 38);
            this.btnChangeValue.TabIndex = 1;
            this.btnChangeValue.Text = "Control 값 변경";
            this.btnChangeValue.UseVisualStyleBackColor = true;
            this.btnChangeValue.Click += new System.EventHandler(this.btnChangeValue_Click);
            // 
            // FormCSFuncMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(480, 341);
            this.Controls.Add(this.btnChangeValue);
            this.Controls.Add(this.btnDgv);
            this.Name = "FormCSFuncMain";
            this.Text = "FormCSFuncMain";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnDgv;
        private System.Windows.Forms.Button btnChangeValue;
    }
}