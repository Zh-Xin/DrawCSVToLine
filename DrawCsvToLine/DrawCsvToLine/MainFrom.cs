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

namespace DrawCsvToLine
{
    public partial class MainFrom : Form
    {
        LineSeries<int> line1;
        LineSeries<int> line2;
        public MainFrom()
        {
            InitializeComponent();
        }

        private void MainFrom_Load(object sender, EventArgs e)
        {
            line1 = new LineSeries<int>
            {
                Values = new[] { 2, 5, 4, 2, 6, 2, 5, 4, 2, 6, 2, 5, 4, 2, 6, 2, 5, 4, 2, 6, 2, 5, 4, 2, 6, 2, 5, 4, 2, 6, 2, 5, 4, 2, 6 },//数据
                Name = "Income",//线的名字
                Stroke = new SolidColorPaint(SKColors.Blue) { StrokeThickness = 1 },//线的颜色与粗细
                GeometrySize = 5,//数据点的大小
                LineSmoothness = 1,//曲线曲率
                Fill = null
            };
            line2 = new LineSeries<int>
            {
                Values = new[] { 3, 7, 2, 9, 4, 3, 7, 2, 9, 4, 3, 7, 2, 9, 4, 3, 7, 2, 9, 4, 3, 7, 2, 9, 4, 3, 7, 2, 9, 4 },
                Name = "Outcome",
                Stroke = new SolidColorPaint(SKColors.Red) { StrokeThickness = 2 },
                GeometrySize = 5,
                LineSmoothness = 1,
                Fill = null
            };
            cartesianChart1.Series = new ISeries[]{line1, line2};
            
            cartesianChart1.DrawMarginFrame = new DrawMarginFrame
            {
                Fill = new SolidColorPaint(SKColors.AliceBlue),
                Stroke = new SolidColorPaint(SKColors.Black, 1)
            };
            cartesianChart1.ZoomMode = LiveChartsCore.Measure.ZoomAndPanMode.Both;
            //List<List<string>> data = CSVFiles.Read<List<string>>(@"C:\Users\automation.public\Desktop\111\data0.csv",isLine:true);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            line2.IsVisible = !line2.IsVisible;//显示or隐藏曲线
            //cartesianChart1.Series = new ISeries[] { line1, line2 };
            //Utils.Utils.saveChartToImg(cartesianChart1);//保存图片
        }
    }

    class Test
    {
        public string time { get; set; }
        public string lineData1 { get; set; }
        public string lineData2 { get; set; }
        //Parse方法会在自定义读写CSV文件时用到
        public static Test Parse(string[] fields)
        {
            try
            {
                //foreach (string field in fields)
                //{
                //    //
                //}
                Test ret = new Test();
                ret.time = fields[0];
                ret.lineData1 = fields[1];
                ret.lineData2 = fields[2];
                return ret;
            }
            catch (Exception)
            {
                //做一些异常处理，写日志之类的
                return null;
            }
        }
    }

}
