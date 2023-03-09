using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESVision
{
    [Serializable]
    public class PathOptionSetup
    {
        [Category("File Path"), Description("프로그램 구성에 필요한 파일 경로")]
        public string SetupFilePath { get; set; }
        [Category("File Path"), Description("프로그램 구성에 필요한 파일 경로")]
        public string LogFilePath { get; set; }

        public PathOptionSetup() 
        {
            //LogFilePath = "Test";
            //SetupFilePath = "Test2";
        }

        public PathOptionSetup SavetoXML()
        {
            PathOptionSetup setup = null;

            return setup;
        }

        public PathOptionSetup LoadtoXML()
        {
            PathOptionSetup setup = null;

            return setup;
        }
    }

    
}
