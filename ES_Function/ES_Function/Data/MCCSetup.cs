using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_Function
{
    class MCCSetup
    {
        public string ModuleID { get; set; }
        public string Loader_ModuleID { get; set; }

        public DateTime WriteTime;
        public string MCC_Path = string.Empty;
        public string MCC_Loader_Path = string.Empty;

        public string MCC_CopyPath = string.Empty;
        public string MCC_Loader_CopyPath = string.Empty;

        public string localPath = string.Empty;

        public MCCSetup()
        {
            MCC_Path = "d:\\MCC\\AMAU";
            MCC_Loader_Path = "d:\\MCC\\LD01";
            MCC_CopyPath = "d:\\MCC_Copy";
            MCC_Loader_CopyPath = "d:\\MCC_Loder_Copy";
            localPath = Environment.CurrentDirectory + "\\mcc";
            ModuleID = "A3AMA71G";
            Loader_ModuleID = "A4AMA02E_LD01";
        }
    }
}
