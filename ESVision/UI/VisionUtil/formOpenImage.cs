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
    public partial class formOpenImage : Form
    {
        #region [필드]
        ImgLib ILib = null;
        string openImgPath = string.Empty;
        #endregion

        #region [생성자]
        public formOpenImage(string imgPath)
        {
            InitializeComponent();

            openImgPath = imgPath;
            Initialize();

            picOpenImg.Image = ILib.ShowImagePicturebox(openImgPath);
        }

        #endregion

        #region [초기화]
        private void Initialize()
        {
            ILib = new ImgLib();
        }
        #endregion

        private void formOpenImage_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }

        private void picOpenImg_Click(object sender, EventArgs e)
        {
            this.BringToFront();
        }
    }
}
