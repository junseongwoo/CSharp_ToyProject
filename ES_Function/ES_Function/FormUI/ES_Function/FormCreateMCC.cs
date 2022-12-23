using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_Function
{
    public partial class FormCreateMCC : Form
    {
        #region [필드]
        public DateTime nowDt = DateTime.Now;

        #endregion

        #region [생성자]
        MCCSetup MCCSetup = new MCCSetup();
        FileLib fileLib = new FileLib();
        #endregion

        #region [초기화]
        public FormCreateMCC()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            Directory.CreateDirectory(MCCSetup.MCC_Path);
            Directory.CreateDirectory(Path.Combine(MCCSetup.MCC_Path, "index"));
            Directory.CreateDirectory(MCCSetup.MCC_Loader_Path);
            Directory.CreateDirectory(Path.Combine(MCCSetup.MCC_Loader_Path, "index"));
        }
        #endregion

        #region [이벤트 함수 : MCC I Log 생성 버튼 클릭]
        private void btnCreate_AMAU_Click(object sender, EventArgs e)
        {
            fileLib.MCCFileCreate("AMAU", nowDt);
        }
        #endregion

        #region [이벤트 함수 : MCC T Log 생성 버튼 클릭]
        private void btnCreate_LD_Click(object sender, EventArgs e)
        {
            fileLib.MCCFileCreate("LD", nowDt);
        }
        #endregion


        #region [이벤트 함수 : MCC Log 생성 버튼 클릭]
        private void btnCreateMCC_Click(object sender, EventArgs e)
        {

        }
        #endregion
    }
}
