using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibility.Component
{
    class OtherToken : TreatToken
    {

        public OtherToken()

            : base(null, null)
        {



        }

        public override void Treat(string s)
        {

            if (s != "")
            {

                throw new Exception("无法识别的操作符" + s);

            }

        }

    }

}
