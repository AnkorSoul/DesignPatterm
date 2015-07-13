using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Bridge.Component
{
    public abstract class ActionLog
    {
        protected BaseLog implementor;
        public BaseLog Implementor
        {
            set { implementor = value; }
        }

        public virtual void Write(string log)
        {
            implementor.Execute(log);
        }
    }

    public class DatabaseLog : ActionLog
    {
        public override void Write(string log)
        {
            implementor.Execute(log);
        }
    }
    public class TextFileLog : ActionLog
    {
        public override void Write(string log)
        {
            base.Write(log);
        }
    }

}
