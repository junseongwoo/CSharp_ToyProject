﻿using System;
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

        public int pnlMainSize;

        public Form formCurrent = null;

        public TopView topView = null;

        public BottomView botView = null;

        public formNewImage formNewImageView = null;

        public formOpenImage formOpenImageView = null;

        public formSubImage formSubImageView = null;

        public formBaseImage formBaseImageView = null;

        public formSubResultImage formSubResultImageView = null;

        public formThreshold formThresholdView = null;

        // Option View 
        public FileOptionView fileOptionView = null;
        public PathOptionView pathOptionView = null;
        #endregion

        #region [초기화]
        public void Initialize()
        {
            pnlMainSize = pnlMain.Width * pnlMain.Height;
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
            formNewImageView.OnEventDragImageOpen += ImageMenuOpen;
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
                        ILib.GetImagePath();
                    }
                    break;
                case EIMAGE_MENU_LIST.FORM_DRAG_OPEN_IMAGE:
                    break;
            }

            if (menuList == EIMAGE_MENU_LIST.FORM_NEW_IMAGE)
            {
                formCurrent.ShowDialog();
            }
            else
            {
                if (Vars.ImagePath.Count == 0)
                {
                    return;
                }
                else
                {
                    formOpenImageView = new formOpenImage(Vars.ImagePath["FullPath"].ToString());
                    UiFunction.CreatUiInsidePanel(formOpenImageView, pnlMain, Vars.openImgNum);
                    UiFunction.SetOpenImageInfo(formOpenImageView);
                    formCurrent = formOpenImageView;
                }
                formCurrent.BringToFront();
                formCurrent.Show();
            }
        }
        #endregion

        #region [이벤트 함수 : Main Panel Drag & Drop 함수] 
        private void pnlMain_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                ILib.GetDragImgPath((string[])e.Data.GetData(DataFormats.FileDrop));
                ImageMenuOpen(EIMAGE_MENU_LIST.FORM_NEW_IMAGE);
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
