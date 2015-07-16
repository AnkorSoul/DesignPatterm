using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ChainResponsibility.Component
{

    /// <summary>

    /// NumberToken处理数字

    /// </summary>

    class NumberToken : TreatToken
    {

        public NumberToken(AStack st, AStack stout)

            : base(st, stout)
        {



        }

        public override void Treat(string s)
        {



            if (ValidateNumber(s))
            {

                this.stOutput.Push(s);

            }

            else
            {

                this.Next.Treat(s);

            }

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
