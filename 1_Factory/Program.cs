using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_Factory
{
    class Program
    {
        static void Main(string[] args)
        {

            Func<int, Func<int, int>, int> sFunc = null;
            sFunc = (x, y) =>
            {
                return x == 1 ? y(1) : sFunc(x - 1, a => y(x * a));
            };
            int result = sFunc(4, x => x);
            Console.Write(result);

            FactoryMethodClient.GetFactoryMethod();
            
            Console.Read();
        }
    }
}
