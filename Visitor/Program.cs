using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Visitor.Component;

namespace Visitor
{
    class Program
    {
        static void Main(string[] args)
        {
            ObjectStructure os = new ObjectStructure();
            os.Add(new ConcreteElementA());
            os.Add(new ConcreteElementB());

            ConcreteVisitor1 cv1 = new ConcreteVisitor1();
            ConcreteVisitor2 cv2 = new ConcreteVisitor2();
            os.Accept(cv1);
            os.Accept(cv2);

            Console.Read();
        }
    }
}
