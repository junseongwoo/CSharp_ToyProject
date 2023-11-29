using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace ESVision
{
    public partial class formHistogram : Form
    {
        public Bitmap bmp = null;

        public formHistogram()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                picboxHistogram.Image = Image.FromFile($"C:\\Users\\SW팀\\Desktop\\iMAGE\\Test2.jpg");
                bmp = new Bitmap(picboxHistogram.Image);
            }
            catch (Exception)
            {

                throw;
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            chartHistogram.Series.Clear();

            string[] seriesNames = { "Red", "Green", "Blue" };
            Color[] seriesColors = { Color.Red, Color.Green, Color.Blue };
            var hist = Vars.imgLib.GetHist(bmp);

            for (int index = 0; index < hist.Length; index++)
            {
                chartHistogram.Series.Add(seriesNames[index]);
                chartHistogram.Series[seriesNames[index]].ChartType = SeriesChartType.Line;
                chartHistogram.Series[seriesNames[index]].Color = seriesColors[index];
                for (int i = 0; i < 256; i++)
                {
                    chartHistogram.Series[seriesNames[index]].Points.AddXY(i, hist[index][i]);
                }
            }
        }
    }
}
