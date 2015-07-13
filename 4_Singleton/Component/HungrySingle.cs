/*
 
 * 使用的readonly关键可以跟static一起使用，用于指定该常量是类别级的，它的初始化交由静态构造函数实现，并可以在运行时编译。
 * 在这种模式下，无需自己解决线程安全性问题，CLR会给我们解决。由此可以看到这个类被加载时，会自动实例化这个类，
 * 而不用在第一次调用GetInstance()后才实例化出唯一的单例对象。 

 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _4_Singleton.Component
{
    public class HungrySingle
    {

        private static readonly HungrySingle instance = new HungrySingle();

        private HungrySingle()
        {
        }

        public static HungrySingle GetInstance()
        {
            return instance;
        }

    }
}
