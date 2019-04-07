using System.Collections.Generic;
using UnityEngine;

public class Context
{
    private Dictionary<string, GameObject> _characters;

    public Context(string inputText)
    {
        _characters = new Dictionary<string, GameObject>();
    }

    public GameObject GetVariable(string name)
    {
        return _characters[name];
    }

    public void SetVariable(string name, GameObject character)
    {
        if (_characters.ContainsKey(name))
        {
            _characters[name] = character;
        }
        else
        {
            _characters.Add(name, character);
        }
    }
}
