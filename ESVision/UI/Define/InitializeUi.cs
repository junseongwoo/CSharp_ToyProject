using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESVision
{
    class InitializeUi
    {
        #region [멤버 함수 : Ui Form을 Panel 컨트롤 안에 생성]
        public void CreatUiInsidePanel(Form form, Control panel)
        {
            form.TopLevel = false;
            form.Location = new Point(0, 0);
            panel.Controls.Add(form);
        }

        public void CreatUiInsidePanel(Form form, Control panel, int ImgNum)
        {
            form.TopLevel = false;
            form.Location = new Point(0 + ImgNum * 50, 0 + ImgNum * 50);
            panel.Controls.Add(form);
        }
        #endregion

        #region [멤버 함수 : Image Open 시 Image Name과 Number 출력]
        public void SetOpenImageInfo(Form form)
        {
            form.Text = $"Image_{Vars.openImgNum + 1} ({Vars.ImagePath["FullPath"]})";
            Vars.openImgNum += 1;
        }
        #endregion

        #region [멤버 함수 : Ui Show]
        public void ShowUi(Form form)
        {
            form.TopLevel = true;
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
        }

        public void ShowCenterForm(Form form, Point pt)
        {
            form.TopLevel = true;
            form.Location = new Point(pt.X / 2, pt.Y / 2);
        }
        #endregion

    }
}
