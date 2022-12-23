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
    public partial class FormTCP_IP_Server : Form
    {
        #region [필드]
        TxtFile txtFile = new TxtFile();
        string pathLogFile = string.Empty;
        string startMsg = string.Empty;
        #endregion
        public FormTCP_IP_Server()
        {
            InitializeComponent();
        }

        private void bwTcpIpServer_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] logMsg = txtFile.readTxtAllLines(pathLogFile);
            try
            {

            }
            catch (Exception)
            {
                throw;
            }
        }

        #region BackgroundWorker Run 
        private void bwRS232_Run()
        {
            bwTcpIpServer.RunWorkerAsync();
            btnSendTCPIP.Text = "Send Stop";
            lblSendCheck.Text = "true";
        }
        #endregion

        #region BackgroundWorker Cancel
        private void bwRS232_Cancel()
        {
            bwTcpIpServer.CancelAsync();
            btnSendTCPIP.Text = "Send Start";
            lblSendCheck.Text = "false";
            Thread.Sleep(100);
        }
        #endregion
        private void btnConnect_Click(object sender, EventArgs e)
        {

        }

        private void btnSendTCPIP_Click(object sender, EventArgs e)
        {

        }

        private void FormTCP_IP_Server_Load(object sender, EventArgs e)
        {
            Initialize();
        }

        private void Initialize()
        {
            pathLogFile = $"D:\\업무\\CIM\\Log\\SEM\\Log_20221109.log";

            lblLogFilePath.Text = pathLogFile.Split('\\').Last();
            cboIPNum.SelectedIndex = 0;
            cboPortNum.SelectedIndex = 0;
        }
    }
}
