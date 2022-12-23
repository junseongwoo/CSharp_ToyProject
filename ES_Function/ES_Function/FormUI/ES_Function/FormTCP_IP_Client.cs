using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_Function
{
    public partial class FormTCP_IP_Client : Form
    {
        #region [필드]
        Socket clientSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        byte[] receiveBytes = null;
        string pathLogFile = string.Empty;
        #endregion
        public FormTCP_IP_Client()
        {
            InitializeComponent();

            Initialize();
        }

        public class AsyncStateDataClient
        {
            public byte[] Buffer;
            public Socket Socket;
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
                    if (clientSock.Connected == false)
                    {
                        clientSock.Connect(new IPEndPoint(IPAddress.Parse(txtIPAddress.Text), 9000));
                        btnOpen.Text = "Close";
                    }
                }
                else
                {
                    clientSock.Close();
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
                if (clientSock.Connected == true)
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
            int readIndex = 0, handleIndex = 0;
            Regex regSV = new Regex("([A-Z0-9_]+)\\(([0-9]+)\\)=([-+0-9\\.]+)");

            try
            {
                while (true)
                {
                    Thread.Sleep(100);

                    if (clientSock.Connected == true)
                    {
                        if (bwClient.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }
                        AsyncStateDataClient data = new AsyncStateDataClient();
                        data.Buffer = new byte[1 << 20];
                        data.Socket = clientSock;
                        //clientSock.BeginReceive(data.Buffer, readIndex, data.Buffer.Length - readIndex, SocketFlags.None, receiveStr, data);
                        int read = clientSock.Receive(data.Buffer, 0, data.Buffer.Length, SocketFlags.None);

                        string test = Encoding.Default.GetString(data.Buffer);

                        // 크로스 스레드 방지 하려면 Invoke 써야함 
                        rtxReceiveMsg.Invoke(new MethodInvoker(delegate ()
                        {
                            rtxReceiveMsg.Text = test;
                        }));


                        //readIndex += read;

                        //int idx = Array.IndexOf(data.Buffer, (byte)'\r', handleIndex, readIndex - handleIndex);
                        //if (idx < 0) break;

                        //string line = Encoding.UTF8.GetString(data.Buffer, handleIndex, idx - handleIndex);
                        //handleIndex = Math.Min(idx + 2, readIndex);

                        //string[] arr = line.Substring(0).Split(',');
                        //foreach (string str in arr)
                        //{
                        //    if (str == "")
                        //        continue;
                        //    var match = regSV.Match(str);
                        //}

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
            AsyncStateDataClient data = ar.AsyncState as AsyncStateDataClient;
            int strLength = data.Socket.EndReceive(ar);
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
