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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void btnDeleteS6F1_Click(object sender, EventArgs e)
        {
            FormDeleteS6F1 frmDeleteS6F1 = new FormDeleteS6F1();
            frmDeleteS6F1.Show();
        }
    }
}
