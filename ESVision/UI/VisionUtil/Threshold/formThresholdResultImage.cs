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
    public partial class formThresholdResultImage : Form
    {
        #region [필드]
        Bitmap resultImg = null;
        ImgLib ILib = new ImgLib();
        #endregion
        public formThresholdResultImage(Bitmap baseImg, int thresholdValue)
        {
            InitializeComponent();

            resultImg = ILib.Threashold(baseImg, thresholdValue);

            picThresholdResultImg.Image = resultImg;
        }
    }
}
