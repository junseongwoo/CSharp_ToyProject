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
    public partial class FormCSFuncMain : Form
    {
        #region [필드]
        #endregion

        #region [생성자]
        public FormCSFuncMain()
        {
            InitializeComponent();

            Initialize();

        }

        #region [멤버 함수 : 이벤트 연결]

        #endregion
        #region [초기화]
        private void Initialize()
        {
            Vars.formDataGridView = new FormDataGridView();
            Vars.formControlValueChange = new FormControlValueChange();
        }
        #endregion

        private void btnDgv_Click(object sender, EventArgs e)
        {
            Vars.formDataGridView = new FormDataGridView();

            Vars.formDataGridView.Show();
        }

        private void btnChangeValue_Click(object sender, EventArgs e)
        {
            Vars.formControlValueChange.Show();
        }
        #endregion
    }
}
