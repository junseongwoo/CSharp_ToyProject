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

namespace SemContrlloer
{
    public partial class MainForm : Form
    {
        #region [생성자]
        SerialPort PortRS232 = new SerialPort();
        RS232 RS232 = new RS232();
        #endregion
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            Init();
        }

        #region [초기화]
        private void Init()
        {
            cboPortNumRS232.SelectedIndex = 0;
            cboBaudrateRS232.SelectedIndex = 0;
            cboIPNumTCPIP.SelectedIndex = 0;
            cboPortNumTCPIP.SelectedIndex = 0;
        }
        #endregion

        private void btnOpenRS232_Click(object sender, EventArgs e)
        {
            try
            {
                if (RS232.IsOpened() == false)
                {
                    RS232.Open(PortRS232, cboPortNumRS232.Text, Convert.ToInt32(cboBaudrateRS232.Text));
                    PortRS232.WriteLine("$START");
                    bwReceiveRS232_Run();
                    btnCheckRS232.BackColor = Color.Lime;
                    btnOpenRS232.Text = "Close";
                }
                else
                {
                    PortRS232.Close();
                    bwReceiveRS232_Cancel();
                    btnCheckRS232.BackColor = Color.Red;
                    btnOpenRS232.Text = "Open";
                }

                //if (PortRS232.IsOpen == false)
                //{
                //    PortRS232.PortName = cboPortNumRS232.Text;
                //    PortRS232.BaudRate = Convert.ToInt32(cboBaudrateRS232.Text);
                //    PortRS232.DataBits = 8;
                //    PortRS232.StopBits = StopBits.One;
                //    PortRS232.Parity = Parity.Even;
                //    PortRS232.NewLine = Environment.NewLine;
                //    PortRS232.ReadTimeout = 1000;
                //    PortRS232.WriteTimeout = 1000;

                //    PortRS232.Open();
                //    btnCheckRS232.BackColor = Color.Lime;
                //    btnOpenRS232.Text = "Close";
                //}
                //else
                //{
                //    PortRS232.Close();
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

        private void btnOpenTCPIP_Click(object sender, EventArgs e)
        {

        }

        private void bwReceiveRS232_DoWork(object sender, DoWorkEventArgs e)
        {
            BackgroundWorker worker = sender as BackgroundWorker;
            SemConfig semConfig = (SemConfig)SemConfig.BinLoad(SemConfig.FILE_PATH);
            char[] splitChar = { '$', '(', ')', '=', ',', '\r' };

            const int SVNAME_INDEX = 1;
            const int SVID_INDEX = 2;
            const int SVVALUE_INDEX = 4;
            const int NEXT_INDEX = 4;

            const int SEM_LIGHT_ALARM_ID = 1000000;
            const string SEM_LIGHT_ALARM_REASON = "Samsung Environment Monitoring Interface";

            while (true)
            {
                try
                {
                    if (RS232.IsOpened() == true)
                    {
                        break;
                    }

                    if (RS232.CheckReadBuffer() == true)
                    {
                        break;
                    }

                    if (worker.CancellationPending == true)
                    {
                        if (RS232.IsOpened() == true)
                        {
                            RS232.Close();
                        }
                        return;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("RS232 통신 상태 체크 오류");
                    RS232.Close();
                }
            }

            while (true)
            {
                try
                {
                    if (RS232.CheckReadBuffer() == true)
                    {
                        string msg = RS232.ReadData();
                        string[] items = msg.Split(splitChar);
                        int i = 0;
                        for (i = 0; i < (items.Length / NEXT_INDEX); ++i)
                        {
                            int svid;
                            //if (int.TryParse(items[i * NEXT_INDEX + SVID_INDEX], out svid) == true && svid == 65000)
                            if (int.TryParse(items[i * NEXT_INDEX + SVID_INDEX], out svid) == true && svid == 65001)
                                continue;

                            var item = semData.Items.Find(s => s.SVID == svid);

                            if (item == null)
                            {
                                if (items[i * NEXT_INDEX + SVNAME_INDEX] == "Error")
                                {
                                    MessageBox.Show("Receive Error Value");
                                }
                                else
                                {
                                    SVIDItem svidItem = new SVIDItem();
                                    svidItem.SVIDName = items[i * NEXT_INDEX + SVNAME_INDEX];
                                    svidItem.SVID = svid;
                                    svidItem.SVIDValue = items[i * NEXT_INDEX + SVVALUE_INDEX];
                                    semData.Items.Add(svidItem);
                                }
                            }
                            else
                            {
                                item.SVIDValue = items[i * NEXT_INDEX + SVVALUE_INDEX];
                            }
                        }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("SEM Data 읽기 오류");
                }
            }
        }
    }
}
