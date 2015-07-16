using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ChainResponsibility.Component
{
    /**/
    /// <summary>

    /// MyOperatoer 操作符和优先级

    /// </summary>

    class MyOperatoer
    {

        private string _ope;

        private int _level;

        public MyOperatoer(string o, int l)
        {

            _ope = o;

            _level = l;

        }

        public string OP
        {

            get { return _ope; }

            set { _ope = value; }

        }

        public int Level
        {

            get { return _level; }

            set { _level = value; }

        }

        public override string ToString()
        {

            return _ope;

        }

    }

}
