using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESVision
{
    /*
     * XML 파일을 불러오는데 
     * 불러 올 때 파일이 없으면 new class()로 해서 초기화로 생성
     * 있으면 XML 파일 불러오기 
     */
    [Serializable]
    public class AllOptionSetup
    {
        public FileOptionSetup fileOptionSetup { get; set; }
        public PathOptionSetup pathOptionSetup { get; set; }

        public AllOptionSetup()
        {
            LoadtoXML();
            CheckFile();
        }

        public void CheckFile()
        {
            if (pathOptionSetup == null)
            {
                pathOptionSetup = new PathOptionSetup(false);
            }

            if (fileOptionSetup == null)
            {
                fileOptionSetup = new FileOptionSetup(false);
            }
        }

        public void LoadtoXML()
        {

        }

        public void SavetoXML()
        {
            fileOptionSetup.SavetoXML(Path.Combine(pathOptionSetup.setupFilePath, "fileOption.xml"));
            pathOptionSetup.SavetoXML(Path.Combine(pathOptionSetup.setupFilePath, "pathOption.xml"));
        }
    }

}
