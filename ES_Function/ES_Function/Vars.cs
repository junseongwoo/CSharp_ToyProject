using Engion;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_Function
{
    class Vars
    {
        public Vars()
        {
            string initDir = "D:\\Code\\ES_FunctionLog";

            InitLog(initDir);
        }

        /// <summary>
        /// Log 처리 
        /// </summary>
        public static LogEx log;

        private void InitLog(string initDir)
        {
            log = new LogEx(initDir);
            log.AddLogFileList("Error", LogType.Error, LogType.Warning, LogType.Critical);
        }

        /// <summary>
        /// C# 컨트롤 구현 예제 Main Form 
        /// </summary> 
        public static FormCSFuncMain formCSFuncmain;
        public static FormControlValueChange formControlValueChange;
        public static FormDataGridView formDataGridView;
        /// C# 컨트롤 구현 클래스
        /// </summary>
        public static UseControl useControl = new UseControl();

        /// <summary>
        /// MCC Setup
        /// </summary>
        public static MCCSetup MCCSetup = new MCCSetup();

        /// <summary>
        /// File Control Library
        /// </summary>
        public static FileLib Flib = new FileLib();


    }
}
