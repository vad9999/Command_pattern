using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_pattern
{
    public class DeleteTextCommand : ICommand
    {
        private TextEditor _textEditor;
        private int _lengthToDelete;
        private string _deletedText;

        public DeleteTextCommand(TextEditor textEditor, int length)
        {
            _textEditor = textEditor;
            _lengthToDelete = length;
        }

        public void Execute()
        {
            _deletedText = _textEditor.DeleteText(_lengthToDelete);
        }

        public void Undo()
        {
            _textEditor.InsertText(_deletedText);
        }
    }
}
