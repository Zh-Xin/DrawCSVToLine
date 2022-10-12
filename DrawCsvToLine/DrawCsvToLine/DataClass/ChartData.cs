using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DrawCsvToLine.DataClass
{
    public class ChartData
    {
        public string time { get; set; }
        public string lineData1 { get; set; }
        public string lineData2 { get; set; }
        //Parse方法会在自定义读写CSV文件时用到
        public static ChartData Parse(string[] fields)
        {
            try
            {
                //foreach (string field in fields)
                //{
                //    //
                //}
                ChartData ret = new ChartData();
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
