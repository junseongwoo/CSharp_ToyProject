using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Engion;

namespace ES_Function.FormUI
{
    public partial class FormESLib : Form
    {
        #region [필드]
        BitmapBuf buf;
        #endregion

        #region [초기화]
        public FormESLib()
        {
            InitializeComponent();
        }
        #endregion

        #region [이벤트 함수 : Form Load]
        private void FormESLib_Load(object sender, EventArgs e)
        {
            //logViewer1.Log = Vars.log;

            //imageViewerEx1.AllowDrop = true;
            //imageViewerEx1.DragEnter += (s, ee) =>
            //{
            //    if (ee.Data.GetDataPresent(DataFormats.FileDrop))
            //        ee.Effect = DragDropEffects.All;
            //    else
            //        ee.Effect = DragDropEffects.None;
            //};
            //imageViewerEx1.DragDrop += (s, ee) =>
            //{
            //    string[] ss = (string[])ee.Data.GetData(DataFormats.FileDrop, false);
            //    buf = new BitmapBuf(ss[0]);

            //    imageViewerEx1.Image = buf;
            //    imageViewerEx1.Invalidate();
            //};

            //Vars.log.AddLogMessage(LogType.Information, 0, "Program Started");
        }
        #endregion

    }
}
