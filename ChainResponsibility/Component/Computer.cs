using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChainResponsibility.Component
{
    class Computer
    {

        AStack sttemp = new AStack();

        AStack stoutput = new AStack();

        TreatToken tk;
        public Computer(AStack st)
        {
            sttemp = st;
            AddToken add = new AddToken(sttemp, stoutput);
            SubtractionToken substraction = new SubtractionToken(sttemp, stoutput);
            MultipToken mutiptoken = new MultipToken(sttemp, stoutput);
            DivisionToken division = new DivisionToken(sttemp, stoutput);
            ModToken mod = new ModToken(sttemp, stoutput);

            add.Next = substraction;
            substraction.Next = mutiptoken;
            mutiptoken.Next = division;
            division.Next = mod;
            tk = add;
        }
        public string Do()
        {

            string temp;
            while (!sttemp.IsEmpty())
            {
                temp = sttemp.Pop2().ToString();
                if (ValidateNumber(temp))
                {
                    stoutput.Push(temp);
                }
                else
                {
                    tk.Treat(temp);
                }

            }

            string sout = "";
            while (!stoutput.IsEmpty())
            {

                sout = stoutput.Pop().ToString() + " " + sout;

            }

            return sout;

        }
        /// <summary>
        /// 验证数字
        /// </summary>
        /// <param name="number">数字内容</param>
        /// <returns>true 验证成功 false 验证失败</returns>
        public bool ValidateNumber(string number)
        {
            if (string.IsNullOrEmpty(number))
            {
                return false;
            }
            Regex regex = new Regex(@"^(-)?\d+(\.\d+)?$");
            if (regex.IsMatch(number))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
