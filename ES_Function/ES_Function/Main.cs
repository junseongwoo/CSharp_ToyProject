using ES_Function.FormUI;
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

        private void btnRS232_Click(object sender, EventArgs e)
        {
            FormRS232 frmRS232 = new FormRS232();
            frmRS232.Show();
        }

        private void btnReceiveRS232_Click(object sender, EventArgs e)
        {
            FormReceiveRS232 frmReceiveRS232 = new FormReceiveRS232();
            frmReceiveRS232.Show();
        }

        private void btnTCP_IP_Click(object sender, EventArgs e)
        {
            FormTCP_IP frmTCP_IP = new FormTCP_IP();
            frmTCP_IP.Show();
        }
    }
}
