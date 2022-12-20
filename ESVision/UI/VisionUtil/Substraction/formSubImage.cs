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
    public partial class formSubImage : Form
    {
        #region [필드]
        ImgLib ILib = null;
        SortedList<string, string> ImagePath = null;
        #endregion

        #region [생성자]
        public formSubImage()
        {
            InitializeComponent();

            Initalize();
        }
        #endregion

        #region [초기화]
        private void Initalize()
        {
            ILib = new ImgLib();
        }
        #endregion

        #region [이벤트 함수 : Open Background Image 버튼 클릭]
        private void btnOpenBackgroundImg_Click(object sender, EventArgs e)
        {
            ImagePath = ILib.GetImagePath();
            txtBackgroundImgPath.Text = ImagePath.Values[0].ToString();
            picBackgroundImg.Image = ILib.ShowImagePicturebox(ImagePath.Values[1].ToString());
        }
        #endregion

        #region [이벤트 함수 : Open Source Image 버튼 클릭]
        private void btnOpenSourceImg_Click(object sender, EventArgs e)
        {
            ImagePath = ILib.GetImagePath();
            txtSourceImgPath.Text = ImagePath.Values[0].ToString();
            picSourceImg.Image = ILib.ShowImagePicturebox(ImagePath.Values[1].ToString());
        }
        #endregion

        #region [이벤트 함수 : New Background Image 버튼 클릭]
        private void btnNewBackgroundImg_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region [이벤트 함수 : New Source Image 버튼 클릭]
        private void btnNewSourceImg_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region [이벤트 함수 : Subtraction Execute 버튼 클릭]
        private void btnExecuteSubImg_Click(object sender, EventArgs e)
        {

        }
        #endregion

        #region [이벤트 함수 : Close 버튼 클릭]
        private void btnCloseFormSub_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        #endregion

    }
}
