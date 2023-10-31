using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayOperations
{
    class ArrayManager<T>
    {
        private T[][] array;
        private PictureBox pictureBox;
        public ArrayManager(T[][] inputArray, PictureBox pictureBox)
        {
            array = inputArray;
            this.pictureBox = pictureBox;

            // PictureBox에 Paint 이벤트 핸들러 추가
            pictureBox.Paint += new PaintEventHandler(DrawRectangles);

            // DrawRectangles 메서드를 처음 한 번 호출하여 초기 그림을 그립니다.
            DrawRectangles(this, new PaintEventArgs(pictureBox.CreateGraphics(), pictureBox.ClientRectangle));
        }

        private void DrawRectangles(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            int cellWidth = pictureBox.Width / array[0].Length; // 각 셀의 너비
            int cellHeight = pictureBox.Height / array.Length; // 각 셀의 높이

            for (int i = 0; i < array.Length; i++)
            {
                for (int j = 0; j < array[i].Length; j++)
                {
                    int x = j * cellWidth; // x 좌표 계산
                    int y = i * cellHeight; // y 좌표 계산

                    if (array[i][j].Equals("1")) // 배열 값에 따라 색상 결정
                    {
                        g.FillRectangle(Brushes.Blue, x, y, cellWidth, cellHeight); // 파란색 사각형 그리기
                    }
                    else
                    {
                        g.FillRectangle(Brushes.Yellow, x, y, cellWidth, cellHeight); // 흰색 사각형 그리기
                    }
                }
            }
        }
        public static void DrawArray(T[][] inputArray, PictureBox pictureBox)
        {
            new ArrayManager<T>(inputArray, pictureBox);
        }


    }
}
