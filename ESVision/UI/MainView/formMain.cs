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

        public Form formCurrent = null;

        public TopView topView = null;

        public BottomView botView = null;

        public formNewImage formNewImageView = null;

        public formOpenImage formOpenImageView = null;

        public formSubImage formSubImageView = null;

        public formBaseImage formBaseImageView = null;

        public formSubResultImage formSubResultImageView = null;
        #endregion

        #region [초기화]
        public void Initialize()
        {
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

            formOpenImageView = new formOpenImage();

            formSubImageView = new formSubImage();
        }

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
            }

            formCurrent.Owner = this;
            UiFunction.ShowUi(formCurrent);
        }

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
            }

            formCurrent.Owner = this;
            UiFunction.ShowUi(formCurrent);
        }
        #endregion
    }
}
