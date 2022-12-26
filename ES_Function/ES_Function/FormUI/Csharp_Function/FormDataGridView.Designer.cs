
namespace ES_Function
{
    partial class FormDataGridView
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
            this.components = new System.ComponentModel.Container();
            this.dgvClassTest = new System.Windows.Forms.DataGridView();
            this.numDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.speedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.heightDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.widthDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dgvTestBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.dgvTestBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnChangeValue = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassTest)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvClassTest
            // 
            this.dgvClassTest.AutoGenerateColumns = false;
            this.dgvClassTest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvClassTest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.numDataGridViewTextBoxColumn,
            this.dateTimeDataGridViewTextBoxColumn,
            this.speedDataGridViewTextBoxColumn,
            this.heightDataGridViewTextBoxColumn,
            this.widthDataGridViewTextBoxColumn});
            this.dgvClassTest.DataSource = this.dgvTestBindingSource1;
            this.dgvClassTest.Location = new System.Drawing.Point(12, 59);
            this.dgvClassTest.Name = "dgvClassTest";
            this.dgvClassTest.RowTemplate.Height = 23;
            this.dgvClassTest.Size = new System.Drawing.Size(593, 522);
            this.dgvClassTest.TabIndex = 0;
            // 
            // numDataGridViewTextBoxColumn
            // 
            this.numDataGridViewTextBoxColumn.DataPropertyName = "Num";
            this.numDataGridViewTextBoxColumn.HeaderText = "Num";
            this.numDataGridViewTextBoxColumn.Name = "numDataGridViewTextBoxColumn";
            // 
            // dateTimeDataGridViewTextBoxColumn
            // 
            this.dateTimeDataGridViewTextBoxColumn.DataPropertyName = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.HeaderText = "DateTime";
            this.dateTimeDataGridViewTextBoxColumn.Name = "dateTimeDataGridViewTextBoxColumn";
            // 
            // speedDataGridViewTextBoxColumn
            // 
            this.speedDataGridViewTextBoxColumn.DataPropertyName = "Speed";
            this.speedDataGridViewTextBoxColumn.HeaderText = "Speed";
            this.speedDataGridViewTextBoxColumn.Name = "speedDataGridViewTextBoxColumn";
            // 
            // heightDataGridViewTextBoxColumn
            // 
            this.heightDataGridViewTextBoxColumn.DataPropertyName = "Height";
            this.heightDataGridViewTextBoxColumn.HeaderText = "Height";
            this.heightDataGridViewTextBoxColumn.Name = "heightDataGridViewTextBoxColumn";
            // 
            // widthDataGridViewTextBoxColumn
            // 
            this.widthDataGridViewTextBoxColumn.DataPropertyName = "Width";
            this.widthDataGridViewTextBoxColumn.HeaderText = "Width";
            this.widthDataGridViewTextBoxColumn.Name = "widthDataGridViewTextBoxColumn";
            // 
            // dgvTestBindingSource1
            // 
            this.dgvTestBindingSource1.DataSource = typeof(ES_Function.dgvTest);
            // 
            // bindingSource1
            // 
            this.bindingSource1.DataSource = this.dgvTestBindingSource;
            // 
            // dgvTestBindingSource
            // 
            this.dgvTestBindingSource.DataSource = typeof(ES_Function.dgvTest);
            // 
            // btnChangeValue
            // 
            this.btnChangeValue.Location = new System.Drawing.Point(484, 12);
            this.btnChangeValue.Name = "btnChangeValue";
            this.btnChangeValue.Size = new System.Drawing.Size(121, 41);
            this.btnChangeValue.TabIndex = 1;
            this.btnChangeValue.Text = "button1";
            this.btnChangeValue.UseVisualStyleBackColor = true;
            this.btnChangeValue.Click += new System.EventHandler(this.btnChangeValue_Click);
            // 
            // FormDataGridView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 593);
            this.Controls.Add(this.btnChangeValue);
            this.Controls.Add(this.dgvClassTest);
            this.Name = "FormDataGridView";
            this.Text = "FormDataGridView";
            this.Load += new System.EventHandler(this.FormDataGridView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvClassTest)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTestBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvClassTest;
        private System.Windows.Forms.BindingSource dgvTestBindingSource;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn numDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn dateTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn speedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn heightDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn widthDataGridViewTextBoxColumn;
        private System.Windows.Forms.BindingSource dgvTestBindingSource1;
        private System.Windows.Forms.Button btnChangeValue;
    }
}