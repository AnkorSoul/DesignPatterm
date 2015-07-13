/*
 
 　 1）首先，该CommonSingle的构造函数必须是私有的，以保证客户程序不会通过new（）操作产生一个实例，达到实现单例的目的；
 
　　2）因为静态变量的生命周期跟整个应用程序的生命周期是一样的，所以可以定义一个私有的静态全局变量instance来保存该类的唯一实例；
 *
　　3）必须提供一个全局函数访问获得该实例，并且在该函数提供控制实例数量的功能，即通过if语句判断instance是否已被实例化，如果没有则可以同new（）创建一个实例；
 *     否则，直接向客户返回一个实例。在这种经典模式下，没有考虑线程并发获取实例问题，
 *     即可能出现两个线程同时获取instance实例，且此时其为null时，就会出现两个线程分别创建了instance，违反了单例规则。因此，需对上面代码修改。
 
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4_Singleton.Component
{
    public class CommonSingle
    {
        private static CommonSingle instance;
        private CommonSingle()
        {

        }

        public static CommonSingle GetInstance()
        {
            if (instance == null)
            {
                Thread.Sleep(1000);
                instance = new CommonSingle();
            }

            return instance;
        }
    }
}
