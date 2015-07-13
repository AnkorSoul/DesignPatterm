using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5_Prototype.Component
{
    public class ConcteteColorPrototype : ColorPrototype
    {
        private int _red, _green, _blue;

        public ConcteteColorPrototype(int red, int green, int blue)
        {
            this._red = red;
            _green = green;
            _blue = blue;

        }
        public override ColorPrototype Clone()
        {
            //浅拷贝
            return (ColorPrototype)this.MemberwiseClone();
        }

        public void Display(string colorName)
        {
            Console.WriteLine("{0}'s RGB Values are:{1},{2},{3}", colorName, _red, _green, _blue);
        }
    }
}
