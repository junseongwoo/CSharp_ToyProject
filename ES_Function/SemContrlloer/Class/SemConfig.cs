using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace SemContrlloer
{
    [Serializable]
    class SemConfig
    {
        public enum EnumSemTrace { Enable, Disable }

        public const string FILE_PATH = "D:\\engion\\Cim\\Setup\\semConfig.dat";  

        public SemConfig()
        {
            SemTrace = EnumSemTrace.Enable;
            Port = 1;
            BaudRate = 9600;
            AlarmTime = 8;
            DataReadTime = 2000;
        }

        public static object BinLoad(string filePath)
        {
            object setup = null;
            BinaryFormatter xs = new BinaryFormatter();
            if (File.Exists(filePath))
            {
                using (FileStream sr = new FileStream(filePath, FileMode.Open))
                {
                    setup = xs.Deserialize(sr);
                }
            }
            return setup;
        }

        public EnumSemTrace SemTrace { get; set; }
        public int Port { get; set; }
        public int BaudRate { get; set; }
        public int AlarmTime { get; set; }
        public int DataReadTime { get; set; }
    }
}
