using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace othello
{
    public class GameLib
    {
        public GameBoard GameBoard;
        public GameControl GameControl;
        public GameLogic GameLogic;
        public Players Players;
        public Stone Stone;

        #region [클래스 초기화]
        public bool InitGameBoard()
        {
            try
            {
                GameBoard = new GameBoard();
                return true;
            }
            catch (Exception)
            {

                return false;
            }
        }
        #endregion
    }
}
