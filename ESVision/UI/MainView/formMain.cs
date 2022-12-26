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
    public partial class formMain : Form
    {
        #region [생성자]
        public formMain()
        {
            InitializeComponent();

            Initialize();
        }
        #endregion

        #region [필드]
        InitializeUi UiFunction = new InitializeUi();
        ImgLib ILib = new ImgLib();

        SortedList<string, string> ImagePath;
        int OpenImgNum = 0;

        public Form formCurrent = null;

        public TopView topView = null;

        public BottomView botView = null;

        public formNewImage formNewImageView = null;

        public formOpenImage formOpenImageView = null;

        public formSubImage formSubImageView = null;

        public formBaseImage formBaseImageView = null;

        public formSubResultImage formSubResultImageView = null;

        public formThreshold formThresholdView = null;
        #endregion

        #region [초기화]
        public void Initialize()
        {
            this.TopLevel = true;

            topView = new TopView();
            topView.TopLevel = false;
            topView.Location = new Point(0, 0);
            topView.OnEventImageMenuOpen += ImageMenuOpen;
            topView.OnEventImageToolsMenuOpen += ImageToolsMenuOpen;
            topView.Show();
            pnlTop.Controls.Add(topView);

            botView = new BottomView();
            botView.TopLevel = false;
            botView.Location = new Point(0, 0);
            botView.Show();
            pnlBottom.Controls.Add(botView);

            formNewImageView = new formNewImage();

            formBaseImageView = new formBaseImage();

            formSubImageView = new formSubImage();

            formThresholdView = new formThreshold();
        }
        #endregion

        #region [이벤트 함수 : Image Tool Menu 전환 함수]
        private void ImageToolsMenuOpen(EIMAGE_TOOL_MENU_LIST menuList)
        {
            switch (menuList)
            {
                case EIMAGE_TOOL_MENU_LIST.FORM_SUBTRACTION_IMAGE:
                    {
                        if (formSubImageView.IsDisposed == true)
                        {
                            formSubImageView = new formSubImage();
                        }
                        formCurrent = formSubImageView;
                    }
                    break;
                case EIMAGE_TOOL_MENU_LIST.FORM_THREASHOLOD_IMAGE:
                    {
                        if (formThresholdView.IsDisposed == true)
                        {
                            formThresholdView = new formThreshold();
                        }
                        formCurrent = formThresholdView;
                    }
                    break;
            }

            formCurrent.Owner = this;
            UiFunction.ShowUi(formCurrent);
        }
        #endregion

        #region [이벤트 함수 : Image Menu 전환 함수]
        private void ImageMenuOpen(EIMAGE_MENU_LIST menuList)
        {
            switch (menuList)
            {
                case EIMAGE_MENU_LIST.FORM_NEW_IMAGE:
                    {
                        if (formNewImageView.IsDisposed == true)
                        {
                            formNewImageView = new formNewImage();
                        }
                        formCurrent = formNewImageView;
                    }
                    break;
                case EIMAGE_MENU_LIST.FORM_OPEN_IMAGE:
                    {
                        ImagePath = ILib.GetImagePath();
                        formOpenImageView = new formOpenImage(ImagePath["FullPath"].ToString());
                        UiFunction.CreatUiInsidePanel(formOpenImageView, pnlMain, OpenImgNum);
                        formOpenImageView.Text = $"Image_{OpenImgNum + 1} ({ImagePath["FullPath"]})";
                        OpenImgNum += 1;
                        formCurrent = formOpenImageView;
                    }
                    break;
            }
            formCurrent.Show();
        }
        #endregion

        #region [이벤트 함수 : Main Panel Drag & Drop 함수] 
        private void pnlMain_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                var directoryName = (string[])e.Data.GetData(DataFormats.FileDrop);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void pnlMain_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        #endregion
    }
}
