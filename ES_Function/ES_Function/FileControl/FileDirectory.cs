using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_Function.FileControl
{
    class FileDirectory
    {
        #region 디렉토리 안의 파일 리스트 얻기
        public void getFileList(string folderPath)
        {
            DirectoryInfo di = new DirectoryInfo(folderPath);

            foreach (FileInfo file in di.GetFiles())
            {
                // 전체 경로 출력 
                string fileFullName = file.FullName;
                // 파일 이름만 출력
                string fileName = file.Name;
            }
        }
        #endregion

        #region 폴더안에 다른 폴더 정보 얻기 
        public void getOtherFolderInfo(string folderPath)
        {
            DirectoryInfo di = new DirectoryInfo(folderPath);
            foreach (DirectoryInfo sub_Dir in di.GetDirectories())
            {
                // 전체 경로 출력
                string subFolderDir = sub_Dir.FullName;
                // 폴더 이름만 출력
                string subFolderName = sub_Dir.Name;
            }
        }
        #endregion

        #region 하위 디렉토리 포함 폴더안에 있는 모든 파일 이름 얻기 
        public string[] getAllFileName(string folderPath)
        {
            string[] allFiles = null;
            return allFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
        }
        #endregion
    }
}
