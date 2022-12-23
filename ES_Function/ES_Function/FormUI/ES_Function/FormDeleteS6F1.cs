using System;
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
    public partial class FormDeleteS6F1 : Form
    {
        #region 지역변수
        string filePath = string.Empty;
        string fileFullPath = string.Empty;
        string fileFullName = string.Empty;
        string fileName = string.Empty;
        #endregion

        #region 생성자
        TxtFile txtFile = new TxtFile();
        #endregion

        public FormDeleteS6F1()
        {
            InitializeComponent();
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            #region Show Open File Dialog
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                //openFileDialog.Filter = "txt files (*.txt)|*.txt|All files (*.*)|*.*";
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //File경로와 File명을 모두 가지고 온다.
                    fileFullPath = openFileDialog.FileName;
                    //File명과 확장자를 가지고 온다.
                    fileFullName = openFileDialog.SafeFileName;
                    //File경로만 가지고 온다.
                    filePath = fileFullPath.Replace(fileFullName, "");
                    //File명만 가지고 온다
                    fileName = Path.GetFileNameWithoutExtension(fileFullPath);

                    string[] viewFilePath = fileFullPath.Split('\\');
                    lblLogFilePath.Text = "..\\" + viewFilePath[viewFilePath.Length - 2] + '\\' + viewFilePath[viewFilePath.Length - 1];
                    //openFileDialog.InitialDirectory = filePath;
                }
            }
            #endregion
        }

        private void btnChangeContents_Click(object sender, EventArgs e)
        {
            string[] logContents = txtFile.readTxtAllLines(fileFullPath);
            logContents = txtFile.deleteS6F1Contents(logContents);

            string FileFullPath = filePath + fileName + "_Replace.log";
            txtFile.saveTxtFile(FileFullPath, logContents);
        }
    }
}