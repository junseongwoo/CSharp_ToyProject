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

        public void ShowUi(Form form)
        {
            form.TopLevel = true;
            form.StartPosition = FormStartPosition.CenterParent;
            form.Show();
        }
    }
}
