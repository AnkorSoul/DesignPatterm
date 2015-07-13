/**
 * 
 *对象适配器通过组装不同的对象，来达到我们的需求
 * 
 **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _6_Adapter.Component.LogTools;

namespace _6_Adapter.Component
{
    public class LogAdapter : ILogTarget
    {
        private LogAdaptee _adaptee;
        public LogAdapter(LogAdaptee adaptee)
        {
            _adaptee = adaptee;
        }
        public void Write(string logRecord)
        {
            _adaptee.WriteLog(logRecord);
        }
    }
}
