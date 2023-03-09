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
    public class FileOptionSetup
    {
        [Category("Log 파일 삭제 주기")]
        public string Test2 { get; set; }

        [Category("Test")]
        public int Test3 { get; set; }

        public FileOptionSetup()
        {

        }

        public FileOptionSetup(bool check)
        {
            Test2 = "30";
            Test3 = 15;
        }

        public void SavetoXML(string fileName)
        {
            Directory.CreateDirectory(Path.GetDirectoryName(fileName));
            using (StreamWriter sw = new StreamWriter(fileName, false, Encoding.Default))
            {
                XmlSerializer xs = new XmlSerializer(typeof(FileOptionSetup));
                xs.Serialize(sw, this);
            }
        }

        public FileOptionSetup LoadtoXML()
        {
            FileOptionSetup setup = null;

            return setup;
        }
    }


}
