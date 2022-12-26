using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_Function
{
    static class Program
    {
        /// <summary>
        /// 해당 애플리케이션의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);

                Vars var = new Vars();
            }
            catch (Exception)
            {
                throw;
            }
            Application.Run(new FrmMain());
        }

        public static List<dgvTest> lstdvgTest = new List<dgvTest>();

    }
}
