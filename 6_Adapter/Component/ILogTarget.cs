/*
 *
 *日志接口
 * 
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Adapter.Component
{
    public interface ILogTarget
    {
        void Write(string LogRecord);
    }
}
