using ES_Function.Com;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ES_Function.FormUI
{
    public partial class FormReceiveRS232 : Form
    {
        #region 생성자
        RS232 serial = new RS232();
        SerialPort s2 = new SerialPort();
        #endregion
        public FormReceiveRS232()
        {
            InitializeComponent();
        }

        private void FormReceiveRS232_Load(object sender, EventArgs e)
        {
            Init();
        }

        #region 초기화
        private void Init()
        {
            cboPortNumRS232.SelectedIndex = 0;
            cboBaudrateRS232.SelectedIndex = 0;
        }
        #endregion

        private void btnOpenRS232_Click(object sender, EventArgs e)
        {
            try
            {
                if (s2.IsOpen == false)
                {
                    s2.PortName = cboPortNumRS232.Text;
                    s2.BaudRate = Convert.ToInt32(cboBaudrateRS232.Text);
                    s2.DataBits = 8;
                    s2.StopBits = StopBits.One;
                    s2.Parity = Parity.Even;
                    s2.NewLine = Environment.NewLine;
                    s2.ReadTimeout = 1000;
                    s2.WriteTimeout = 1000;

                    s2.Open();
                    btnCheckRS232.BackColor = Color.Lime;
                    btnOpenRS232.Text = "Close";
                }
                else
                {
                    s2.Close();
                    bwReceiveRS232_Cancel();
                    btnCheckRS232.BackColor = Color.Red;
                    btnOpenRS232.Text = "Open";
                }

                //if (serial.IsOpened() == false)
                //{
                //    serial.Open(cboPortNumRS232.Text, Convert.ToInt32(cboBaudrateRS232.Text));
                //    btnCheckRS232.BackColor = Color.Lime;
                //    btnOpenRS232.Text = "Close";
                //}
                //else
                //{
                //    serial.Close();
                //    bwReceiveRS232_Cancel();
                //    btnCheckRS232.BackColor = Color.Red;
                //    btnOpenRS232.Text = "Open";
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void bwReceiveRS232_Run()
        {
            bwReceiveRS232.RunWorkerAsync();
            Thread.Sleep(100);
        }

        private void bwReceiveRS232_Cancel()
        {
            bwReceiveRS232.CancelAsync();
            Thread.Sleep(100);
        }

        private void bwReceiveRS232_DoWork(object sender, DoWorkEventArgs e)
        {
            while (true)
            {
                s2.WriteLine("$START");
                s2.ReadLine();
            }

            //serial.SendData("$START");
            //while (true)
            //{
            //    try
            //    {
            //        if (serial.ReadToBytes() > 0)
            //        {
            //            string msg = serial.ReadData();
            //        }
            //        if (bwReceiveRS232.CancellationPending == true)
            //        {
            //            e.Cancel = true;
            //            return;
            //        }
            //    }
            //    catch (Exception ex)
            //    {
            //        MessageBox.Show("DoWork 에러" + ex.ToString());
            //    }
            //}
        }

        private void btnReceiveStart_Click(object sender, EventArgs e)
        {
            if (s2.IsOpen == true)
            {
                if (bwReceiveRS232.IsBusy == false)
                {
                    bwReceiveRS232_Run();
                    btnReceiveStart.Text = "Receive End";
                }
                else
                {
                    bwReceiveRS232_Cancel();
                    btnReceiveStart.Text = "Receive Start";
                }
            }
            else
            {
                bwReceiveRS232_Cancel();
                btnReceiveStart.Text = "Receive Start";
            }

            //if(serial.IsOpened() == true)
            //{
            //    if (bwReceiveRS232.IsBusy == false)
            //    {
            //        bwReceiveRS232_Run();
            //        btnReceiveStart.Text = "Receive End";
            //    }
            //    else
            //    {
            //        bwReceiveRS232_Cancel();
            //        btnReceiveStart.Text = "Receive Start";
            //    }
            //}
            //else
            //{
            //    bwReceiveRS232_Cancel();
            //    btnReceiveStart.Text = "Receive Start";
            //}
        }
    }
}

