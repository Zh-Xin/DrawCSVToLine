using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.WinForms;

namespace DrawCsvToLine.Utils
{
    internal class Utils
    {
        public static void saveChartToImg(CartesianChart chart)
        {
            Bitmap bit = new Bitmap(chart.Width, chart.Height);//实例化一个和窗体一样大的bitmap
            Graphics g = Graphics.FromImage(bit);
            g.CompositingQuality = CompositingQuality.HighQuality;//质量设为最高
            g.CopyFromScreen(chart.Left, chart.Top, 0, 0, new Size(chart.Width, chart.Height));//保存整个窗体为图片
            g.CopyFromScreen(chart.PointToScreen(Point.Empty), Point.Empty, chart.Size);//只保存某个控件（这里是panel游戏区）
            bit.Save(@"C:\Users\automation.public\Desktop\weiboTemp.png");//默认保存格式为PNG，保存成jpg格式质量不是很好
        }
    }
}
