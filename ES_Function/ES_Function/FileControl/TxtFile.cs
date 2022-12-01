using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_Function.FileControl
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
        public void saveTxtFile(string FileFullPath, string[] contents)
        {
            File.WriteAllLines(FileFullPath, contents);
        }
        #endregion
    }
}
