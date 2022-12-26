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
    public partial class formThreshold : Form
    {
        #region [필드]
        ImgLib ILib = null;
        SortedList<string, string> ImagePath = null;
        #endregion

        #region [생성자]
        public formThreshold()
        {
            InitializeComponent();

            Initialize();

        }
        #endregion

        #region [초기화]
        private void Initialize()
        {
            ILib = new ImgLib();
        }
        #endregion


        #region [이벤트 함수 : Base Image Open Button Click]
        private void btnOpenBaseImg_Click(object sender, EventArgs e)
        {
            ImagePath = ILib.GetImagePath();
            txtBaseImgPath.Text = ImagePath.Values[0].ToString();
            picBaseImg.Image = ILib.ShowImagePicturebox(ImagePath.Values[1].ToString());
        }
        #endregion

        private void trbThreshold_Scroll(object sender, EventArgs e)
        {
            txtThresholdValue.Text = trbThreshold.Value.ToString(); 
        }

        private void btnExecuteSubImg_Click(object sender, EventArgs e)
        {
            formThresholdResultImage formThresholdResultView = new formThresholdResultImage(picBaseImg.Image as Bitmap, Convert.ToInt32(txtThresholdValue.Text));
            formThresholdResultView.Show();
        }
    }
}
