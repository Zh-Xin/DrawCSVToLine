using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LiveChartsCore.SkiaSharpView.WinForms;
using System.IO;
using System.Diagnostics;

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
        public static void selectFolder()
        {
            System.Windows.Forms.OpenFileDialog folderBrowser = new System.Windows.Forms.OpenFileDialog();
            // Set validate names and check file exists to false otherwise windows will
            // not let you select "Folder Selection."
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            // Always default to Folder Selection.
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                // ...
                Console.WriteLine(folderPath);
            }
        }
        public static string selectFolder2()
        {
            System.Windows.Forms.FolderBrowserDialog dialog = new System.Windows.Forms.FolderBrowserDialog();
            dialog.Description = "please select the folder path";
            if (dialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string foldPath = dialog.SelectedPath;
                Console.WriteLine(foldPath);
                return foldPath;
            }
            else
            {
                return null;
            }
        }
        public static void selectFile()
        {
            System.Windows.Forms.OpenFileDialog fileDialog = new System.Windows.Forms.OpenFileDialog();//打开文件对话框 
            fileDialog.InitialDirectory = System.AppDomain.CurrentDomain.BaseDirectory;//初始化路径
            fileDialog.Filter = "图片(*.*)|*.*";//或"图片(*.jpg;*.bmp)|*.jpg;*.bmp";//过滤选项设置，文本文件，所有文件。
            fileDialog.FilterIndex = 0;//当前使用第二个过滤字符串
            fileDialog.RestoreDirectory = true;//对话框关闭时恢复原目录
            fileDialog.Title = "选择图片";
            if (fileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                string filePath = fileDialog.FileName;
                Console.WriteLine(filePath);
            }
        }
        // 遍历所有文件夹下的文件名字
        public static string[] addFileSystemEntries(string path)
        {

            // Obtain the file system entries in the directory path.
            string[] directoryEntries = System.IO.Directory.GetFileSystemEntries(path, "*.*");
            Array.Sort(directoryEntries);
            //for (int i = 0; i < directoryEntries.Length; i++)
            //{
                //Debug.Log(i + "  " + directoryEntries[i]);
            //}
            return directoryEntries;

        }
    }
}
