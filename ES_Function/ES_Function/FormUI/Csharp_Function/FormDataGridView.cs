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
        public delegate void OnDataGridview(dgvTest lstdvgTest);
        public event OnDataGridview EventHandlerTest;

        #endregion

        #region [생성자]
        public static List<dgvTest> lstdvgTest = new List<dgvTest>();
        #endregion

        public FormDataGridView()
        {
            InitializeComponent();
        }

        private void FormDataGridView_Load(object sender, EventArgs e)
        {
            AddDgvDataSource();

            bindingSource1.DataSource = lstdvgTest;
            dgvClassTest.DataSource = bindingSource1;

            //dgvClassTest.DataSource = lstdvgTest;
        }
        
        public void ChangeDgvDataSource(List<dgvTest> test)
        {

            dgvTestBindingSource.DataSource = test;
            dgvClassTest.DataSource = dgvTestBindingSource;
            dgvTestBindingSource.ResetBindings(false);

        }

        public void AddDgvDataSource()
        {
            for (int i = 0; i < 30; i++)
            {
                lstdvgTest.Add(new dgvTest() { Num = i + 1, DateTime = DateTime.Now, Speed = (i + 100).ToString(), Height = i.ToString(), Width = i.ToString() });
            }
        }

        private void OnChangeDataGridview(dgvTest test)
        {
            lstdvgTest.Add(test);
        }
    }
    public class dgvTest
    {
        public int Num { get; set; }
        public DateTime DateTime { get; set; }
        public string Speed { get; set; }
        public string Height { get; set; }
        public string Width { get; set; }
    }



}