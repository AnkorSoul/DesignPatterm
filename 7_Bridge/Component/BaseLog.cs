using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _7_Bridge.Component
{
    public abstract class BaseLog
    {
        public abstract void Execute(string msg);
    }

    public class NImpLog : BaseLog
    {
        public override void Execute(string msg)
        {
            throw new NotImplementedException();
        }
    }
    public class JImpLog : BaseLog
    {
        public override void Execute(string msg)
        {
            throw new NotImplementedException();
        }
    }
}
