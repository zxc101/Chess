using System.Collections.Generic;
using UnityEngine;

public class Context
{
    public string StartPosition { get; private set; }
    public string EndPosition { get; private set; }

    private Stack<string> _errors;

    private bool _isAllRight;

    public Context(string inputText, ref IBoardManager boardManager)
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

    public Stack<string> GetErrors() => _errors;

    public bool IsAllRight() => _isAllRight;
}
