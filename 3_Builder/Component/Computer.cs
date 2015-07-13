using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _3_Builder.Component
{
    public class Computer
    {
        private string _computerName;
        private string _memorySize;
        private string _diskSize;


        /// <summary>
        /// 电脑名称
        /// </summary>
        public string ComputerName
        {
            get { return _computerName; }
            set { _computerName = value; }
        }


       /// <summary>
       /// 内存大小
       /// </summary>
        public string MemorySize
        {
            get { return _memorySize; }
            set { _memorySize = value; }
        }


        /// <summary>
        /// 硬盘大小
        /// </summary>
        public string DiskSize
        {
            get { return _diskSize; }
            set { _diskSize = value; }
        }

        public void ShowComputerInfo()
        {
            Console.WriteLine("-------------------");
            Console.WriteLine("电脑名称："+ComputerName);
            Console.WriteLine("内存大小：" + MemorySize);
            Console.WriteLine("硬盘大小：" + DiskSize);
        }
    }
}
