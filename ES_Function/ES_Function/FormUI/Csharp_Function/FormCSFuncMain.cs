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
        public FormDataGridView formDataGridView = null;

        public FormControlValueChange formControlValueChange = null;
        #endregion

        #region [생성자]
        public FormCSFuncMain()
        {
            InitializeComponent();

            Initialize();

            ConnetEvent();
        }

        #region [멤버 함수 : 이벤트 연결]

        #endregion
        private void ConnetEvent()
        {

        }
        #endregion

        #region [초기화]
        private void Initialize()
        {
            formDataGridView = new FormDataGridView();
            formControlValueChange = new FormControlValueChange();
        }
        #endregion

        private void btnDgv_Click(object sender, EventArgs e)
        {
            formDataGridView.Show();
        }

        private void btnChangeValue_Click(object sender, EventArgs e)
        {
            formControlValueChange.EventHandler += OnEventTest;
            formControlValueChange.Show();
        }

        private void OnEventTest(dgvTest lstdvgTest)
        {

        }
    }
}
