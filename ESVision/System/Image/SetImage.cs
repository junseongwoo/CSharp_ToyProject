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
    class SetImage
    {
        #region [필드]
        OpenFileDialog openFileDialog = null;
        #endregion

        #region [생성자]
        SortedList<string, string> ImagePath { get; set; } = new SortedList<string, string>();
        #endregion

        #region [멤버 함수 : Get Image Path]
        public SortedList<string, string> GetImagePath()
        {
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
    }
}
