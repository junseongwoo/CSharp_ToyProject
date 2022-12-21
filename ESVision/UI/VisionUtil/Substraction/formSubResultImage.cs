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
        #endregion

        #region [초기화]
        public formSubResultImage(Bitmap subImg)
        {
            InitializeComponent();

            resultImg = subImg;

            picResultImg.Image = resultImg;
        }
        #endregion
    }
}
