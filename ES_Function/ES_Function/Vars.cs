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
