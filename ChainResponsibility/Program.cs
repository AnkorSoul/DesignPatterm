using ChainResponsibility.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            //得到后则表达式

            string s = "( 2 + 3 ) / 3";

            Parser p = new Parser();

            Console.WriteLine(s);

            Console.WriteLine(p.Do(s));
            AStack asEnd = p.ReturnAStack(s);
            Parser px = new Parser();

            //计算后则表达式

            Computer c = new Computer(px.ReturnAStack(s));

            Console.WriteLine(c.Do());

            Console.ReadLine();
        }
    }
}
