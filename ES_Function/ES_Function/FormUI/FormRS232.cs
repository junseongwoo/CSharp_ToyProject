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
     *  
     */
    public partial class FormRS232 : Form
    {
        #region 생성자
        RS232 serial = new RS232();
        TxtFile txtFile = new TxtFile();
        string pathLogFile;
        #endregion

        public FormRS232()
        {
            InitializeComponent();
        }

        private void FormRS232_Load(object sender, EventArgs e)
        {
            Init();
        }

        #region Init
        private void Init()
        {
            string pathLogFile = $"D:\\업무\\CIM\\Log\\SEM\\Log_20221109.log";
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
            string startMsg = serial.ReadData();
            if (serial.IsOpened() == true)
            {
                if (startMsg == "$START")
                {
                    bwRS232.RunWorkerAsync();
                    btnSendRS232.Text = "Stop";
                }
            }
            else
            {
                if (bwRS232.IsBusy == true)
                {
                    bwRS232.CancelAsync();
                    btnSendRS232.Text = "Start";
                }
            }
        }

        #endregion

        private void bwRS232_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] logMsg = txtFile.readTxtAllLines(pathLogFile);
            try
            {
                while (true)
                {
                    for (int i = 0; i < logMsg.Length; i++)
                    {
                        Thread.Sleep(10);
                        serial.SendData(logMsg[0]);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
