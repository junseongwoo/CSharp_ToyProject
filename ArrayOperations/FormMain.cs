using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ArrayOperations
{
    public partial class FormMain : Form
    {
        int[][] intExampleArray = {
            new int[] {1, 0, 1},
            new int[] {0, 1, 0},
            new int[] {1, 0, 1}
        };
        // 다른 폼에서 생성한 PictureBox를 사용할 수 있도록 전달
        PictureBox pictureBox = new PictureBox();

        public FormMain()
        {
            InitializeComponent();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox.Size = new Size(400, 400);

            ArrayManager<int>.DrawArray(intExampleArray, pictureBox);
        }
    }
}
