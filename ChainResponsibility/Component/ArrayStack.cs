using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibility.Component
{

    /**/
    /// <summary>
    /// Stact采用ArrayList模拟堆栈
    /// </summary>
    class AStack
    {
        private ArrayList myStact;
        public int Count
        {
            get { return myStact.Count; }
        }
        public AStack()
        {
            myStact = new ArrayList();
        }
        public void Push(Object o)
        {
            myStact.Add(o);
        }
        public Object Pop()
        {
            int idx = myStact.Count - 1;
            if (idx < 0)
            {
                throw new Exception("堆栈已空");
            }
            object o = myStact[idx];
            myStact.RemoveAt(idx);
            return o;
        }
        public Object Pop2()
        {
            if (myStact.Count == 0)
            {
                throw new Exception("堆栈已空");
            }
            object o = myStact[0];
            myStact.RemoveAt(0);
            return o;
        }
        public bool IsEmpty()
        {
            return (myStact.Count == 0);
        }
        public object TopItem()
        {
            int idx = myStact.Count - 1;
            if (idx < 0)
            {
                throw new Exception("堆栈已空");
            }
            object o = myStact[idx];
            return o;
        }

    }
}
