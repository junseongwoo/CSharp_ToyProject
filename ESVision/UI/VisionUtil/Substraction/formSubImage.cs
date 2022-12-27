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
            ILib.GetImagePath();
            if (Vars.ImagePath.Count == 0)
            {
                return;
            }
            else
            {
                txtBackgroundImgPath.Text = Vars.ImagePath.Values[0].ToString();
                picBackgroundImg.Image = ILib.ShowImagePicturebox(Vars.ImagePath.Values[1].ToString());
            }
        }
        #endregion

        #region [이벤트 함수 : Open Source Image 버튼 클릭]
        private void btnOpenSourceImg_Click(object sender, EventArgs e)
        {
            ILib.GetImagePath();
            if (Vars.ImagePath.Count == 0)
            {
                return;
            }
            else
            {
                txtSourceImgPath.Text = Vars.ImagePath.Values[0].ToString();
                picSourceImg.Image = ILib.ShowImagePicturebox(Vars.ImagePath.Values[1].ToString());
            }
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
            byte[] baseImgByte = ILib.Image2ByteArray(picBackgroundImg.Image as Bitmap);
            byte[] srcImgByte = ILib.Image2ByteArray(picSourceImg.Image as Bitmap);
            formSubResultImage formSubResultImage = new formSubResultImage(baseImgByte, srcImgByte);
            //formSubResultImage formSubResultImage = new formSubResultImage(ILib.Sub(picBackgroundImg.Image as Bitmap, picSourceImg.Image as Bitmap));
            formSubResultImage.Show();
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
