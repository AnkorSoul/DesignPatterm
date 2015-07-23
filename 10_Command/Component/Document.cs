using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Command.Component
{
    /**/
    /// <summary>
    /// 文档类
    /// </summary>
    public class Document
    {
        /**/
        /// <summary>
        /// 显示操作
        /// </summary>
        public void Display()
        {
            Console.WriteLine("Display");
        }
        /**/
        /// <summary>
        /// 撤销操作
        /// </summary>
        public void Undo()
        {
            Console.WriteLine("Undo");
        }
        /**/
        /// <summary>
        /// 恢复操作
        /// </summary>
        public void Redo()
        {
            Console.WriteLine("Redo");
        }
    }
}
