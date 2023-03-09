using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ESVision
{
    [Serializable]
    public class PathOptionSetup
    {
        [Category("File Path"), Description("프로그램 구성에 필요한 파일 경로")]
        public string setupFilePath { get; set; }
        [Category("File Path"), Description("프로그램 구성에 필요한 파일 경로")]
        public string logFilePath { get; set; }

        public PathOptionSetup() 
        {
        }

        // checkFile이 false 일 때만 사용 = XML 파일이 없을 떄 초기화 하기 위함 
        public PathOptionSetup(bool check)
        {
            logFilePath = @"D:\\ESVision\\Setup\\";
            setupFilePath = @"D:\\ESVision\\Setup\\";
        }

        public void SavetoXML(string fileName)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(fileName));
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.Default))
            {
                XmlSerializer xs = new XmlSerializer(typeof(PathOptionSetup));
                xs.Serialize(sw, this);
            }
        }

        public PathOptionSetup LoadtoXML()
        {
            PathOptionSetup setup = null;

            return setup;
        }
    }

    
}
