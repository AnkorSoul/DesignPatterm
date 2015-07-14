using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate
{
    public abstract class LogWrapper : Log
    {
        private Log _log;
        public LogWrapper(Log log)
        {
            _log = log;
        }
        public override void Write(string log)
        {
            _log.Write(log);
        }
    }

    public class LogErrorWrapper : LogWrapper
    {

        public LogErrorWrapper(Log _log)

            : base(_log)
        {



        }

        public override void Write(string log)
        {

            SetError(); //......功能扩展

            base.Write(log);

        }

        public void SetError()
        {

            //......实现了记录错误严重级别
            Console.WriteLine("Error");

        }
    }
    public class LogPriorityWrapper : LogWrapper
    {

        public LogPriorityWrapper(Log _log)

            : base(_log)
        {

        }

        public override void Write(string log)
        {

            SetPriority(); //......功能扩展

            base.Write(log);

        }

        public void SetPriority()
        {

            //......实现了记录优先级别
            Console.WriteLine("SetPriority");

        }
    }
}
