using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESVision
{
    class FileLib
    {
        // 한달 이전의 파일 지우기
        public void DeleteFileOneMonthAgo(string directoryPath)
        {
            DateTime OneMonthAgo = DateTime.Now.AddMonths(-1);

            foreach (string filePath in Directory.GetFiles(directoryPath))
            {
                FileInfo fileInfo = new FileInfo(filePath);

                if (fileInfo.LastAccessTime < OneMonthAgo)
                {
                    fileInfo.Delete();
                }
            }
        }

        // 지정된 파일 개수 이상의 파일 지우기 : 오래된 순으로 지움
        public void DeleteFileLimit(string directoryPath, int limitNum)
        {
            string[] filePath = Directory.GetFiles(directoryPath);
            int numFileToDelete = filePath.Length - limitNum;

            if (numFileToDelete > 0)
            {
                Array.Sort(filePath, (x, y) =>
                {
                    return new FileInfo(x).LastAccessTime.CompareTo(new FileInfo(y).LastAccessTime);
                });

                for (int i = 0; i < numFileToDelete; i++)
                {
                    File.Delete(filePath[i]);
                }
            }
        }

    }
}
