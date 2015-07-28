using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Visitor.Component
{
    public class ObjectStructure
    {
        IList<Element> elements = new List<Element>();

        public void Add(Element e)
        {
            elements.Add(e);
        }

        public void Remove(Element e)
        {
            elements.Remove(e);
        }

        public void Accept(Visitor visitor)
        {
            foreach (Element e in elements)
            {
                e.Accept(visitor);
            }
        }
    }
}
