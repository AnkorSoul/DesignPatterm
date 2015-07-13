/*
 * 
 * 记录日志工具类
 * 
 *
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Adapter.Component.LogTools
{

    public abstract class LogAdaptee
    {
        public abstract void WriteLog(string logRecord);
    }
    public class DatabaseLog : LogAdaptee
    {
        public override void WriteLog(string logRecord)
        {
            Console.WriteLine("Called WriteDatabaseLog Method::" + logRecord);
            //throw new NotImplementedException();
        }
    }
    public class FileLog : LogAdaptee
    {
        public override void WriteLog(string logRecord)
        {
            Console.WriteLine("Called WriteFileLog Method::" + logRecord);
            //throw new NotImplementedException();
        }
    }
}
