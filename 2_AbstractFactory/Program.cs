/*
 
 应用场景：封装变化点。创建一系列相互依赖的对象。
 
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_AbstractFactory
{
    class Program
    {

        static void Main(string[] args)
        {

            FactoryClass.AbstractFactoryClient.GetFactoryMethod();

            Console.Read();
        }
    }
}
