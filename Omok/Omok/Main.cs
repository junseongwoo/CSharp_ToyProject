using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Omok
{
    public partial class Main : Form
    {
        int margin = 40;
        int cellSize = 30;
        int stoneSize = 28;
        int flowerPointSize = 10;

        Graphics g;
        Pen pen;
        Brush wBrush, bBrush;

        public Main()
        {
            InitializeComponent();

            this.BackColor = Color.Orange;

            pen = new Pen(Color.Black);
            bBrush = new SolidBrush(Color.Black);
            wBrush = new SolidBrush(Color.White);

            this.ClientSize = new Size(2 * margin + 18 * cellSize,
                2 * margin + 18 * cellSize + mspMain.Height);
            
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
            DrawBoard();
        }

        private void DrawBoard()
        {
            g = pnlMain.CreateGraphics();

            for (int i = 0; i < 19; i++)
            {
                // 세로선
                g.DrawLine(pen, new Point(margin + i * cellSize, margin),
                    new Point(margin + i * cellSize, margin + 18 * cellSize));
                // 가로선
                g.DrawLine(pen, new Point(margin, margin + i * cellSize),
                    new Point(margin + 18 * cellSize, margin + i * cellSize));
            }

            // 화점 그리기
            for (int i = 3 ; i <= 15; i+=6)
                for (int j = 3; j <= 15; j+=6)
                {
                    g.FillRectangle(bBrush,
                        margin + cellSize * i - flowerPointSize / 2,
                        margin + cellSize * j - flowerPointSize / 2,
                        flowerPointSize, flowerPointSize);
                }
        }
    }
}
