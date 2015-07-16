using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibility.Component
{
    class SubtractionToken : CompToken
    {

        public SubtractionToken(AStack st, AStack stout)

            : base(st, stout)
        {

            token = "-";

        }

        public override double Com(double a, double b)
        {

            return a - b;

        }

    }
}
