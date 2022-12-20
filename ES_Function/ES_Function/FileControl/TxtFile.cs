using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_Function
{
    public class TxtFile
    {
        // 파일 이름 가져오기
        public string getFileName(string filePath)
        {
            return System.IO.Path.GetFileName(filePath);
        }

        // 파일 삭제
        public void deleteFile(string filePath)
        {
            if (File.Exists(filePath)) File.Delete(filePath);     
        }

        #region txt 파일 1 라인씩 읽기 
        public void readTxtLine(string fileFullPath)
        {

        }
        #endregion

        #region txt 파일 모든 라인 읽기
        public string[] readTxtAllLines(string fileFullPath)
        {
            return File.ReadAllLines(fileFullPath, Encoding.UTF8);
        }
        #endregion

        #region txt 파일 저장 
        public void saveTxtFile(string fileFullPath, string[] contents)
        {
            File.WriteAllLines(fileFullPath, contents);
            MessageBox.Show("저장 완료");
        }
        #endregion

        #region string[]에서 string[index] 제거 기능 
        public string[] deleteStringArrayLine(string[] stringArray, int index)
        {
            return stringArray.Where(i => i != stringArray[index]).ToArray();
        }
        #endregion

        #region Log 내용 중 S6F1 포함된 부분만 지움 
        public string[] deleteS6F1Contents(string[] logContents)
        {
            int cnt = 0;
            for (int i = 0; i < logContents.Length + cnt; i++)
            {
                if (logContents.Length == cnt)
                {
                    break;
                }
                string[] logSplit = logContents[cnt].Split('\t');

                if (logSplit[4] == "S6F1")
                {
                    for (int j = 0; j < logContents.Length; j++)
                    {
                        
                        if (logContents[cnt] == "\"")
                        {
                            logContents[cnt] = "delete";
                            logContents = deleteStringArrayLine(logContents, cnt);
                            break;
                        }
                        logContents = deleteStringArrayLine(logContents, cnt);
                    }
                }
                else
                {
                    for (int j = 0; j < logContents.Length; j++)
                    {
                        if (logContents[cnt] == "\"")
                        {
                            cnt++;
                            break;
                        }
                        logSplit = logContents[cnt].Split('\t');
                        if (logSplit.Count() >= 5)
                        {
                            if (logSplit[4] == "S6F1")
                            {
                                break;
                            }
                        }
                        cnt++;
                    }
                }
            }
            return logContents;
        }
        #endregion

        #region Log 내용 중 message 포함된 부분만 지움 
        public string[] deleteMessageContents(string[] logContents, string message)
        {
            int cnt = 0;
            for (int i = 0; i < logContents.Length + cnt; i++)
            {
                if (logContents.Length == cnt)
                {
                    break;
                }
                string[] logSplit = logContents[cnt].Split('\t');

                if (logSplit[4] == message)
                {
                    for (int j = 0; j < logContents.Length; j++)
                    {

                        if (logContents[cnt] == "\"")
                        {
                            logContents[cnt] = "delete";
                            logContents = deleteStringArrayLine(logContents, cnt);
                            break;
                        }
                        logContents = deleteStringArrayLine(logContents, cnt);
                    }
                }
                else
                {
                    for (int j = 0; j < logContents.Length; j++)
                    {
                        if (logContents[cnt] == "\"")
                        {
                            cnt++;
                            break;
                        }
                        logSplit = logContents[cnt].Split('\t');
                        if (logSplit.Count() >= 5)
                        {
                            if (logSplit[4] == message)
                            {
                                break;
                            }
                        }
                        cnt++;
                    }
                }
            }
            return logContents;
        }
        #endregion
    }
}
