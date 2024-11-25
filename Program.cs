using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_pattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TextEditor textEditor = new TextEditor();
            CommandHistory commandHistory = new CommandHistory();

            ICommand insertCommand1 = new InsertTextCommand(textEditor, "Hello");
            ICommand insertCommand2 = new InsertTextCommand(textEditor, " World!");

            commandHistory.ExecuteCommand(insertCommand1); // Hello
            commandHistory.ExecuteCommand(insertCommand2); // Hello World!
            textEditor.ShowText();

            ICommand deleteCommand = new DeleteTextCommand(textEditor, 6); // Удалить "World!"
            commandHistory.ExecuteCommand(deleteCommand);
            textEditor.ShowText();

            commandHistory.UndoLastCommand();
            textEditor.ShowText();

            commandHistory.UndoLastCommand();
            textEditor.ShowText();

            Console.Read();
        }
    }
}
