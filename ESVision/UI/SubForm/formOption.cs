using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESVision
{
    public partial class formOption : Form
    {
        #region [이벤트 : Option Tree View Node 클릭 시 Option View]
        public delegate void OnEventOptionTreeNodeViewHandler(EOPTION_VIEW_LIST optionList);
        public event OnEventOptionTreeNodeViewHandler OnEventOptionView;
        #endregion

        public formOption()
        {
            InitializeComponent();

            Initialize();
        }

        #region [초기화]
        private void Initialize()
        {

        }
        #endregion

        private void tvwOption_NodeMouseClick(object sender, TreeNodeMouseClickEventArgs e)
        {
            
        }

        private void tvwOption_AfterSelect(object sender, TreeViewEventArgs e)
        {
            switch (tvwOption.SelectedNode.Name)
            {
                case "nodeFile" :
                    {
                        OnEventOptionView?.Invoke(EOPTION_VIEW_LIST.FORM_FILE_OPTION);
                        break;
                    }
                case "nodePath":
                    {
                        OnEventOptionView?.Invoke(EOPTION_VIEW_LIST.FORM_PATH_OPTION);
                        break;
                    }
                default:
                    break;
            }
        }
    }
}
