using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tianxy.Tool.Log4net
{
    //==============================================================
    //  作者：tianxy
    //  时间：2018/8/3 17:39:36
    //  文件名：LogHelper
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public class LogHelper
    {
        static LogHelper()
        {
            //获取日志配置文件
            FileInfo log4netFile = new FileInfo(string.Format("{0}appConfigs\\log4net.config", AppDomain.CurrentDomain.BaseDirectory));
            log4net.Config.XmlConfigurator.Configure(log4netFile);
        }

        #region 调试日志
        /// <summary>
        /// 记录调试信息
        /// </summary>
        /// <param name="loggerType">日志记录分类枚举</param>
        /// <param name="LogStr">日志</param>
        public static void Debug(string LogStr)
        {
            LoggerType loggerType = LoggerType.Debug;
            log4net.ILog log = log4net.LogManager.GetLogger(loggerType.ToString());
            if (log.IsDebugEnabled)
            {
                log.Debug(LogStr);
            }
        }
        /// <summary>
        /// 记录调试信息
        /// </summary>
        /// <param name="loggerType">日志记录分类枚举</param>
        /// <param name="LogStr">日志</param>
        /// <param name="ex">异常信息</param>
        public static void Debug(string LogStr, Exception ex)
        {
            LoggerType loggerType = LoggerType.Debug;
            log4net.ILog log = log4net.LogManager.GetLogger(loggerType.ToString());
            if (log.IsDebugEnabled)
            {
                log.Debug(LogStr, ex);
            }

        }
        #endregion

        #region 接口日志

        /// <summary>
        /// 接口日志
        /// </summary>
        /// <param name="LogStr"></param>
        public static void WebServiceLog(string LogStr)
        {
            LoggerType loggerType = LoggerType.WebServiceLog;
            log4net.ILog log = log4net.LogManager.GetLogger(loggerType.ToString());
            if (log.IsDebugEnabled)
            {
                log.Debug(LogStr);
            }
        }

        /// <summary>
        /// 接口日志
        /// </summary>
        /// <param name="LogStr"></param>
        public static void WebServiceLog(string LogStr, Exception ex)
        {
            LoggerType loggerType = LoggerType.WebServiceLog;
            log4net.ILog log = log4net.LogManager.GetLogger(loggerType.ToString());
            if (log.IsDebugEnabled)
            {
                log.Info(LogStr, ex);
            }
        }

        #endregion 

        #region  数据操作日志
        /// <summary>
        ///  数据操作日志
        /// </summary>
        /// <param name="LogStr"></param>
        public static void DataLog(string LogStr)
        {
            LoggerType loggerType = LoggerType.DataBaseLog;
            log4net.ILog log = log4net.LogManager.GetLogger(loggerType.ToString());
            if (log.IsDebugEnabled)
            {
                log.Info(LogStr);
            }
        }

        /// <summary>
        ///  数据操作日志
        /// </summary>
        /// <param name="LogStr"></param>
        public static void DataLog(string LogStr, Exception ex)
        {
            LoggerType loggerType = LoggerType.DataBaseLog;
            log4net.ILog log = log4net.LogManager.GetLogger(loggerType.ToString());
            if (log.IsDebugEnabled)
            {
                log.Info(LogStr, ex);
            }
        }
        #endregion

        #region 一般日志

        /// <summary>
        ///  一般日志
        /// </summary>
        /// <param name="LogStr"></param>
        public static void InfoLog(string LogStr)
        {
            LoggerType loggerType = LoggerType.Info;
            log4net.ILog log = log4net.LogManager.GetLogger(loggerType.ToString());
            if (log.IsDebugEnabled)
            {
                log.Info(LogStr);
            }
        }

        /// <summary>
        ///  一般日志
        /// </summary>
        /// <param name="LogStr"></param>
        public static void InfoLog(string LogStr, Exception ex)
        {
            LoggerType loggerType = LoggerType.Info;
            log4net.ILog log = log4net.LogManager.GetLogger(loggerType.ToString());
            if (log.IsDebugEnabled)
            {
                log.Info(LogStr, ex);
            }
        }
        #endregion

        #region 一般错误日志
        /// <summary>
        ///  一般错误日志
        /// </summary>
        /// <param name="LogStr"></param>
        public static void ErrorLog(string LogStr)
        {
            LoggerType loggerType = LoggerType.Error;
            log4net.ILog log = log4net.LogManager.GetLogger(loggerType.ToString());
            if (log.IsDebugEnabled)
            {
                log.Error(LogStr);
            }
        }

        /// <summary>
        ///  一般错误日志
        /// </summary>
        /// <param name="LogStr"></param>
        public static void ErrorLog(string LogStr, Exception ex)
        {
            LoggerType loggerType = LoggerType.Error;
            log4net.ILog log = log4net.LogManager.GetLogger(loggerType.ToString());
            if (log.IsDebugEnabled)
            {
                log.Error(LogStr, ex);
            }
        }
        #endregion

        #region 日志通用
        /// <summary>
        ///  一般错误日志
        /// </summary>
        /// <param name="LogStr"></param>
        public static void Log(LoggerType logtype, string LogStr)
        {
            LoggerType loggerType = logtype;
            log4net.ILog log = log4net.LogManager.GetLogger(loggerType.ToString());
            if (log.IsDebugEnabled)
            {
                log.Debug(LogStr);
            }
        }

        /// <summary>
        ///  一般错误日志
        /// </summary>
        /// <param name="LogStr"></param>
        public static void Log(LoggerType logtype, string LogStr, Exception ex)
        {
            LoggerType loggerType = logtype;
            log4net.ILog log = log4net.LogManager.GetLogger(loggerType.ToString());
            if (log.IsDebugEnabled)
            {
                log.Debug(LogStr, ex);
            }
        }
        #endregion


    }
}
