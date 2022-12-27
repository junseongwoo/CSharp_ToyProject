using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
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
                    Vars.ImagePath["FullName"] = openFileDialog.SafeFileName;
                    Vars.ImagePath["FullPath"] = openFileDialog.FileName;
                    Vars.ImagePath["path"] = openFileDialog.FileName.Replace(openFileDialog.SafeFileName, "");
                    Vars.ImagePath["name"] = Path.GetFileNameWithoutExtension(openFileDialog.FileName);
                }
                else
                {
                    Vars.ImagePath = new SortedList<string, string>();
                }
                return Vars.ImagePath;
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

        #region [멤버 함수 : Convert Image to Byte Array]
        public byte[]Image2ByteArray(Bitmap img)
        {
            using (var ms = new MemoryStream())
            {
                img.Save(ms, ImageFormat.Bmp);
                
                return ms.ToArray();
            }
        }
        #endregion

        #region [멤버 함수 : Image to Grayscale]
        public Bitmap RGB2Gray(Bitmap img)
        {
            Bitmap grayImg = new Bitmap(img.Width, img.Height);

            int width = img.Width;
            int height = img.Height;
            Color argb;
            Color gray;
            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    argb = img.GetPixel(x, y);

                    int a = argb.A;
                    int r = argb.R;
                    int g = argb.G;
                    int b = argb.B;

                    int avg = (r + g + b) / 3;
                    gray = Color.FromArgb(a, avg, avg, avg);
                    grayImg.SetPixel(x, y, gray);
                }
            }
            return grayImg;
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

                    int subAvg = (Math.Abs(baseColor.R - srcColor.R) + Math.Abs(baseColor.G - srcColor.G) + Math.Abs(baseColor.B - srcColor.B)) / 3;
                    Color resultColor = Color.FromArgb(255 , subAvg, subAvg, subAvg);

                    resultImg.SetPixel(x, y, resultColor);
                }
            }
            return resultImg;
        }

        public Bitmap Sub(byte[] baseImg, byte[] srcImg)
        {
            byte[] subImg = baseImg;

            for (int i = 1079; i < baseImg.Length; i++)
            {
                int subValue = baseImg[i] - srcImg[i];

                if (subValue < 0)
                {
                    subValue = 0;
                }

                subImg[i] = Convert.ToByte(subValue);
            }

            using (var resultByte = new MemoryStream(subImg))
            {
                Bitmap resultImg = Image.FromStream(resultByte) as Bitmap;
                return resultImg;
            }
        }
        #endregion

        #region [멤버 함수 : Image Threshold]
        public Bitmap Threashold(Bitmap baseImg, int thresholdValue)
        {
            byte[] baseImgByte = Image2ByteArray(baseImg);

            for (int i = 1079; i < baseImgByte.Length; i++)
            {
                if (baseImgByte[i] > thresholdValue)
                {
                    baseImgByte[i] = 255;
                }
                else
                {
                    baseImgByte[i] = 0;
                }
            }

            using (var resultByte = new MemoryStream(baseImgByte))
            {
                Bitmap resultImg = Image.FromStream(resultByte) as Bitmap;
                return resultImg;
            }
        }
        #endregion

        #region 

        #endregion
    }
}
