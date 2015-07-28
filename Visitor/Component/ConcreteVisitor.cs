using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Component
{
    public class ConcreteVisitor1 : Visitor
    {

        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0}访问{1}", this.GetType().Name, concreteElementA.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0}访问{1}", this.GetType().Name, concreteElementB.GetType().Name);
        }
    }

    public class ConcreteVisitor2 : Visitor
    {

        public override void VisitConcreteElementA(ConcreteElementA concreteElementA)
        {
            Console.WriteLine("{0}访问{1}", this.GetType().Name, concreteElementA.GetType().Name);
        }

        public override void VisitConcreteElementB(ConcreteElementB concreteElementB)
        {
            Console.WriteLine("{0}访问{1}", this.GetType().Name, concreteElementB.GetType().Name);
        }
    }
}
