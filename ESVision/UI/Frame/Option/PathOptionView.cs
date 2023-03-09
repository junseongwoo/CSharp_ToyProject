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
        // 나중에 XML 파일로 불러오고 할 때는 이걸 사용하자 
        // public PathOptionSetup pathOptionSetup {get; set;}

        PathOptionSetup pathOptionSetup = new PathOptionSetup();

        public PathOptionView()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            prgPathOption.SelectedObject = pathOptionSetup;
        }
    }
}
