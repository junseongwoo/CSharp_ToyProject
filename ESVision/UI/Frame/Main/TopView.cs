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
    /*
     * 
     * 
     * 추가 사항
     * 블랍, 지오메트리, 컨투어, 패턴, 켈리퍼 
     */
    public partial class TopView : Form
    {
        #region [이벤트 : Image 메뉴 클릭 시 뷰 오픈]
        public delegate void OnEventImageMenuOpenHandler(EIMAGE_MENU_LIST menuList);
        public event OnEventImageMenuOpenHandler OnEventImageMenuOpen;
        #endregion

        #region [이벤트 : Image Tools 메뉴 클릭 시 뷰 오픈]
        public delegate void OnEventImageToolsMenuOpenHandler(EIMAGE_TOOL_MENU_LIST menuList);
        public event OnEventImageToolsMenuOpenHandler OnEventImageToolsMenuOpen;
        #endregion

        #region [필드]
        int upZoomRatioCnt = 0;
        int downZoomRatioCnt = 0;
        #endregion

        #region [생성자]
        public TopView()
        {
            InitializeComponent();

            //Initialize();
        }
        #endregion

        #region [초기화]
        private void Initialize()
        {
            throw new NotImplementedException();
        }
        #endregion

        #region [이벤트 함수 : Image Tools 메뉴 중 Image Subtraction 클릭]
        private void imageSubtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnEventImageToolsMenuOpen?.Invoke(EIMAGE_TOOL_MENU_LIST.FORM_SUBTRACTION_IMAGE);
        }
        #endregion

        #region [이벤트 함수 : Image 메뉴 중 New Image 클릭]
        private void newImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnEventImageMenuOpen?.Invoke(EIMAGE_MENU_LIST.FORM_NEW_IMAGE);
        }
        #endregion

        #region [이벤트 함수 : Image Tools 메뉴 중 Threshold 클릭]
        private void thresholdToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnEventImageToolsMenuOpen?.Invoke(EIMAGE_TOOL_MENU_LIST.FORM_THREASHOLOD_IMAGE);
        }

        #endregion

        private void openImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnEventImageMenuOpen?.Invoke(EIMAGE_MENU_LIST.FORM_OPEN_IMAGE);
        }

        private void toolStripBtnOpenImg_Click(object sender, EventArgs e)
        {
            OnEventImageMenuOpen?.Invoke(EIMAGE_MENU_LIST.FORM_OPEN_IMAGE);
        }

        private void btn_UpZoomRatio_Click(object sender, EventArgs e)
        {
            int upZoomRatio = 1 * (int)Math.Pow(2, upZoomRatioCnt);
            toolStriptxtZoomRatio.Text = $"{upZoomRatio}:1";
            if (upZoomRatio == 16)
            {
                return;
            }
            upZoomRatioCnt += 1;
        }

        #region [이벤트 함수 : ]
        private void btn_DownZoomRatio_Click(object sender, EventArgs e)
        {
            int downZoomRatio = 1 * (int)Math.Pow(2, downZoomRatioCnt);
            toolStriptxtZoomRatio.Text = $"1:{downZoomRatio}";
            if (downZoomRatio == 16)
            {
                return;
            }

            downZoomRatioCnt += 1;
        }
        #endregion

        #region [이벤트 함수 : Holizontal Tool Menu Click]
        private void HorlizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region [이벤트 함수 : Vertical Tool Menu Click]
        private void verticalToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }


        #endregion

        private void optionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            formOption formOption = new formOption();
            formOption.StartPosition = FormStartPosition.CenterParent;
            formOption.ShowDialog();
        }
    }
}
