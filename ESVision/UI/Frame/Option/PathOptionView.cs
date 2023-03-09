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
    public partial class PathOptionView : Form
    {
        public PathOptionSetup pathOptionSetup {get; set;}


        public PathOptionView()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            // 파일이 없으면 new 로 새로 생성 
            if (pathOptionSetup == null)
            {
                pathOptionSetup = new PathOptionSetup(false);
            }
            prgPathOption.SelectedObject = pathOptionSetup;
        }
    }
}
