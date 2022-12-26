using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

/*
 * Class를 활용한 DataGridView DataSource 바인딩 
 */

namespace ES_Function
{
    public partial class FormDataGridView : Form
    {
        #region [필드]

        #endregion

        #region [생성자]
        List<dgvTest> lstdvgTest = new List<dgvTest>(); 
        #endregion

        public FormDataGridView()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            Vars.formControlValueChange = new FormControlValueChange();
            Vars.formControlValueChange.OnEventChageData += ChangeDgvDataSource;
        }

        private void FormDataGridView_Load(object sender, EventArgs e)
        {
            AddDgvDataSource();

            bindingSource1.DataSource = Program.lstdvgTest;
            dgvClassTest.DataSource = bindingSource1;
        }
        
        public void ChangeDgvDataSource(List<dgvTest> test)
        {
            BindingSource bs = new BindingSource();
            if (Vars.formControlValueChange?.InvokeRequired == true)
            {
                Vars.formControlValueChange.Invoke(new Action(delegate ()
                {
                    ChangeDgvDataSource(test);
                }));
            }

            bs.DataSource = test;
            dgvClassTest.DataSource = bs;
            dgvClassTest.Update();
            dgvTestBindingSource.ResetBindings(false);

        }

        public void AddDgvDataSource()
        {
            for (int i = 0; i < 30; i++)
            {
                Program.lstdvgTest.Add(new dgvTest() { Num = i + 1, DateTime = DateTime.Now, Speed = (i + 100).ToString(), Height = i.ToString(), Width = i.ToString() });
            }
        }

        private void OnChangeDataGridview(dgvTest test)
        {
            lstdvgTest.Add(test);
        }

        private void btnChangeValue_Click(object sender, EventArgs e)
        {
            Vars.formControlValueChange.Show();
        }
    }




}