/*

 * 适用性

在以下情况下应当使用装饰模式：

1.需要扩展一个类的功能，或给一个类增加附加责任。 

2.需要动态地给一个对象增加功能，这些功能可以再动态地撤销。 

3.需要增加由一些基本功能的排列组合而产生的非常大量的功能，从而使继承关系变得不现实。

总结

Decorator模式采用对象组合而非继承的手法，实现了在运行时动态的扩展对象功能的能力，
 * 而且可以根据需要扩展多个功能，避免了单独使用继承带来的“灵活性差”和“多子类衍生问题”。
 * 同时它很好地符合面向对象设计原则中“优先使用对象组合而非继承”和“开放-封闭”原则。

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorate
{
    public class Program
    {

        public static void Main(string[] args)
        {

            Log log = new DatabaseLog();

            LogWrapper lew1 = new LogErrorWrapper(log);

            //扩展了记录错误严重级别

            lew1.Write("Log Message");

            LogPriorityWrapper lpw1 = new LogPriorityWrapper(log);

            //扩展了记录优先级别

            lpw1.Write("Log Message");

            LogWrapper lew2 = new LogErrorWrapper(log);

            LogPriorityWrapper lpw2 = new LogPriorityWrapper(lew2); //这里是lew2

            //同时扩展了错误严重级别和优先级别

            lpw2.Write("Log Message");

            Console.Read();

        }
    }
}
