using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESVision
{
    class ImgLib
    {
        #region [필드]
        #endregion

        #region [생성자]
        SortedList<string, string> ImagePath { get; set; } = new SortedList<string, string>();
        #endregion

        #region [멤버 함수 : Get Image Path]
        public SortedList<string, string> GetImagePath()
        {
            OpenFileDialog openFileDialog = null;

            using (openFileDialog = new OpenFileDialog())
            {
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    ImagePath["FullName"] = openFileDialog.SafeFileName;
                    ImagePath["FullPath"] = openFileDialog.FileName;
                    ImagePath["path"] = openFileDialog.FileName.Replace(openFileDialog.SafeFileName, "");
                    ImagePath["name"] = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                }
                return ImagePath;
            }
        }
        #endregion

        #region [멤버 함수 : Show Image in Picturebox] 
        public Bitmap ShowImagePicturebox(string imgPath)
        {
            Bitmap bitmapImg = Bitmap.FromFile(imgPath) as Bitmap;

            return bitmapImg;
        }
        #endregion

        #region [멤버 함수 : Image Subtraction] 
        public Bitmap Sub(Bitmap baseImg, Bitmap srcImg)
        {
            int WbaseImg = baseImg.Width;
            int HbaseImg = baseImg.Height;

            Bitmap resultImg = new Bitmap(WbaseImg, HbaseImg);

            for (int x = 0; x < WbaseImg; x++)
            {
                for (int y = 0; y < HbaseImg; y++)
                {
                    Color baseColor = baseImg.GetPixel(x, y);
                    Color srcColor = srcImg.GetPixel(x, y);
                    Color resultColor = Color.FromArgb((baseColor.A - srcColor.A) | (baseColor.R - srcColor.R) | (baseColor.G - srcColor.G) | (baseColor.B - srcColor.B));

                    resultImg.SetPixel(x, y, resultColor);
                }
            }

            return resultImg;
        }
        #endregion
    }
}
