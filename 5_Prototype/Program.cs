
/*
 
 * 1．为什么需要Prototype模式？

      引入原型模式的本质在于利用已有的一个原型对象，快速的生成和原型对象一样的实例。
 *    你有一个A的实例a:A a = new A();现在你想生成和car1一样的一个实例b，按照原型模式，应该是这样：A b = a.Clone();
 *    而不是重新再new一个A对象。通过上面这句话就可以得到一个和a一样的实例，确切的说，应该是它们的数据成员是一样的。
 *    Prototype模式同样是返回了一个A对象而没有使用new操作。

    2．引入Prototype模式带来了什么好处？

     可以看到，引入Prototype模式后我们不再需要一个与具体产品等级结构平行的工厂方法类，减少了类的构造，
 *   同时客户程序可以在运行时刻建立和删除原型。

    3．Prototype模式满足了哪些面向对象的设计原则？

     依赖倒置原则：上面的例子，原型管理器（ColorManager）仅仅依赖于抽象部分（ColorPrototype），
 *   而具体实现细节（ConcteteColorPrototype）则依赖与抽象部分（ColorPrototype），所以Prototype很好的满足了依赖倒置原则。

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _5_Prototype.Component;
namespace _5_Prototype
{
    class Program
    {


        public static void Main(string[] args)
        {

            ColorManage colormanager = new ColorManage();

            //初始化颜色

            ConcteteColorPrototype red = new ConcteteColorPrototype(255, 0, 0);
            colormanager["red"] = red;

            colormanager["green"] = new ConcteteColorPrototype(0, 255, 0);

            colormanager["blue"] = new ConcteteColorPrototype(0, 0, 255);

            colormanager["angry"] = new ConcteteColorPrototype(255, 54, 0);

            colormanager["peace"] = new ConcteteColorPrototype(128, 211, 128);

            colormanager["flame"] = new ConcteteColorPrototype(211, 34, 20);

            //使用颜色

            string colorName = "red";

            ConcteteColorPrototype c1 = (ConcteteColorPrototype)colormanager[colorName].Clone();

            c1.Display(colorName);
            colorName = "peace";

            ConcteteColorPrototype c2 = (ConcteteColorPrototype)colormanager[colorName].Clone();

            c2.Display(colorName);

            colorName = "flame";

            ConcteteColorPrototype c3 = (ConcteteColorPrototype)colormanager[colorName].Clone();

            c3.Display(colorName);

            Console.ReadLine();


        }
    }
}


/*
 
* 实现要点

    1．使用原型管理器，体现在一个系统中原型数目不固定时，可以动态的创建和销毁，如上面的举的调色板的例子。

    2．实现克隆操作，在.NET中可以使用Object类的MemberwiseClone()方法来实现对象的浅表拷贝(创建新的实例指向原来实例的指向地址)或通过序列化的方式来实现深拷贝。

    3．Prototype模式同样用于隔离类对象的使用者和具体类型（易变类）之间的耦合关系，它同样要求这些“易变类”拥有稳定的接口。 

效果

    1．它对客户隐藏了具体的产品类，因此减少了客户知道的名字的数目。

    2．Prototype模式允许客户只通过注册原型实例就可以将一个具体产品类并入到系统中，客户可以在运行时刻建立和删除原型。

    3．减少了子类构造，Prototype模式是克隆一个原型而不是请求工厂方法创建一个，所以它不需要一个与具体产品类平行的Creater类层次。

    4．Portotype模式具有给一个应用软件动态加载新功能的能力。由于Prototype的独立性较高，可以很容易动态加载新功能而不影响老系统。

    5．产品类不需要非得有任何事先确定的等级结构，因为Prototype模式适用于任何的等级结构

    6．Prototype模式的最主要缺点就是每一个类必须配备一个克隆方法。而且这个克隆方法需要对类的功能进行通盘考虑，这对全新的类来说不是很难，
   但对已有的类进行改造时，不一定是件容易的事。

适用性

    在下列情况下，应当使用Prototype模式：

    1．当一个系统应该独立于它的产品创建，构成和表示时；

    2．当要实例化的类是在运行时刻指定时，例如，通过动态装载；

    3．为了避免创建一个与产品类层次平行的工厂类层次时；

    4．当一个类的实例只能有几个不同状态组合中的一种时。建立相应数目的原型并克隆它们可能比每次用合适的状态手工实例化该类更方便一些。

总结

   Prototype模式同工厂模式，同样对客户隐藏了对象的创建工作，但是，与通过对一个类进行实例化来构造新对象不同的是，
 * 原型模式是通过拷贝一个现有对象生成新对象的，达到了“隔离类对象的使用者和具体类型（易变类）之间的耦合关系”的目的。

 
 */