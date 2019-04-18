using System.Collections.Generic;

using Chess.Errors;
using Chess.Managers;

namespace Chess.Interpreter
{
    public class Context
    {
        internal string StartPosition { get; private set; }
        internal string EndPosition { get; private set; }

        private Stack<string> _errors;

        private bool _isAllRight;

        internal Context(string inputText, ref IBoardManager boardManager)
        {
            inputText = inputText.ToUpper();
            ErrorInputTextСhecking e = new ErrorInputTextСhecking(inputText, ref boardManager);
            if (e.IsHaveErrors())
            {
                _errors = e.GetErrors();
                _isAllRight = false;
                return;
            }

            StartPosition = inputText.Split(':')[0];
            EndPosition = inputText.Split(':')[1];

            _isAllRight = true;
        }

        internal Stack<string> GetErrors() => _errors;

        internal bool IsAllRight() => _isAllRight;
    }
}
