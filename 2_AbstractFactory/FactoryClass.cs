using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_AbstractFactory
{
    public class FactoryClass
    {
        /*其实工厂和抽象工厂没有多大区别，只不过是抽象工厂生产的商品是多个而已

         * 通俗的说，就是抽象工厂模式的具体工厂里面会有多个实例具体对象的方法

         * 更直观的就是，抽象工厂模式每个工厂一次造多个玩意,而工厂模式的每个工厂只造一个玩意
         
         */
        public abstract class Product
        {
            public abstract void work();
        }
        public class ProductA : Product
        {
            public override void work()
            {
                Console.Write("ProductA");
            }
        }
        public class ProductB : Product
        {
            public override void work()
            {
                Console.Write("ProductB");
            }
        }
        public abstract class Car
        {
            public abstract void Build();
        }
        public class CarA : Car
        {
            public override void Build()
            {
                Console.Write("Build CarA");
            }
        }
        public class CarB : Car
        {
            public override void Build()
            {
                Console.Write("Build CarB");
            }
        }
        public abstract class AbstractFactory
        {
            //工厂生产多个对象
            public abstract Product newproduct();
            public abstract Car newCar();
        }
        public class AbstractFactoryA : AbstractFactory
        {
            public override Product newproduct()
            {
                return new ProductA();//子类里面实现具体的实例化
            }
            public override Car newCar()
            {
                return new CarA();
            }
        }
        public class AbstractFactoryB : AbstractFactory
        {
            public override Product newproduct()
            {
                return new ProductB();//子类里面实现具体的实例化
            }
            public override Car newCar()
            {
                return new CarB();
            }
        }

        public class AbstractFactoryClient
        {
            public static void GetFactoryMethod()
            {
                AbstractFactory factorysubA = new AbstractFactoryA();
                AbstractFactory factorysubB = new AbstractFactoryB();

                Product pruductA = factorysubA.newproduct();
                Product pruductB = factorysubB.newproduct();
                Car factorycarA = factorysubA.newCar();

                factorycarA.Build();

                pruductA.work();
                pruductB.work();
            }
        }
    }
}
