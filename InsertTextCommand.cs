﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command_pattern
{
    public class InsertTextCommand : ICommand
    {
        private TextEditor _textEditor;
        private string _textToInsert;

        public InsertTextCommand(TextEditor textEditor, string text)
        {
            _textEditor = textEditor;
            _textToInsert = text;
        }

        public void Execute()
        {
            _textEditor.InsertText(_textToInsert);
        }

        public void Undo()
        {
            _textEditor.DeleteText(_textToInsert.Length);
        }
    }
}
