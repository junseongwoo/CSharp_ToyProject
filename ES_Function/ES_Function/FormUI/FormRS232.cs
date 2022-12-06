using ES_Function.Com;
using ES_Function.FileControl;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_Function.FormUI
{
    /*
     * https://archive.md/cVnNl#selection-797.12-801.62 
     */
    public partial class FormRS232 : Form
    {
        #region 생성자
        RS232 serial = new RS232();
        TxtFile txtFile = new TxtFile();
        string pathLogFile = string.Empty;
        string startMsg = string.Empty;
        #endregion

        public FormRS232()
        {
            InitializeComponent();
        }

        private void FormRS232_Load(object sender, EventArgs e)
        {
            Init();
        }

        #region 초기화
        private void Init()
        {
            pathLogFile = $"D:\\업무\\CIM\\Log\\SEM\\Log_20221109.log";

            lblLogFilePath.Text = pathLogFile.Split('\\').Last();
            cboBaudrateRS232.SelectedIndex = 0;
            cboPortNumRS232.SelectedIndex = 0;
        }
        #endregion

        #region RS232 Open/Close 버튼 
        private void btnOpenRS232_Click(object sender, EventArgs e)
        {
            try
            {
                if (serial.IsOpened() == false)
                {
                    serial.Open(cboPortNumRS232.Text, Convert.ToInt32(cboBaudrateRS232.Text));
                    btnCheckRS232.BackColor = Color.Lime;
                    btnOpenRS232.Text = "Close";
                }
                else
                {
                    serial.Close();
                    bwRS232_Cancel();
                    btnCheckRS232.BackColor = Color.Red;
                    btnOpenRS232.Text = "Open";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }
        #endregion

        #region RS232 메세지 송신
        private void btnSendRS232_Click(object sender, EventArgs e)
        {
            #region Test 용
            //try
            //{
            //    if (serial.IsOpened() == true)
            //    {
            //        if (bwRS232.IsBusy == false)
            //        {
            //            bwRS232_Run();
            //        }
            //        else
            //        {
            //            bwRS232_Cancel();
            //        }
            //    }
            //    else
            //    {
            //        bwRS232_Cancel();
            //    }
            //}
            //catch (Exception ex)
            //{
            //    bwRS232_Cancel();
            //    MessageBox.Show(ex.ToString());
            //}
            #endregion

            #region 실제 CIM 예상
            try
            {
                if (serial.IsOpened() == true)
                {
                    if (bwRS232.IsBusy == false)
                    {
                        bwRS232_Run();
                    }
                    else
                    {
                        bwRS232_Cancel();
                    }
                }
                else
                {
                    bwRS232_Cancel();
                    MessageBox.Show("Port 상태가 Open이 아닙니다.");
                }
            }
            catch (Exception ex)
            {
                bwRS232_Cancel();
                MessageBox.Show(ex.ToString());
            }
            
            
            #endregion

        }
        #endregion

        #region BackgroundWorker Run 
        private void bwRS232_Run()
        {
            bwRS232.RunWorkerAsync();
            btnSendRS232.Text = "Send Stop";
            lblSendCheck.Text = "true";
        }
        #endregion

        #region BackgroundWorker Cancel
        private void bwRS232_Cancel()
        {
            bwRS232.CancelAsync();
            btnSendRS232.Text = "Send Start";
            lblSendCheck.Text = "false";
            Thread.Sleep(100);
        }
        #endregion

        #region $START Msg Receive 
        private void receiveStartMsg()
        {
            try
            {
                string startMsg = serial.ReadData();

                if (startMsg == "$START")
                {

                }
            }
            catch (Exception )
            {
                MessageBox.Show("START 메세지가 없습니다.");
            }
        }
        #endregion

        #region $END Msg Receive 
        private void receiveEndMsg()
        {
            try
            {
                string endMsg = serial.ReadData();

                if (endMsg == "$END")
                {
                    bwRS232.CancelAsync();
                    serial.Close();
                    serial.SendData("$ACK");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("END 메세지가 없습니다." + ex.ToString());
            }

        }
        #endregion

        #region Log 파일을 읽어 한줄씩 시리얼 송신
        private void bwRS232_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] logMsg = txtFile.readTxtAllLines(pathLogFile);
            try
            {
                while (true)
                {
                    if (serial.ReadToBytes() > 0)
                    {
                        startMsg = serial.ReadData();
                    }
                    if (startMsg == "$START")
                    {
                        for (int i = 0; i < logMsg.Length; i++)
                        {
                            Thread.Sleep(10);
                            if (bwRS232.CancellationPending)
                            {
                                e.Cancel = true;
                                return;
                            }
                            if (serial.IsOpened() == true)
                            {
                                serial.SendData(logMsg[i]);
                            }
                            else
                            {
                                e.Cancel = true;
                                return;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        #endregion
    }
}
