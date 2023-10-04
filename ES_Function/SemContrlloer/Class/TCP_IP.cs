using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace SemContrlloer
{
    class TCP_IP
    {
        private Socket mainSock;
        private bool isOpened;

        public TCP_IP()
        {
            mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
            isOpened = false;
        }
        public bool Open()
        {
            isOpened = true;

            return isOpened;
        }

        public void Close()
        {

        }

        #region [Server]
        public class Server
        {
            #region [필드]
            Socket mainSock;
            List<Socket> connectedClients = new List<Socket>();
            int port = 5000;
            #endregion

            #region [메소드 : 메인소켓을 만들고 연결을 받아들이기 시작]
            public void Start()
            {
                try
                {
                    mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);

                    IPEndPoint serverEP = new IPEndPoint(IPAddress.Any, port);

                    mainSock.Bind(serverEP);
                    mainSock.Listen(10);
                    mainSock.BeginAccept(AcceptCallBack, null);
                }
                catch (Exception e)
                {
                    throw;
                }
            }
            #endregion

            #region [메소드 : 만들어진 메인소켓을 해제, Dispose하고 연결되어 있던 것을 해제]
            public void Close()
            {
                // 메인소켓 해제
                if (mainSock != null)
                {
                    mainSock.Close();
                    mainSock.Dispose();
                }

                // 서버 -> 어딘가를 향하는 소켓은 목적지가 모두 다르지만 connectedClients에 저장 
                foreach (Socket socket in connectedClients)
                {
                    socket.Close();
                    socket.Dispose();
                }
                connectedClients.Clear();
            }
            #endregion

            #region [메소드 : 클라이언트에서 연결을 시도할 때 어떤 행동을 해야할지 정함]
            private void AcceptCallBack(IAsyncResult ar)
            {
                /*
                 * 받아들인 소켓의 정보들이 IAsyncResult ar에 담겨있고
                 * EndAccept(ar)을 호출하면 메인소켓이 더이상 Client를 받아들이지 않고 현재 소켓의 정보를 client라는 소켓에 저장 
                 * client가 서버에 데이터를 보낼때마다 DataReceived라는 콜백함수로 넘어가 작업을 진행 
                 */
                try
                {
                    Socket client = mainSock.EndAccept(ar);
                    AsyncObject obj = new AsyncObject(1920 * 1080 * 3);
                    obj.WorkingSocket = client;
                    connectedClients.Add(client);
                    client.BeginReceive(obj.Buffer, 0, 1920 * 1080 * 3, 0, DataReceived, obj);
                }
                catch (Exception)
                {

                    throw;
                }
            }

            private void DataReceived(IAsyncResult ar)
            {
                /*
                 * obj.Buffer는 1920 * 1080 * 3으로 지정해준 byte[] 배열
                 * 클라이언트에서 보낸 데이터가 입력되는데 
                 * byte[1000]의 크기로 보냈다면 1000개만 buffer 배열에 따로 저장 
                 */
                AsyncObject obj = (AsyncObject)ar.AsyncState;
                int received = obj.WorkingSocket.EndReceive(ar);
                byte[] buffer = new byte[received];
                Array.Copy(obj.Buffer, 0, buffer, 0, received);
            }
            #endregion

            #region [메소드 : 데이터 전송]
            public void Send(byte[] msg)
            {
                mainSock.Send(msg);
            }
            #endregion

            public class AsyncObject
            {
                public byte[] Buffer;
                public Socket WorkingSocket;
                public readonly int BufferSize;

                public AsyncObject(int bufferSize)
                {
                    BufferSize = bufferSize;
                    Buffer = new byte[(long)BufferSize];
                }

                public void ClearBuffer()
                {
                    Array.Clear(Buffer, 0, BufferSize);
                }
            }
        }
        #endregion

        #region [클라이언트]
        public class Client
        {
            #region [필드]
            Socket mainSock;
            int port = 5000;
            #endregion

            #region [메소드 : 서버의 Start()역할을 하는 Connect() 및 Close()]
            public void Connect()
            {
                mainSock = new Socket(AddressFamily.InterNetwork, SocketType.Stream, ProtocolType.Tcp);
                IPAddress serverAddr = IPAddress.Parse("10.0.0.10");
                IPEndPoint clinetEP = new IPEndPoint(serverAddr, port);
                mainSock.BeginConnect(clinetEP, new AsyncCallback(ConnectCallback), mainSock);
            }

            public void Close()
            {
                if (mainSock != null)
                {
                    mainSock.Close();
                    mainSock.Dispose();
                }
            }
            #endregion

            #region [메소드 : Connect() 정상 연결 시 CallBack]
            public class AsyncObject
            {
                public byte[] Buffer;
                public Socket WorkingSocket;
                public readonly int BufferSize;
                public AsyncObject(int bufferSize)
                {
                    BufferSize = bufferSize;
                    Buffer = new byte[(long)BufferSize];
                }

                public void ClearBuffer()
                {
                    Array.Clear(Buffer, 0, BufferSize);
                }
            }
            private void ConnectCallback(IAsyncResult ar)
            {
                /*
                 * 클라이언트는 목적지가 반드시 서버쪽 IP여야만 함 
                 * 서버쪽은 IPEndPoint의 목적지가 IPAddress.Any 였지만 클라이언트는 목적지를 지정해야함
                 * 정상적으로 받아들여진다면 ConnectCallback으로 접근 
                 */
                try
                {
                    Socket client = (Socket)ar.AsyncState;
                    client.EndConnect(ar);
                    AsyncObject obj = new AsyncObject(4096);
                    obj.WorkingSocket = mainSock;
                    mainSock.BeginReceive(obj.Buffer, 0, obj.BufferSize, 0, DataReceived, obj);
                }
                catch (Exception e)
                {
                    throw;
                }

            }
            #endregion

            #region [메소드 : 데이터 처리]
            private void DataReceived(IAsyncResult ar)
            {
                AsyncObject obj = (AsyncObject)ar.AsyncState;

                int received = obj.WorkingSocket.EndReceive(ar);

                byte[] buffer = new byte[received];

                Array.Copy(obj.Buffer, 0, buffer, 0, received);
            }
            #endregion

            #region [메소드 : 데이터 전송]
            public void Send(byte[] msg)
            {
                mainSock.Send(msg);
            }
            #endregion

        }
        #endregion
    }
}
