using System;
using System.Collections.Generic;
using System.Diagnostics;
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

            bitmapImg = RGB2Gray(bitmapImg);

            return bitmapImg;
        }
        #endregion

        #region [멤버 함수 : Image to Grayscale]
        public Bitmap RGB2Gray(Bitmap img)
        {
            // 속도를 어떻게 늘릴 수 있을까? 
            Stopwatch watch = new Stopwatch();
            watch.Start();
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
            watch.Stop();
            TimeSpan time = watch.Elapsed;
            MessageBox.Show(time.ToString());
            return grayImg;
        }
        #endregion

        #region [멤버 함수 : Image Subtraction] 
        public Bitmap Sub(Bitmap baseImg, Bitmap srcImg)
        {
            Stopwatch watch = new Stopwatch();
            watch.Start();
            int WbaseImg = baseImg.Width;
            int HbaseImg = baseImg.Height;

            Bitmap resultImg = new Bitmap(WbaseImg, HbaseImg);

            for (int x = 0; x < WbaseImg; x++)
            {
                for (int y = 0; y < HbaseImg; y++)
                {
                    Color baseColor = baseImg.GetPixel(x, y);
                    Color srcColor = srcImg.GetPixel(x, y);
                    // RGB 값이 -가 나온다. 절대 값으로 해보자 
                    Color resultColor = Color.FromArgb(255 , (baseColor.R - srcColor.R) , (baseColor.G - srcColor.G) , (baseColor.B - srcColor.B));

                    resultImg.SetPixel(x, y, resultColor);
                }
            }
            watch.Stop();
            TimeSpan time = watch.Elapsed;
            MessageBox.Show(time.ToString());
            return resultImg;
        }
        #endregion
    }
}
