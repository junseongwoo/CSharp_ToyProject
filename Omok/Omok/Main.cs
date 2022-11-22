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

        enum STONE
        {
          none, black, white
        };
        STONE[,] Board = new STONE[19, 19];

        bool flag = false; // false : 검은돌, true : 흰돌 
        bool imgFlag = true;
        

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

        private void pnlMain_Paint(object sender, PaintEventArgs e)
        {
            //base.OnPaint(e);
            DrawBoard();
            DrawStone();
        }

        private void DrawStone()
        {
            for (int x = 0; x < 19; x++)
            {
                for (int y = 0; y < 19; y++)
                {
                    if (Board[x, y] == STONE.white)
                    {
                        if (imgFlag == flag)
                        {
                            g.FillEllipse(wBrush, 
                                margin + cellSize * x - stoneSize / 2,
                                margin + cellSize * y - stoneSize / 2, 
                                stoneSize, stoneSize);
                        }
                        else
                        {
                            Bitmap bmp = new Bitmap("../../Resources/white.png");
                            g.DrawImage(bmp, margin + cellSize * x - stoneSize / 2,
                                margin + cellSize * y - stoneSize / 2,
                                stoneSize, stoneSize);
                        }
                    }
                    else if (Board[x, y] == STONE.black)
                    {
                        if (imgFlag == false)
                        {
                            g.FillEllipse(bBrush,
                                margin + cellSize * x - stoneSize / 2,
                                margin + cellSize * y - stoneSize / 2,
                                stoneSize, stoneSize);
                        }
                        else
                        {
                            Bitmap bmp = new Bitmap("../../Resources/black.png");
                            g.DrawImage(bmp, margin + cellSize * x - stoneSize / 2,
                                margin + cellSize * y - stoneSize / 2,
                                stoneSize, stoneSize);
                        }
                    }
                }
            }
        }

        private void 그리기ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgFlag = false;
        }

        private void 이미지ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            imgFlag = true;
        }
        
        private void pnlMain_MouseDown(object sender, MouseEventArgs e)
        {
            // e.X는 픽셀 단위, x는 바둑판 좌표 
            int x = (e.X - margin + cellSize / 2) / cellSize;
            int y = (e.Y - margin + cellSize / 2) / cellSize;

            // 오목이 됐는지 check 하는 메소드 추가 

            if (Board[x, y] != STONE.none)
                return;

            // Board[x,y]에 돌을 그리기 위한 Rectangle 
            Rectangle rect = new Rectangle(margin + cellSize * x - stoneSize / 2,
                margin + cellSize * y - stoneSize / 2, stoneSize, stoneSize);

            // 검은돌 차례
            if (flag == false)
            {
                if (imgFlag == false)
                {
                    g.FillEllipse(bBrush, rect);
                }
                else
                {
                    Bitmap bmp = new Bitmap("../../Resources/black.png");
                    g.DrawImage(bmp, rect);
                }
                flag = true;
                Board[x, y] = STONE.black;
            }
            else
            {
                if (imgFlag == false)
                {
                    g.FillEllipse(wBrush, rect);

                }
                else
                {
                    Bitmap bmp = new Bitmap("../../Resources/white.png");
                    g.DrawImage(bmp, rect);
                }
                flag = false;
                Board[x, y] = STONE.white;
            }
            CheckOmok(x, y);
        }

        private void CheckOmok(int x, int y)
        {
            int cnt = 1;

            for (int i = x + 1; i <= 18; i++)
                if (Board[i, y] == Board[x, y])
                    cnt++;
                else
                    break;

            for (int i = x - 1; i >= 0; i--)
                if (Board[i, y] == Board[x, y])
                    cnt++;
                else
                    break;

            for (int i = y + 1; i <= 18; i++)
                if (Board[x, i] == Board[x, y])
                    cnt++;
                else
                    break;

            for (int i = y - 1; i >= 0; i--)
                if (Board[x, i] == Board[x, y])
                    cnt++;
                else
                    break;

            if (cnt == 5)
            {
                OmokComplete(x, y);
                return;
            }
        }

        private void OmokComplete(int x, int y)
        {
            DialogResult res = MessageBox.Show(Board[x, y].ToString().ToUpper() +
                " Wins! \n새로운 게임을 시작할까요", "게임 종료",
                MessageBoxButtons.YesNo);

            if (res == DialogResult.Yes)
            {
                NewGame();
            }
            else
            {
                this.Close();
            }
        }

        private void NewGame()
        {
            imgFlag = true;
            flag = false;

            Board = new STONE[19, 19];

            pnlMain.Refresh();
            DrawBoard();
        }
    }
}
