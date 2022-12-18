using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ESVision
{
    public partial class formMain : Form
    {
        public formMain()
        {
            InitializeComponent();

            Initialize();
        }

        #region [필드]
        public TopView topView = null;
        public BottomView botView = null;
        #endregion

        #region [초기화]
        public void Initialize()
        {
            topView = new TopView();
            topView.TopLevel = false;
            topView.Location = new Point(0, 0);
            topView.Show();
            pnlTop.Controls.Add(topView);

            botView = new BottomView();
            botView.TopLevel = false;
            botView.Location = new Point(0, 0);
            botView.Show();
            pnlBottom.Controls.Add(botView);



        }
        #endregion
    }
}
