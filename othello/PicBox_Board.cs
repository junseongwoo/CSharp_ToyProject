using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace othello
{
    public partial class PicBox_Board : PictureBox
    {
        private int RowIdx;
        private int Colldx;

        public int Row
        {
            get { return RowIdx; }
            set { RowIdx = value; }
        }

        public int Col
        {
            get { return Colldx; }
            set { Colldx = value; }
        }
    }
}
