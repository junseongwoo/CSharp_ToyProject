using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_Function
{
    public partial class FormTCP_IP_Client : Form
    {
        #region [필드]
        Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        byte[] receiveBytes = null;
        string pathLogFile = string.Empty;
        #endregion
        public FormTCP_IP_Client()
        {
            InitializeComponent();

            Initialize();
        }

        private void Initialize()
        {
            pathLogFile = $"D:\\업무\\CIM\\Log\\SEM\\Log_20221109.log";
            txtIPAddress.Text = "192.168.0.155";
            txtPortNum.Text = "9000";
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnOpen.Text == "Open")
                {
                    if (sock.Connected == false)
                    {
                        sock.Connect(new IPEndPoint(IPAddress.Parse(txtIPAddress.Text), 9000));
                        btnOpen.Text = "Close";
                    }
                }
                else
                {
                    sock.Close();
                    btnOpen.Text = "Close";
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Client 연결 실패" + ex.ToString());
            }
            
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (sock.Connected == true)
                {
                    if (bwClient.IsBusy == false)
                    {
                        bwClient_Run();
                    }
                    else
                    {
                        bwClient_Cancel();
                    }
                }
                else
                {
                    bwClient_Cancel();
                    MessageBox.Show("TCP/IP가 연결 상태가 아닙니다.");
                }
            }
            catch (Exception ex)
            {
                bwClient_Cancel();
                MessageBox.Show(ex.ToString());
            }
        }

        private void bwClient_DoWork(object sender, DoWorkEventArgs e)
        {
            receiveBytes = new byte[1<<10];
            try
            {
                while (true)
                {
                    Thread.Sleep(100);

                    if (sock.Connected == true)
                    {
                        sock.BeginReceive(receiveBytes, 0, receiveBytes.Length, SocketFlags.None,
                            new AsyncCallback(receiveStr), sock);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Receive Fail" + ex.ToString());
            }
        }

        private void receiveStr(IAsyncResult ar)
        {
            Socket transferSock = (Socket)ar.AsyncState;
            int strLength = transferSock.EndReceive(ar);
            rtxReceiveMsg.Text = Encoding.Default.GetString(receiveBytes);
        }

        #region BackgroundWorker Run 
        private void bwClient_Run()
        {
            bwClient.RunWorkerAsync();
            btnSend.Text = "Receive Stop";
        }
        #endregion

        #region BackgroundWorker Cancel
        private void bwClient_Cancel()
        {
            bwClient.CancelAsync();
            btnSend.Text = "Receive Start";
            Thread.Sleep(100);
        }
        #endregion
    }
}
