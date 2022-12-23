using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_Function
{
    class FileLib
    {
        #region [필드]
        public DateTime WriteTime;
        #endregion

        #region [생성자]
        #endregion
        #region 디렉토리 안의 파일 리스트 얻기
        public void getFileList(string folderPath)
        {
            DirectoryInfo di = new DirectoryInfo(folderPath);

            foreach (FileInfo file in di.GetFiles())
            {
                // 전체 경로 출력 
                string fileFullName = file.FullName;
                // 파일 이름만 출력
                string fileName = file.Name;
            }
        }
        #endregion

        #region 폴더안에 다른 폴더 정보 얻기 
        public void getOtherFolderInfo(string folderPath)
        {
            DirectoryInfo di = new DirectoryInfo(folderPath);
            foreach (DirectoryInfo sub_Dir in di.GetDirectories())
            {
                // 전체 경로 출력
                string subFolderDir = sub_Dir.FullName;
                // 폴더 이름만 출력
                string subFolderName = sub_Dir.Name;
            }
        }
        #endregion

        #region 하위 디렉토리 포함 폴더안에 있는 모든 파일 이름 얻기 
        public string[] getAllFileName(string folderPath)
        {
            string[] allFiles = null;
            return allFiles = Directory.GetFiles(folderPath, "*.*", SearchOption.AllDirectories);
        }
        #endregion

        #region [생성자 : Create AMAU & LD I Log Header]
        public void CreateAMAU_ILogHeader(string NewHeader, bool Append)
        {
            string Header = "";

            using (StreamWriter sw = new StreamWriter(NewHeader, Append, Encoding.Default))
            {
                Header = "EventTime" + "," + "LogType" + "," +
                  "AMAU=LINEAR_SHUTTLE_POS(CTS)" + "," +
                  "AMAU=SERVO_CAM_T_POS(CTS)" + "," +
                  "AMAU=SERVO_LED_X_POS(CTS)" + "," +
                  "AMAU=SERVO_LED_Z_POS(CTS)" + "," +
                  "AMAU=SERVO_LED_T_POS(CTS)" + "," +
                  "AMAU=SERVO_LIFT_Z_POS(CTS)" + "," +
                  "AMAU=SERVO_LIFT_TURN_POS(CTS)" + "," +
                  "AMAU=LINEAR_SHUTTLE_SPD(mm/s)" + "," +
                  "AMAU=SERVO_CAM_T_SPD(mm/s)" + "," +
                  "AMAU=SERVO_LED_X_SPD(mm/s)" + "," +
                  "AMAU=SERVO_LED_Z_SPD(mm/s)" + "," +
                  "AMAU=SERVO_LED_T_SPD(mm/s)" + "," +
                  "AMAU=SERVO_LIFT_Z_SPD(mm/s)" + "," +
                  "AMAU=SERVO_LIFT_TURN_SPD(mm/s)" + "," +
                  "AMAU=SET_LINEAR_SHUTTLE_POS(CTS)" + "," +
                  "AMAU=SET_SERVO_CAM_T_POS(CTS)" + "," +
                  "AMAU=SET_SERVO_LED_X_POS(CTS)" + "," +
                  "AMAU=SET_SERVO_LED_Z_POS(CTS)" + "," +
                  "AMAU=SET_SERVO_LED_T_POS(CTS)" + "," +
                  "AMAU=SET_SERVO_LIFT_Z_POS(CTS)" + "," +
                  "AMAU=SET_SERVO_LIFT_TURN_POS(CTS)" + "," +
                  "AMAU=SET_LINEAR_SHUTTLE_SPD(mm/s)" + "," +
                  "AMAU=SET_SERVO_CAM_T_SPD(mm/s)" + "," +
                  "AMAU=SET_SERVO_LED_X_SPD(mm/s)" + "," +
                  "AMAU=SET_SERVO_LED_Z_SPD(mm/s)" + "," +
                  "AMAU=SET_SERVO_LED_T_SPD(mm/s)" + "," +
                  "AMAU=SET_SERVO_LIFT_Z_SPD(mm/s)" + "," +
                  "AMAU=SET_SERVO_LIFT_TURN_SPD(mm/s)" + "," +
                  "AMAU=FFU_STATE()" + "," +
                  "AMAU=IONIZER_STATE()" + "," +
                  "AMAU=AIR_FLOATING_STATE()" + "," +
                  "AMAU=SERVO_ALIGN_CAM1_X_POS(CTS)" + "," +
                  "AMAU=SERVO_ALIGN_CAM2_X_POS(CTS)" + "," +
                  "AMAU=SET_SERVO_ALIGN_CAM1_X_POS(CTS)" + "," +
                  "AMAU=SET_SERVO_ALIGN_CAM2_X_POS(CTS)";

                sw.WriteLine(Header);
                sw.Close();
            }
        }

        public void CreateLD_ILogHeader(string NewHeader, bool Append)
        {
            string Header = "";

            using (StreamWriter sw = new StreamWriter(NewHeader, Append, Encoding.Default))
            {
                Header = "EventTime" + "," + "LogType" + "," +
                  "LD01_TM01=SET_LOW_Y_AXIS_DTN_POS(mm)" + "," +
                  "LD01_TM01=LOW_Y_AXIS_SPD(mm/s)" + "," +
                  "LD01_TM01=LOW_Y_AXIS_CRT_POS(mm)" + "," +
                  "LD01_TM01=LOW_Y_AXIS_TRQ(%)" + "," +
                  "LD01_TM01=SET_UPP_Y_AXIS_DTN(mm)" + "," +
                  "LD01_TM01=UPP_Y_AXIS_SPD(mm/s)" + "," +
                  "LD01_TM01=UPP_Y_AXIS_POSI(mm)" + "," +
                  "LD01_TM01=UPP_Y_AXIS_TRQ(%)" + "," +
                  "LD01_TM01=SET_T_AXIS_DTN_POS(mm)" + "," +
                  "LD01_TM01=T_AXIS_SPD(mm/s)" + "," +
                  "LD01_TM01=T_AXIS_CRT_POS(mm)" + "," +
                  "LD01_TM01=T_AXIS_TRQ(%)" + "," +
                  "LD01_TM01=X_AXIS_DTN_POS(mm)" + "," +
                  "LD01_TM01=X_AXIS_SPD(mm/s)" + "," +
                  "LD01_TM01=SET_X_AXIS_CRT_POS(mm)" + "," +
                  "LD01_TM01=X_AXIS_TRQ(%)" + "," +
                  "LD01_TM01=Z1_AXIS_SPD(mm/s)" + "," +
                  "LD01_TM01=Z2_AXIS_SPD(mm/s)" + "," +
                  "LD01_TM01=Z1_AXIS_CRT_POS(mm)" + "," +
                  "LD01_TM01=Z2_AXIS_CRT_POS(mm)" + "," +
                  "LD01_TM01=Z1_AXIS_TRQ(%)" + "," +
                  "LD01_TM01=Z2_AXIS_TRQ(%)" + "," +
                  "LD01_TM01=SET_Z1_AXIS_DTN_POS(mm)" + "," +
                  "LD01_TM01=SET_Z2_AXIS_DTN_POS(mm)" + "," +
                  "LD01_TM01=INDEX_TEMERATURE" + "," +      // (℃)
                  "LD01_TM01=SET_ROBOT_SPEED";              // (%)
                sw.WriteLine(Header);
                sw.Close();
            }
        }
        #endregion

        #region [멤버 함수 : MCC 파일 생성]
        public void MCCFileCreate(string EQtype, DateTime dt)
        {
            string subfileName;
            WriteTime = dt;
            bool Append = true;

            if (EQtype == "AMAU")
            {
                string NewHeader = Path.Combine(Vars.MCCSetup.MCC_Path, $"{DateTime.Now.ToString("yyMMdd")}", "I");
                Directory.CreateDirectory(NewHeader);
                NewHeader = Path.Combine(NewHeader, $"I-{Vars.MCCSetup.ModuleID}-{WriteTime.ToString("yyyyMMddHHmmss")}.csv");

                CreateAMAU_ILogHeader(NewHeader, Append);

                subfileName = Path.Combine($"index-{Vars.MCCSetup.ModuleID}-{WriteTime.ToString("yyyyMMddHHmmss")}.csv");
                File.Create(Path.Combine(Vars.MCCSetup.MCC_Path, "index", subfileName));

                //T파일 덩어리만 만들자
                subfileName = Path.Combine($"T-{Vars.MCCSetup.ModuleID}-{WriteTime.ToString("yyyyMMddHHmmss")}.csv");
                Directory.CreateDirectory(Path.Combine(Vars.MCCSetup.MCC_Path, $"{DateTime.Now.ToString("yyMMdd")}", "T"));
                using (FileStream FS = File.Create(Path.Combine(Vars.MCCSetup.MCC_Path, $"{DateTime.Now.ToString("yyMMdd")}", "T", subfileName))) { FS.Close(); }
            }
            else if (EQtype == "LD")
            {
                string NewHeader = Path.Combine(Vars.MCCSetup.MCC_Loader_Path, $"{DateTime.Now.ToString("yyMMdd")}", "I");
                Directory.CreateDirectory(NewHeader);
                NewHeader = Path.Combine(NewHeader, $"I-{Vars.MCCSetup.Loader_ModuleID}-{WriteTime.ToString("yyyyMMddHHmmss")}.csv");

                CreateAMAU_ILogHeader(NewHeader, Append);

                Directory.CreateDirectory(Path.Combine(Vars.MCCSetup.MCC_Loader_Path, "index"));

                subfileName = Path.Combine($"index-{Vars.MCCSetup.Loader_ModuleID}-{WriteTime.ToString("yyyyMMddHHmmss")}.csv");
                File.Create(Path.Combine(Vars.MCCSetup.MCC_Loader_Path, "index", subfileName));

                //T파일 덩어리만 만들자
                subfileName = Path.Combine($"T-{Vars.MCCSetup.Loader_ModuleID}-{WriteTime.ToString("yyyyMMddHHmmss")}.csv");
                Directory.CreateDirectory(Path.Combine(Vars.MCCSetup.MCC_Loader_Path, $"{DateTime.Now.ToString("yyMMdd")}", "T"));
                using (FileStream FS = File.Create(Path.Combine(Vars.MCCSetup.MCC_Loader_Path, $"{DateTime.Now.ToString("yyMMdd")}", "T", subfileName))) { FS.Close(); }
            }
        }
        #endregion


        public void MCCFileCheck()
        {

        }

        public void MCCFileWrite()
        {

        }
    }
}
