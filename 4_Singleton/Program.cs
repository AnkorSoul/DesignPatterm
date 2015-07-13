using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _4_Singleton.Component;

namespace _4_Singleton
{
    class Program
    {
        delegate CommonSingle FuncHandle();
        delegate LazySingle LazyHandle();
        static void Main(string[] args)
        {
            //CommonSingle commonSingle = CommonSingle.GetInstance();
            //Console.WriteLine(commonSingle.GetHashCode());

            FuncHandle fh = new FuncHandle(CommonSingle.GetInstance);
            FuncHandle fh1 = new FuncHandle(CommonSingle.GetInstance);
            AsyncCallback ac = new AsyncCallback(AsyncCallbackImpl);

            IAsyncResult result = fh.BeginInvoke(null, fh);
            IAsyncResult result1 = fh1.BeginInvoke(null, fh1);

            CommonSingle re = fh.EndInvoke(result);
            CommonSingle re1 = fh1.EndInvoke(result1);
            Console.WriteLine("----------------");
            Console.WriteLine(re.GetHashCode());
            Console.WriteLine(re1.GetHashCode());
            Console.WriteLine(re.Equals(re1));
       


            /* Lazy       */
            LazyHandle lazyHandler= new LazyHandle(LazySingle.GetInstance);
            LazyHandle lazyHandler1 = new LazyHandle(LazySingle.GetInstance);
            IAsyncResult lazyResult = lazyHandler.BeginInvoke(null, lazyHandler);
            IAsyncResult lazyResult1 = lazyHandler1.BeginInvoke(null, lazyHandler1);
            Console.WriteLine(((LazySingle)lazyHandler.EndInvoke(lazyResult)).GetHashCode());
            Console.WriteLine(((LazySingle)lazyHandler1.EndInvoke(lazyResult1)).GetHashCode());

            Console.Read();
        }

        public static void AsyncCallbackImpl(IAsyncResult ar)
        {
            FuncHandle fh = ar.AsyncState as FuncHandle;
            CommonSingle re = fh.EndInvoke(ar);
            Console.WriteLine(re.GetHashCode());
        }
    }
}
