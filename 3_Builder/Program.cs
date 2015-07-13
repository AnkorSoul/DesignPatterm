/*
 
 4个角色：指挥者(Director)，建造者(Builder)，具体建造者(ConcreteBuilder)，产品(Product)
         产品：需要创建的对象产品
         具体建造者：创建产品的实例并且实现建造者多个方法对产品进行装配
         建造者：本质为抽象类，里面的抽象方法供具体建造者重写，声明产品的引用
         指挥者：调用建造者抽象类以及其方法

 实现思路：客户端创建一个指挥者，并且实例化需要的产品的具体建造者，然后指挥者调用具体建造者的实例即将产品生产出来。
 
 分析优化：1、如果统一品牌下有多种型号的电脑如何处理？通过构造函数初始化
           2、该模式适用于共性相同，只是具体细节不同的实例创建，规划出一个统一的创建入口，便于创建维护。
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _3_Builder.Component;
using System.Reflection;
namespace _3_Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            CreateDirector createDirector = new CreateDirector();
            
            Computer computer = createDirector.CreateComputer(new AppleConcreteBuilder());

            foreach (PropertyInfo p in computer.GetType().GetProperties())
            {
                Console.WriteLine("Name:{0} Value:{1}", p.Name, p.GetValue(computer));
            }

            Console.Read();
        }
    }
}
