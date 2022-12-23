using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_Function
{
    public partial class FormControlValueChange : Form
    {
        public List<dgvTest> lstdvgTest = new List<dgvTest>();
        public delegate void OnChangeDataGridview(dgvTest lstdvgTest);
        public event OnChangeDataGridview EventHandler;
        FormDataGridView formTest = new FormDataGridView();

        public FormControlValueChange()
        {
            InitializeComponent();
        }
        List<dgvTest> test = new List<dgvTest>();
        private void btnChangeDgvValue_Click(object sender, EventArgs e)
        {
            for (int i = 40; i < 50; i++)
            {

                test.Add(new dgvTest { Num = i, DateTime = DateTime.Now, Height = i.ToString(), Width = i.ToString(), Speed = i.ToString() });

            }

            formTest.ChangeDgvDataSource(test);
            formTest.Refresh();
            //EventHandler?.Invoke(test);
        }
    }
}
