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
    public partial class FormReceiveRS232 : Form
    {
        #region 생성자

        #endregion
        public FormReceiveRS232()
        {
            InitializeComponent();
        }

        private void FormReceiveRS232_Load(object sender, EventArgs e)
        {
            Init();
        }

        #region 초기화
        private void Init()
        {
            cboPortNumRS232.SelectedIndex = 0;
            cboBaudrateRS232.SelectedIndex = 0;
        }
        #endregion

        private void btnOpenRS232_Click(object sender, EventArgs e)
        {

        }

        private void bwReceiveRS232_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {

            }
            catch (Exception ex)
            {
                MessageBox.Show("DoWork 에러" + ex.ToString());
            }
        }
    }
}
