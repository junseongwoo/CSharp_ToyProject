using System;
using System.Collections.Generic;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ES_Function.Com
{
    class RS232
    {
        private SerialPort Serial; // C# 에서 지원 하는 Serial 통신 클래스
        private bool isOpened; // 현재 Serial 통신이 연결 되어있는가 체크 하는 변수
        public RS232() // RS232 클래스 생성자 ( 클래스 생성할시 바로 호출됨 )
        {
            Serial = new SerialPort();
            isOpened = false;
        }

        #region 시리얼 통신 연결
        public bool Open(string port, int baudrate)
        {
            if (isOpened == true)
                return isOpened;

            Serial.PortName = port;
            Serial.BaudRate = baudrate; // 데이터 전송 속도
            Serial.DataBits = 8; // 데이터 비트
            Serial.StopBits = StopBits.One; // 스탑비트
            Serial.Parity = Parity.Even; // 패리티
            Serial.NewLine = Environment.NewLine;
            Serial.ReadTimeout = 1000;
            Serial.WriteTimeout = 1000;

            //Serial.DataReceived += new SerialDataReceivedEventHandler(ev) //데이터 받을때의 실행되는 부분

            Serial.Open(); // 위에 기입한 Serial의 데이터를 기반으로 연결 시도
            isOpened = Serial.IsOpen;
            return isOpened;
        }
        #endregion

        #region 시리얼 통신 끊기
        public void Close()
        {
            Serial.Close();
            isOpened = false;
        }
        #endregion

        #region 시리얼 통신 연결 확인
        public bool IsOpened()
        {
            return isOpened;
        }
        #endregion

        public void SendData(string Msg)
        {
            Serial.Write(Msg);
        }

        public string ReadData()
        {
            return Serial.ReadLine();
        }
    }
}
