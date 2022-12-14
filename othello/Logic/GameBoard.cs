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
    // How to divide grid of picturebox
    // https://stackoverflow.com/questions/22093731/trying-to-create-a-grid-of-pictureboxes-in-an-array-for-a-board-in-c-sharp
    // https://stackoverflow.com/questions/12737103/picturebox-grids-and-filling-in-squares-game-of-life
    // 
    class GameBoard
    {
        private int NumOfCell;
        private int CellSize;

        private readonly Image BlackStone = Properties.Resources.BlackStone;
        private readonly Image WhiteStone = Properties.Resources.WhiteStone;

        public GameBoard()
        {
            NumOfCell = 8;
            CellSize = 80;
        }

        public void Init_GameBoard(int Cells, int CellSize)
        {
            this.NumOfCell = Cells;
            this.CellSize = CellSize;


        }

        public void Create_GameBorad(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            Pen p = new Pen(Color.Black);

            for (int i = 0; i < NumOfCell + 1; i++)
            {
                g.DrawLine(p, i * CellSize, 0, i * CellSize, NumOfCell * CellSize);
                g.DrawLine(p, 0, i * CellSize, NumOfCell * CellSize, i * CellSize);
            }
        }
    }
}
