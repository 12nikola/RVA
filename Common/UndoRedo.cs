using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Common
{
    public class UndoRedo
    {
        private Stack<ICommand> command=new Stack<ICommand>();
        private Stack<ICommand1> command1=new Stack<ICommand1>();

        private int id { get; set; }
        private int role { get; set; }
        private IService service { get; set; }

        public UndoRedo() { }

        ~UndoRedo() { }

        public string Redo()
        {
            string message = "";
            if (command1.Count != 0)
            {
                ICommand1 commandUR = command1.Pop();

                if (this.role == 0)
                    message = commandUR.Execute(this.id, this.service);
                else
                    message = commandUR.Execute1(this.id, this.service);

                command1.Push(commandUR);
            }
            return message != "" ? message : "There are no previous action!";
        }

        public string Undo()
        {
            string message = "";
            if (command1.Count != 0)
            {
                ICommand1 commandUR = command1.Pop();

                if (this.role == 0)
                    message = commandUR.Unexecute(this.id, this.service);
                else
                    message = commandUR.Unexecute1(this.id, this.service);

                command1.Push(commandUR);
            }
            return message != "" ? message : "There are no previous action!";
        }
    }
}
