
/*
 
 * 上述代码使用了双重锁方式较好地解决了多线程下的单例模式实现。先看内层的if语句块，使用这个语句块时，先进行加锁操作，
 * 保证只有一个线程可以访问该语句块，进而保证只创建了一个实例。再看外层的if语句块，这使得每个线程欲获取实例时不必每次都得加锁，
 * 因为只有实例为空时（即需要创建一个实例），才需加锁创建，若果已存在一个实例，就直接返回该实例，节省了性能开销。
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace _4_Singleton.Component
{
    public class LazySingle
    {

        private static LazySingle instance;
        private static object _lock = new object();

        private LazySingle()
        {

        }

        public static LazySingle GetInstance()
        {
            if (instance == null)
            {
                Thread.Sleep(1000);
                lock (_lock)
                {
                    if (instance == null)
                    {
                        instance = new LazySingle();
                    }
                }
            }
            return instance;
        }
    }

}
