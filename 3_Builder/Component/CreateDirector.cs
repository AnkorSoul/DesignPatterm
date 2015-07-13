using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Builder.Component
{
    public class CreateDirector
    {
       /// <summary>
       /// 调用抽象建造者方法，返回实例
       /// </summary>
       /// <param name="builder"></param>
       /// <returns></returns>
        public Computer CreateComputer(ComputerBuilder builder)
        {

            builder.CreateComputerName();
            builder.CreateComputerDisk();
            builder.CreateComputerMemory();

            return builder.ComputerInstance;
        }
    }
}
