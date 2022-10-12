using CsvHelper;
using DrawCsvToLine.Utils;
using LiveChartsCore.SkiaSharpView;
using LiveChartsCore;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.Painting;
using SkiaSharp;
using LiveChartsCore.SkiaSharpView.WinForms;
using LiveChartsCore.SkiaSharpView.Painting.Effects;
using Newtonsoft.Json;
using DrawCsvToLine.DataClass;

namespace DrawCsvToLine
{
    public partial class MainFrom : Form
    {
        LineSeries<double> line1;
        LineSeries<double> line2;
        List<ChartData> chartDataList = new List<ChartData>();
        List<string> xAxisDatas = new List<string>();
        List<double> lineData1 = new List<double>();
        List<double> lineData2 = new List<double>();
        public MainFrom()
        {
            InitializeComponent();
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            initJsonData();
            line1 = new LineSeries<double>
            {
                //Values = new[] { 2, 5, 4, 2, 6, 2, 5, 4, 2, 6, 2, 5, 4, 2, 6, 2, 5, 4, 2, 6, 2, 5, 4, 2, 6, 2, 5, 4, 2, 6, 2, 5, 4, 2, 6 },//数据
                Values = lineData1,
                Name = chartDataList[0].lineData1,//线的名字
                Stroke = new SolidColorPaint(SKColors.Blue) { StrokeThickness = 1 },//线的颜色与粗细
                GeometrySize = 3,//数据点的大小
                LineSmoothness = 0,//曲线曲率
                GeometryFill = new SolidColorPaint(SKColors.Blue),//实心点颜色
                GeometryStroke = new SolidColorPaint(SKColors.Blue) { StrokeThickness = 5 },//实心点大小
                Fill = null
            };
            line2 = new LineSeries<double>
            {
                //Values = new[] { 3, 7, 2, 9, 4, 3, 7, 2, 9, 4, 3, 7, 2, 9, 4, 3, 7, 2, 9, 4, 3, 7, 2, 9, 4, 3, 7, 2, 9, 4 },
                Values = lineData2,
                Name = chartDataList[0].lineData2,
                Stroke = new SolidColorPaint(SKColors.Red) { StrokeThickness = 2 },
                GeometrySize = 3,
                LineSmoothness = 0,
                GeometryFill = new SolidColorPaint(SKColors.Red),
                GeometryStroke = new SolidColorPaint(SKColors.Red) { StrokeThickness = 5 },
                Fill = null
            };
            var xAxis = new Axis
            {
                Name = chartDataList[0].time,
                NamePaint = new SolidColorPaint(SKColors.Black),

                LabelsPaint = new SolidColorPaint(SKColors.Blue),
                TextSize = 10,

                //Labels = new string[] {"2", "2", "2", "2", "2", "2", "2" },
                Labels = xAxisDatas,
                SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray) { StrokeThickness = 2 }
            };
            //var yAxis = new Axis
            //{
            //    Name = "Y Axis",
            //    NamePaint = new SolidColorPaint(SKColors.Red),

            //    LabelsPaint = new SolidColorPaint(SKColors.Green),
            //    TextSize = 20,
            //    SeparatorsPaint = new SolidColorPaint(SKColors.LightSlateGray)
            //    {
            //        StrokeThickness = 2,
            //        PathEffect = new DashEffect(new float[] { 3, 3 })
            //    }
            //};
            cartesianChart1.XAxes = new List<Axis> { xAxis };
            //cartesianChart1.YAxes = new List<Axis> { yAxis };
            cartesianChart1.Series = new ISeries[]{line1, line2};
            
            cartesianChart1.DrawMarginFrame = new DrawMarginFrame
            {
                Fill = new SolidColorPaint(SKColors.AliceBlue),
                Stroke = new SolidColorPaint(SKColors.Black, 1)
            };
            cartesianChart1.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.Both;
            cb_line1.Text = $"hide_{line1.Name}";
            cb_line2.Text = $"hide_{line2.Name}";
            //List<List<string>> data = CSVFiles.Read<List<string>>(@"C:\Users\automation.public\Desktop\111\data0.csv",isLine:true);

        }

        private void initJsonData()
        {
            chartDataList = CSVFiles.Read(@"D:\pppp\1121BBD00176_A1-BA110_20220929_110843_1_P.csv", ChartData.Parse,isLine:true);
            foreach (ChartData chartData in chartDataList)
            {
                if (chartData == chartDataList[0])
                {
                    continue;
                }
                xAxisDatas.Add(chartData.time);
                lineData1.Add(Convert.ToDouble(chartData.lineData1));
                lineData2.Add(Convert.ToDouble(chartData.lineData2));
            }
            //string photoInfoPath = File.ReadAllText(@"");
            //JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(photoInfoPath);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //line2.IsVisible = !line2.IsVisible;//显示or隐藏曲线
            //Utils.Utils.saveChartToImg(cartesianChart1);//保存图片
            string path = Utils.Utils.selectFolder2();
            if (path != null)
            {
                listBox1.Items.Clear();
                listBox1.Items.AddRange(Utils.Utils.addFileSystemEntries($"{path}"));
            }
        }

        private void cb_line1_CheckedChanged(object sender, EventArgs e)
        {
            line1.IsVisible = !cb_line1.Checked;
        }

        private void cb_line2_CheckedChanged(object sender, EventArgs e)
        {
            line2.IsVisible = !cb_line2.Checked;
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string path = listBox1.Items[listBox1.SelectedIndex].ToString();
            JsonConvert.DeserializeObject<Dictionary<string, Dictionary<string, string>>>(path);
        }
    }

}
