using othello.Logic;
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

        public frm_main()
        {
            InitializeComponent();
        }

    }
}
