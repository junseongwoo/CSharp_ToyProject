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
        public delegate void OnChangeDataGridview(List<dgvTest> lstdgvTest);
        public event OnChangeDataGridview OnEventChageData;

        public FormControlValueChange()
        {
            InitializeComponent();
        }

        private void btnChangeDgvValue_Click(object sender, EventArgs e)
        {
            for (int i = 40; i < 50; i++)
            {
                Program.lstdvgTest.Add(new dgvTest() { Num = i + 1, DateTime = DateTime.Now, Speed = (i + 100).ToString(), Height = i.ToString(), Width = i.ToString() });
            }
            OnEventChageData?.Invoke(Program.lstdvgTest);
        }
    }
}
