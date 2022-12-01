using ES_Function.FileControl;
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
        string filePath = string.Empty;
        string fileFullPath = string.Empty;

        string fileFullName = string.Empty;
        string fileName = string.Empty;

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

                    //openFileDialog.InitialDirectory = filePath;
                }
            }
            #endregion
        }

        private void btnChangeContents_Click(object sender, EventArgs e)
        {
            string[] test = txtFile.readTxtAllLines(fileFullPath);
            int cnt = 0;
            for (int i = 0; i < test.Length + cnt ; i++)
            {
                if (test.Length == cnt)
                {
                    break;
                }
                string[] test1 = test[cnt].Split('\t');

                if (test1[4] == "S6F1")
                {
                    for (int j = 0; j < test.Length; j++)
                    {
                        if (test[cnt] == "\"")
                        {
                            test[cnt] = "delete";
                            test = test.Where(c => c != test[cnt]).ToArray();
                            break;
                        }
                        test = test.Where(c => c != test[cnt]).ToArray();
                    }
                }
                else
                {
                    for (int j = 0; j < test.Length; j++)
                    {
                        if (test[cnt] == "\"")
                        {
                            cnt++;
                            break;
                        }
                        test1 = test[cnt].Split('\t');
                        if (test1.Count() >= 6)
                        {
                            if (test1[4] == "S6F1")
                            {
                                break;
                            }
                        }
                        cnt++;

                    }
                }
            }

            string FileFullPath = filePath + fileName + "_Replace.log";
            txtFile.saveTxtFile(FileFullPath, test);
        }
    }
}