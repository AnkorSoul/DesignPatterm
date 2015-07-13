using System;
/*
 
 * 我们为每一种日志记录方式都编写了它的适配类，那为什么不能为抽象类LogAdaptee来编写一个适配类呢？
 * 因为DatabaseLog和FileLog虽然同时继承于抽象类LogAdaptee，
 * 但是它们具体的WriteLog()方法的实现是不同的。只有继承于该具体类，才能保留其原有的行为。
 
 */
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _6_Adapter.Component
{
   public class DatabaseLogAdapter:LogTools.DatabaseLog,ILogTarget
    {
       public void Write(string logRecord)
       {
           WriteLog(logRecord);
       }
    }
}
