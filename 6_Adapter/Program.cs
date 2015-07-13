/* 概述：
 * 在软件系统中，由于应用环境的变化，常常需要将“一些现存的对象”放在新的环境中应用，
 * 但是新环境要求的接口是这些现存对象所不满足的。
 * 那么如何应对这种“迁移的变化”？如何既能利用现有对象的良好实现，同时又能满足新的应用环境所要求的接口？
 * 这就是要说的Adapter 模式。 
 * 
 * 意图：
 * 将一个类的接口转换成客户希望的另外一个接口。
 * Adapter模式使得原本由于接口不兼容而不能一起工作的那些类可以一起工作。
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _6_Adapter.Component;
using _6_Adapter.Component.LogTools;

namespace _6_Adapter
{
    class Program
    {
        static void Main(string[] args)
        {
            /** 类适配器使用继承来实现不同的功能，增加了类的数量 **/

            //适配器类DatabaseLogAdapter和FileLogAdapter具有它所继承的父类的所有的行为，
            //同时也具有接口ILogTarget的所有行为，这样其实是违背了面向对象设计原则中的类的 单一职责 原则

            ILogTarget dbLog = new DatabaseLogAdapter();
            dbLog.Write("Logging Databaes...");

            ILogTarget fileLog = new FileLogAdapter();
            fileLog.Write("Logging File...");

            Console.WriteLine("\n对象适配器\n");

            /** 
             * 对象适配器 与类适配器相比较，可以看到最大的区别是适配器类的数量减少了，
             * 不再需要为每一种具体的日志记录方式来创建一个适配器类。
             * 同时可以看到，引入对象适配器后，适配器类不再依赖于具体的DatabaseLog类和FileLog类，更好的实现了松耦合。
             **/
            dbLog = new LogAdapter(new DatabaseLog());
            dbLog.Write("Logging Databaes...");

            fileLog = new LogAdapter(new FileLog());
            fileLog.Write("Logging File...");
            
            Console.Read();
        }
    }
}



/*******************************************************/
/*后记
 假设我们要适配出来的类在记录日志时同时写入文件和数据库，那么用对象适配器我们会这样去写：
 * public class LogAdapter : ILogTarget
    {
        private LogAdaptee _adaptee1;
        private LogAdaptee _adaptee2;
        public LogAdapter(LogAdaptee adaptee1,LogAdaptee adaptee2)
        {
            _adaptee1 = adaptee1;
            _adaptee2 = adaptee2;
        }
        public void Write(string logRecord)
        {
            _adaptee1.WriteLog(logRecord);
            _adaptee2.WriteLog(logRecord);
        }
    }
 * 类适配器，就不能简单的通过继承实现。
 * 
 * 
 * 
 * 
  实现要点

1．Adapter模式主要应用于“希望复用一些现存的类，但是接口又与复用环境要求不一致的情况”，在遗留代码复用、类库迁移等方面非常有用。

2．Adapter模式有对象适配器和类适配器两种形式的实现结构，但是类适配器采用“多继承”的实现方式，带来了不良的高耦合，所以一般不推荐使用。对象适配器采用“对象组合”的方式，更符合松耦合精神。

3．Adapter模式的实现可以非常的灵活，不必拘泥于GOF23中定义的两种结构。例如，完全可以将Adapter模式中的“现存对象”作为新的接口方法参数，来达到适配的目的。

4．Adapter模式本身要求我们尽可能地使用“面向接口的编程”风格，这样才能在后期很方便的适配。[以上几点引用自MSDN WebCast]

效果

对于类适配器：

1．用一个具体的Adapter类对Adaptee和Taget进行匹配。结果是当我们想要匹配一个类以及所有它的子类时，类Adapter将不能胜任工作。

2．使得Adapter可以重定义Adaptee的部分行为，因为Adapter是Adaptee的一个子类。

3．仅仅引入了一个对象，并不需要额外的指针一间接得到Adaptee.

对于对象适配器：

1．允许一个Adapter与多个Adaptee，即Adaptee本身以及它的所有子类（如果有子类的话）同时工作。Adapter也可以一次给所有的Adaptee添加功能。

2．使得重定义Adaptee的行为比较困难。这就需要生成Adaptee的子类并且使得Adapter引用这个子类而不是引用Adaptee本身。

适用性

在以下各种情况下使用适配器模式：

1．系统需要使用现有的类，而此类的接口不符合系统的需要。

2．想要建立一个可以重复使用的类，用于与一些彼此之间没有太大关联的一些类，包括一些可能在将来引进的类一起工作。这些源类不一定有很复杂的接口。

3．（对对象适配器而言）在设计里，需要改变多个已有子类的接口，如果使用类的适配器模式，就要针对每一个子类做一个适配器，而这不太实际。

 */