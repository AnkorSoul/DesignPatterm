using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibility.Component
{
    /**/
    /// <summary>

    /// OperatorToken处理操作符+-*/()等

    /// </summary>

    class OperatorToken : TreatToken
    {

        private MyOperatoer ope;

        public OperatorToken(AStack st, AStack stout, MyOperatoer op)

            : base(st, stout)
        {

            this.ope = op;

        }

        public override void Treat(string s)
        {

            if (s == ope.OP)
            {

                if (st.IsEmpty() || s == "(")
                {

                    st.Push(ope);

                }

                else
                {

                    MyOperatoer o = (MyOperatoer)st.TopItem();

                    while (o.Level >= ope.Level || ope.OP == ")")
                    {

                        MyOperatoer o1 = (MyOperatoer)st.Pop();

                        if (o1.OP == "(")
                        {

                            break;

                        }

                        this.stOutput.Push(o1);

                        if (st.IsEmpty())
                        {

                            break;

                        }

                        o = (MyOperatoer)st.TopItem();

                    }

                    if (ope.OP != ")")
                    {

                        st.Push(ope);

                    }

                }

            }

            else
            {

                this.Next.Treat(s);

            }

        }

    }


}
