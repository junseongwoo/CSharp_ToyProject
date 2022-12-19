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

        #region [이벤트 함수 : Image Subtraction 툴 메뉴 클릭]
        private void imageSubtractionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnEventImageToolsMenuOpen?.Invoke(EIMAGE_TOOL_MENU_LIST.FORM_SUBTRACTION_IMAGE);
        }
        #endregion

        #region [이벤트 함수 : new Image 툴 메뉴 클릭]
        private void newImageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnEventImageMenuOpen?.Invoke(EIMAGE_MENU_LIST.FORM_NEW_IMAGE);
        }
        #endregion

        #region [이벤트 함수 : ]

        #endregion


    }
}
