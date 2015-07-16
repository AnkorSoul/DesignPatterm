using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibility.Component
{
    abstract class CompToken : TreatToken
    {

        protected string token = "";

        public CompToken(AStack st, AStack stout)

            : base(st, stout)
        {

        }

        public override void Treat(string s)
        {

            if (s == token)
            {

                double b = Convert.ToDouble(this.stOutput.Pop().ToString());

                double a = Convert.ToDouble(this.stOutput.Pop().ToString());

                double c = Com(a, b);

                this.stOutput.Push(c.ToString());

            }

            else
            {

                this.Next.Treat(s);

            }

        }

        public abstract double Com(double a, double b);

    }
}
