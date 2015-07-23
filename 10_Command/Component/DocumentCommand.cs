using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_Command.Component
{
    /**/
    /// <summary>
    /// 抽象命令
    /// </summary>
    public abstract class DocumentCommand
    {
        public Document _document;
        public DocumentCommand(Document doc)
        {
            this._document = doc;
        }
        /**/
        /// <summary>
        /// 执行
        /// </summary>
        public abstract void Execute();
    }

    /**/
    /// <summary>
    /// 显示命令
    /// </summary>
    public class DisplayCommand : DocumentCommand
    {
        public DisplayCommand(Document doc)
            : base(doc)
        {
        }
        public override void Execute()
        {
            _document.Display();
        }
    }

    /**/
    /// <summary>
    /// 撤销命令
    /// </summary>
    public class UndoCommand : DocumentCommand
    {
        public UndoCommand(Document doc)
            : base(doc)
        {
        }
        public override void Execute()
        {
            _document.Undo();
        }
    }

    /**/
    /// <summary>
    /// 重做命令
    /// </summary>
    public class RedoCommand : DocumentCommand
    {
        public RedoCommand(Document doc)
            : base(doc)
        {
        }
        public override void Execute()
        {
            _document.Redo();
        }
    }
}
