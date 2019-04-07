
public class MoveExpression : IExpression
{
    private ICharacterExpression _character;
    private IActionExpression _action;
    private IValueExpression _value;

    public MoveExpression(ICharacterExpression character, IActionExpression action, IValueExpression value)
    {
        _character = character;
        _action = action;
        _value = value;
    }

    public void Interpret(Context context)
    {
        //return _character.Interpret(context) + rightExpression.Interpret(context);
    }
}
