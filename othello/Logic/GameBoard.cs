using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace othello.Logic
{
    // How to separate cells in One picturebox
    // https://stackoverflow.com/questions/12711843/picturebox-grid-and-selecting-individual-cells-when-clicked-on
    // 
    class GameBoard
    {
        private int NumOfCell;
        private int CellSize;

        //public GameBoard()
        //{
        //    NumOfCell = 8;
        //    CellSize = 40;
        //}

        public void GameBoard_Info(int Cells, int CellSize)
        {
            this.NumOfCell = Cells;
            this.CellSize = CellSize;
        }

        //private PicBox_Board createPictureBox(int Row, int Col, int Left, int Top)
        //{
        //    PicBox_Board GameBoard = new PicBox_Board();
        //    //GameBoard.Height = Board_Size;

        public void GameBoard_Create(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black);

            for (int i = 0; i < NumOfCell; i++)
            {
                g.DrawLine(p, i * CellSize, 0, i * CellSize, NumOfCell * CellSize);
                g.DrawLine(p,  0, i * CellSize, NumOfCell * CellSize, i * CellSize);
            }
        }
    }
}
