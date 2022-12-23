
namespace ES_Function
{
    partial class FormControlValueChange
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
            this.btnChangeDgvValue = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnChangeDgvValue
            // 
            this.btnChangeDgvValue.Location = new System.Drawing.Point(12, 12);
            this.btnChangeDgvValue.Name = "btnChangeDgvValue";
            this.btnChangeDgvValue.Size = new System.Drawing.Size(173, 55);
            this.btnChangeDgvValue.TabIndex = 0;
            this.btnChangeDgvValue.Text = "DataGridView 값 변경";
            this.btnChangeDgvValue.UseVisualStyleBackColor = true;
            this.btnChangeDgvValue.Click += new System.EventHandler(this.btnChangeDgvValue_Click);
            // 
            // FormControlValueChange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(475, 404);
            this.Controls.Add(this.btnChangeDgvValue);
            this.Name = "FormControlValueChange";
            this.Text = "Value Control";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnChangeDgvValue;
    }
}