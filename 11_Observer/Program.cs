using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11_Observer
{

  class Program
    {
        //观察者模式 [əb'zə:və, ɔb-] 
        static void Main(string[] args)
        {
            ConcreteSubject s = new ConcreteSubject();
            s.Attach(new ConcreteObserver(s, "a"));
            s.Attach(new ConcreteObserver(s, "b"));
            s.Attach(new ConcreteObserver(s, "c"));

            s.SubjectState = "run";
            s.Notify();
            Console.Read();
        }
        //抽象观察者
        abstract class Observer
        {
            public abstract void Update();
        }

        //抽象通知者
        abstract class Subject
        {
            IList<Observer> listObserver = new List<Observer>();

            public void Attach(Observer observer)
            {
                listObserver.Add(observer);
            }

            public void Detach(Observer observer)
            {
                listObserver.Remove(observer);
            }

            public void Notify()
            {
                foreach (Observer o in listObserver)
                {
                    o.Update();
                }
            }
        }
        //具体通知者
        class ConcreteSubject : Subject
        {
            public string SubjectState { get; set; }
        }

        //具体观察者
        class ConcreteObserver : Observer
        {
            private string name;
            private string observerState;
            private ConcreteSubject subject;
            public ConcreteSubject Subject
            {
                get{return subject;}
                set{subject=value;}
            }
            public ConcreteObserver(ConcreteSubject subject, string name)
            {
                this.subject = subject;
                this.name = name;
            }

            public override void Update()
            {
                observerState = subject.SubjectState;
                Console.Write("observer {0} is state {1} \n ", name, observerState);
            }

        }
    }
}
