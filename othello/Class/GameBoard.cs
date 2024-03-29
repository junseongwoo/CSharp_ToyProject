﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace othello
{
    /*
     * 8x8의 격자로 구성된 게임 보드가 필요
     * 각 셀은 검은색, 흰색 또는 빈 셀일 수 있음
     * 게임 보드의 상태를 저장하고 업데이트하는 메커니즘 필요
     */
    public class GameBoard
    {
        public int boardSize = 8;
        public int cellSize = 50;

        public bool[,] board;

        public GameBoard() 
        {
            InitBoard();
        }

        private void InitBoard()
        {
            board = new bool[boardSize, boardSize];

            board[3, 3] = board[4, 4] = true; // 흑돌
            board[3, 4] = board[4, 3] = false; // 백돌
        }
    }
}
