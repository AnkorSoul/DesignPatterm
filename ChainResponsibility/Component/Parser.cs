using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainResponsibility.Component
{
    /**/
    /// <summary>

    /// Parser采用职责链将四则元算转化为后表达式

    /// </summary>

    class Parser
    {

        AStack sttemp = new AStack();

        AStack stoutput = new AStack();

        TreatToken tk;

        public Parser()
        {

            NumberToken nt = new NumberToken(sttemp, stoutput);

            OperatorToken op1 = new OperatorToken(sttemp, stoutput, new MyOperatoer("+", 11));

            OperatorToken op2 = new OperatorToken(sttemp, stoutput, new MyOperatoer("-", 11));

            OperatorToken op3 = new OperatorToken(sttemp, stoutput, new MyOperatoer("*", 10));

            OperatorToken op4 = new OperatorToken(sttemp, stoutput, new MyOperatoer("/", 10));

            OperatorToken op5 = new OperatorToken(sttemp, stoutput, new MyOperatoer("%", 10));

            OperatorToken op6 = new OperatorToken(sttemp, stoutput, new MyOperatoer("(", 9));

            OperatorToken op7 = new OperatorToken(sttemp, stoutput, new MyOperatoer(")", 8));

            OtherToken ot = new OtherToken();

            nt.Next = op1;

            op1.Next = op2;

            op2.Next = op3;

            op3.Next = op4;

            op4.Next = op5;

            op5.Next = op6;

            op6.Next = op7;

            op7.Next = ot;

            tk = nt;

        }

        public string Do(string s)
        {

            string sout = "";

            string[] strArr = GetStrList(s);

            for (int i = 0; i < strArr.Length; i++)
            {

                tk.Treat(strArr[i]);

            }

            while (!sttemp.IsEmpty())
            {

                stoutput.Push(sttemp.Pop());

            }

            while (!stoutput.IsEmpty())
            {

                sout = stoutput.Pop().ToString() + " " + sout;

            }

            return sout;

        }

        public AStack ReturnAStack(string s)
        {

            string[] strArr = GetStrList(s);

            for (int i = 0; i < strArr.Length; i++)
            {

                tk.Treat(strArr[i]);

            }

            while (!sttemp.IsEmpty())
            {

                stoutput.Push(sttemp.Pop());

            }

            return stoutput;

        }

        private string[] GetStrList(string s)
        {

            string[] strArr = s.Split(" ".ToCharArray());

            return strArr;

        }

    }
}
