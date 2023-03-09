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


        public formOption()
        {
            InitializeComponent();

            Initialize();
        }
        #region [필드]
        public PathOptionSetup pathOptionSetup { get; set; }

        InitializeUi uiFunction = new InitializeUi();

        private Form formCurrent = null;
        private FileOptionView fileOptionView = null;
        private PathOptionView pathOptionView = null;
        #endregion

        #region [이벤트 : Option Tree View Node 클릭 시 Option View]
        public delegate void OnEventOptionTreeNodeViewHandler(EOPTION_VIEW_LIST optionList);
        public event OnEventOptionTreeNodeViewHandler OnEventOptionView;
        #endregion

        #region [초기화]
        private void Initialize()
        {
            fileOptionView = new FileOptionView();
            uiFunction.CreatUiInsidePanel(fileOptionView, pnlOption);
            pathOptionView = new PathOptionView();
            uiFunction.CreatUiInsidePanel(pathOptionView, pnlOption);
            formCurrent = fileOptionView;
            formCurrent.Show();
            OnEventOptionView += OptionViewOpen;
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

        public void OptionViewOpen(EOPTION_VIEW_LIST optionList)
        {
            formCurrent.Visible = false;

            switch (optionList)
            {
                case EOPTION_VIEW_LIST.FORM_FILE_OPTION:
                    {
                        {
                            if (fileOptionView.IsDisposed == true)
                            {
                                fileOptionView = new FileOptionView();
                            }
                            formCurrent = fileOptionView;
                        }
                    }
                    break;
                case EOPTION_VIEW_LIST.FORM_PATH_OPTION:
                    {
                        {
                            if (pathOptionView.IsDisposed == true)
                            {
                                pathOptionView = new PathOptionView();
                            }
                            formCurrent = pathOptionView;
                        }
                    }
                    break;
            }

            formCurrent.Visible = true;
            formCurrent.Show();
        }

    }
}
