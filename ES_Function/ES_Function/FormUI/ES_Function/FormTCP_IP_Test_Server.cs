using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace ES_Function
{
    
    public partial class FormTCP_IP_Test_Server : Form
    {
        #region [필드]
        Socket sock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
        Socket clientSock = null;
        IPEndPoint ep = null;
        TxtFile txtFile = new TxtFile();
        string pathLogFile = string.Empty;
        string startMsg = string.Empty;
        #endregion
        public FormTCP_IP_Test_Server()
        {
            InitializeComponent();

            Initialize();
        }
        public class AsyncStateDataServer
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
        /*
         * 1. Server 소켓이 bind()를 하고 listen() 상태로 대기한다.
         * 2. Client 소켓이 connect() 메소드를 통해 Server 소켓으로 접근한다.
         * 3. Server 소켓은 accept() 메소드를 통해 Client와 Server 사이의 연결을 만든다.
         * 4. 통신한다.
         * 5. 통신을 끊는다.
         */
        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnOpen.Text == "Open")
                {
                    if (sock.Connected == false)
                    {
                        // (2) 포트에 바인드
                        ep = new IPEndPoint(IPAddress.Any, 9000);
                        sock.Bind(ep);
                        // (3) 포트 Listening 시작
                        sock.Listen(10);
                        // (4) 연결을 받아들여 새 소켓 생성 (하나의 연결만 받아들임)
                        clientSock = sock.Accept();

                        btnOpen.Text = "Close";
                    }
                    else if (sock.Connected == true)
                    {
                        btnOpen.Text = "Close";
                    }
                }
                else
                {
                    // (7) 소켓 닫기
                    clientSock.Close();
                    sock.Close();
                    btnOpen.Text = "Open";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Open 실패" + ex.ToString());
            }
            
        }

        private void btnSend_Click(object sender, EventArgs e)
        {
            try
            {
                if (btnOpen.Text == "Open")
                {
                    return;
                }
                // 왜 Connected 가 false 인지?
                if (clientSock.Connected == true)
                {
                    if (bwTestServer.IsBusy == false)
                    {
                        bwTestServer_Run();
                    }
                    else
                    {
                        bwTestServer_Cancel();
                    }
                }
                else
                {
                    bwTestServer_Cancel();
                    MessageBox.Show("TCP/IP가 연결 상태가 아닙니다.");
                }
            }
            catch (Exception ex)
            {
                bwTestServer_Cancel();
                MessageBox.Show(ex.ToString());
            }
            
        }
        private void bwTestServer_DoWork(object sender, DoWorkEventArgs e)
        {
            string[] logMsg = txtFile.readTxtAllLines(pathLogFile);

            try
            {
                while (true) // 키 누르면 종료
                {
                    for (int i = 0; i < logMsg.Length; i++)
                    {
                        Thread.Sleep(10);
                        byte[] transferStr = Encoding.Default.GetBytes(logMsg[i]+"\r");

                        if (transferStr.Length < 2)
                        {
                            continue;
                        }

                        if (bwTestServer.CancellationPending)
                        {
                            e.Cancel = true;
                            return;
                        }

                        if (clientSock.Connected == true)
                        {
                            clientSock.BeginSend(transferStr, 0, transferStr.Length, SocketFlags.None,
                                new AsyncCallback(sendStr), clientSock);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("전송 실패" + ex.ToString());
                bwTestServer_Cancel();
            }
        }

        private void sendStr(IAsyncResult ar)
        {
            Socket sock = (Socket)ar.AsyncState;
            int strLength = sock.EndSend(ar);
        }

        #region BackgroundWorker Run 
        private void bwTestServer_Run()
        {
            bwTestServer.RunWorkerAsync();
            btnSend.Text = "Send Stop";
        }
        #endregion

        #region BackgroundWorker Cancel
        private void bwTestServer_Cancel()
        {
            bwTestServer.CancelAsync(); 
            btnSend.Text = "Send Start";
            Thread.Sleep(100);
        }
        #endregion
    }
}
