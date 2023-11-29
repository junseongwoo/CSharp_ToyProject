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
    public partial class formNewImage : Form
    {
        #region [필드]
        public delegate void OnEventDragImageOpenHandler(EIMAGE_MENU_LIST menuList);
        public event OnEventDragImageOpenHandler OnEventDragImageOpen;
        #endregion

        #region [생성자]
        public formNewImage()
        {
            InitializeComponent();

            Initialize();
        }
        #endregion

        #region [초기화]
        private void Initialize()
        {
            txtOpenImgName.Text = $"Image_{Vars.openImgNum + 1}";
        }
        #endregion

        private void btnOpenImg_Click(object sender, EventArgs e)
        {
            var handler = OnEventDragImageOpen;
            OnEventDragImageOpen?.Invoke(EIMAGE_MENU_LIST.FORM_DRAG_OPEN_IMAGE);
            this.Hide();
        }

        private void formNewImage_Paint(object sender, PaintEventArgs e)
        {
            txtOpenImgName.Text = $"Image_{Vars.openImgNum + 1}";
        }
    }
}
