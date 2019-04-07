using UnityEngine;

public class CharacterExpression : ICharacterExpression
{
    string name;

    public CharacterExpression(string variable)
    {
        name = variable;
    }

    public GameObject Interpret(Context context)
    {
        return context.GetVariable(name);
    }
}
