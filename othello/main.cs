using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*
 * 오델로 = 리버시
 * 8x8 정중앙에 흑백 2개의 돌을 교차로 놓고 게임 시작
 * 돌을 놓을 곳이 없다면 Pass 발생 -> 상대에게 턴이 넘어간다.
 * 흑 백 모두 돌을 놓을 곳이 없으면 게임 종료 
 * 돌의 수가 많으면 승리, 같으면 무승부 
 */
namespace othello
{
    public partial class frm_main : Form
    {
        #region [필드]
        GameLib GameLib = new GameLib();
        #endregion

        public frm_main()
        {
            InitializeComponent();
            InitClass();
        }

        #region [초기화]
        private void InitClass()
        {
            if (GameLib.InitGameBoard() == false)
            {
                MessageBox.Show("Game Board 초기화 실패!");
            }
        }

        #endregion

        private void btnExit_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void picGameBoard_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int cellSize = Math.Min(picGameBoard.Width / GameLib.GameBoard.boardSize, picGameBoard.Height / GameLib.GameBoard.boardSize);

            for (int i = 0; i < GameLib.GameBoard.boardSize; i++)
            {
                for (int j = 0; j < GameLib.GameBoard.boardSize; j++)
                {
                    Brush brush = GameLib.GameBoard.board[i, j] ? Brushes.Black : Brushes.White;
                    g.FillRectangle(brush, i * cellSize, 
                        j * cellSize, cellSize, cellSize);
                }
            }

            Pen pen = new Pen(Color.Black, 2);
            for (int i = 0; i <= GameLib.GameBoard.boardSize; i++)
            {
                g.DrawLine(pen, i * cellSize, 0, i * cellSize, GameLib.GameBoard.boardSize * cellSize);
                g.DrawLine(pen, 0, i * cellSize, GameLib.GameBoard.boardSize * cellSize, i * cellSize);
            }
        }
    }
}
