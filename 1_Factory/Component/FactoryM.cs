using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Factory
{
    public abstract class Product
    {
        public abstract void Work();
    }

    public class ProductA : Product
    {

        public override void Work()
        {

            Console.Write("ProductA");

        }

    }
    public class ProductB : Product
    {

        public override void Work()
        {

            Console.Write("ProductB");

        }

    }

    public abstract class FactoryMethods
    {

        public abstract Product NewProduct();

    }

    //对不同产品的实例化，由不同的工厂来具体实现,每一个工厂生产具体的商品

    public class FactoryMethodA : FactoryMethods//具体工厂
    {

        public override Product NewProduct()
        {

            return new ProductA();//实现具体的实例化

        }

    }

    public class FactoryMethodB : FactoryMethods//具体工厂
    {

        public override Product NewProduct()
        {

            return new ProductB();//实现具体的实例化

        }

    }

    public class FactoryMethodClient
    {

        public static void GetFactoryMethod()
        {

            //产品种类是变化的，如果发生变化，新增一个工厂就可以了,在调用的地方掉用新的方法

            //体现出对修改封闭，对扩展开放，新增新的功能对原来的没有影响

            FactoryMethods factorysubA = new FactoryMethodA();

            FactoryMethods factorysubB = new FactoryMethodB();

            Product pruductA = factorysubA.NewProduct();

            Product pruductB = factorysubB.NewProduct();

            pruductA.Work();

            pruductB.Work();

        }

    }
}
