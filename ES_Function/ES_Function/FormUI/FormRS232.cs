using ES_Function.Com;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_Function.FormUI
{
    public partial class FormRS232 : Form
    {
        #region 생성자
        RS232 serial = new RS232();
        #endregion

        public FormRS232()
        {
            InitializeComponent();
        }

        private void FormRS232_Load(object sender, EventArgs e)
        {
            InitComboBox();
        }

        #region ComboBox Init
        private void InitComboBox()
        {
            cboBaudrateRS232.SelectedIndex = 0;
            cboPortNumRS232.SelectedIndex = 0;
        }
        #endregion

        #region RS232 Open/Close 버튼 
        private void btnOpenRS232_Click(object sender, EventArgs e)
        {
            if (serial.IsOpened())
            {
                serial.Open(cboPortNumRS232.Text, Convert.ToInt32(cboBaudrateRS232.Text));

                btnCheckRS232.BackColor = Color.Lime;
                btnOpenRS232.Text = "Close";
            }
            else
            {
                serial.Close();

                btnCheckRS232.BackColor = Color.Red;
                btnOpenRS232.Text = "Open";
            }
        }
        #endregion

        #region RS232 메세지 송신
        private void btnSendRS232_Click(object sender, EventArgs e)
        {

        }
        #endregion


    }
}
