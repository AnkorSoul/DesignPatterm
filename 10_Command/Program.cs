/*
 
 * 行为请求者”与“行为实现者”解耦，在面向对象语言中，常见的实现手段是“将行为抽象为对象”。
 
 */

using _10_Command.Component;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Command
{
    class Program
    {
        static void Main(string[] args)
        {
            Document doc = new Document();



            DocumentCommand discmd = new DisplayCommand(doc);

            DocumentCommand undcmd = new UndoCommand(doc);

            DocumentCommand redcmd = new RedoCommand(doc);



            DocumentInvoker invoker = new DocumentInvoker(discmd, undcmd, redcmd);

            invoker.Display();

            invoker.Undo();

            invoker.Redo();
        }
    }
}
