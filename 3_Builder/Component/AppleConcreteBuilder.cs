/*
 
         具体建造者：创建产品的实例并且实现建造者多个方法对产品进行装配

 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Builder.Component
{
    public class AppleConcreteBuilder : ComputerBuilder
    {
        public override void CreateComputerName()
        {
            ComputerInstance = new Computer();
            ComputerInstance.ComputerName = "苹果电脑";
        }

        public override void CreateComputerDisk()
        {
            ComputerInstance.DiskSize = "1T";
        }

        public override void CreateComputerMemory()
        {
            ComputerInstance.MemorySize = "8G";
        }
    }
}
