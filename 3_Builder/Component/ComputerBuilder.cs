using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Builder.Component
{
    public abstract class ComputerBuilder
    {
        private Computer computerInstance;

        /// <summary>
        /// 返回电脑实例
        /// </summary>
        public Computer ComputerInstance
        {
            get { return computerInstance; }
            set { computerInstance = value; }
        }

        /// <summary>
        /// 创建电脑名称
        /// </summary>
        public abstract void CreateComputerName();
       
        /// <summary>
        /// 创建电脑内存
        /// </summary>
        public abstract void CreateComputerMemory();

        /// <summary>
        /// 创建电脑硬盘
        /// </summary>
        public abstract void CreateComputerDisk();

    }
}
