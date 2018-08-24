using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tianxy.Tool.Log4net
{
    //==============================================================
    //  作者：tianxy
    //  时间：2018/8/3 17:41:12
    //  文件名：LoggerType
    //  版本：V1.0.1  
    //  说明： 
    //  修改者：tianxy
    //  修改说明： 
    //==============================================================
    public enum LoggerType
    {
        /// <summary>
        /// 接口日志 主要记录接口数据等信息
        /// </summary>
        WebServiceLog,
        /// <summary>
        /// 数据日志  主要记录数据库操作信息
        /// </summary>
        DataBaseLog,
        /// <summary>
        /// 后台日志 主要记录登录、后台按钮的点击事件。例如部署或者发布流程，修改结点
        /// </summary>
        Debug,
        /// <summary>
        /// 一般错误日志
        /// </summary>
        Error,
        /// <summary>
        /// 一般日志
        /// </summary>
        Info,
    }
}
