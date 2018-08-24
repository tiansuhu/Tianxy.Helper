using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tianxy.Tool.Log4net;

namespace Tianxy.Test
{
    class Program
    {
        public static  Program _program = new Program();

        static void Main(string[] args)
        {
            _program.testlog4net();
        }

        #region 测试log4net
        /// <summary>
        /// 测试log4net 
        /// </summary>
        private void testlog4net()
        {
            Console.Read();
            Exception ex = new Exception("ex 错误信息");
            LogHelper.Debug("Debug");
            LogHelper.Debug("Debug",ex);

            LogHelper.DataLog("DataLog");
            LogHelper.DataLog("DataLog", ex);

            LogHelper.ErrorLog("ErrorLog");
            LogHelper.ErrorLog("ErrorLog", ex);

            LogHelper.InfoLog("InfoLog");
            LogHelper.InfoLog("InfoLog", ex);

            LogHelper.WebServiceLog("WebServiceLog");
            LogHelper.WebServiceLog("WebServiceLog", ex);

            LogHelper.Log(LoggerType.Info, "Log");
            LogHelper.Log(LoggerType.Info, "Log", ex);


        }
        #endregion

    }
}
