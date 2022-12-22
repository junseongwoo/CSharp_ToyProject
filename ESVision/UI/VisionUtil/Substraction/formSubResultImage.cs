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
    public partial class formSubResultImage : Form
    {
        #region [필드]
        Bitmap resultImg = null;
        ImgLib ILib = new ImgLib();
        #endregion

        #region [초기화]
        public formSubResultImage(byte[] baseImgByte, byte[] srcImgByte)
        {
            InitializeComponent();

            resultImg = ILib.Sub(baseImgByte, srcImgByte);

            picResultImg.Image = resultImg;
        }
        #endregion
    }
}
