using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace othello
{
    public partial class frm_main : Form
    {
        public frm_main()
        {
            InitializeComponent();
        }

        private void frm_main_Load(object sender, EventArgs e)
        {
            picBox_othello.Paint += picBox_othello_default;
        }

        private void picBox_othello_default(object sender, PaintEventArgs e)
        {
            // 오셀로 판 그리기
            PictureBox pb = (PictureBox)sender;
            Graphics g = e.Graphics;
            Pen pen = Pens.Black;
            int othelloSize = 8; // 8x8 크기 

            for (int i = 1; i < 8; i++)
            {
                g.DrawLine(pen, (pb.Width/ othelloSize) *i, 0, (pb.Width/ othelloSize) *i, pb.Height);
                g.DrawLine(pen, 0, (pb.Height/ othelloSize) * i, pb.Width, (pb.Height/ othelloSize) * i);
            }
        }

        private void picBox_othello_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
