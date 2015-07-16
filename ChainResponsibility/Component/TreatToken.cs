using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibility.Component
{
    /// <summary>

    /// TreatToken处理四则表达式中token的基础类

    /// </summary>

    abstract class TreatToken
    {

        //用来处理token的临时堆栈

        protected AStack st;

        //用来保存结果的堆栈

        protected AStack stOutput;

        //Next构成职责链

        protected TreatToken _next;

        public TreatToken Next
        {

            get { return _next; }

            set { _next = value; }

        }

        public TreatToken(AStack st, AStack stout)
        {

            this.st = st;

            this.stOutput = stout;

        }

        public abstract void Treat(string s);



    }


}
