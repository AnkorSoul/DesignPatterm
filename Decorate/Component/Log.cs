using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate
{
    public abstract class Log
    {
        public abstract void Write(string log);
    }
    public class DatabaseLog : Log
    {
        public override void Write(string log)
        {
            Console.WriteLine(log);

        }
    }
}
