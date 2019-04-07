using UnityEngine;
using UnityEngine.UI;

public class Interpreter : MonoBehaviour
{
    private InputField _inputText;
    private InputField _outputText;

    private void OnValidate()
    {
        _inputText = transform.Find("InputText").gameObject.GetComponent<InputField>();
        _outputText = transform.Find("OutputText").gameObject.GetComponent<InputField>();
    }

    public void OnChangeInputText()
    {
        Context context = new Context(_inputText.text);
        
        //foreach(GameObject gameObject in FindObjectsOfType<ICharacte>().gameObject)
        //{

        //}
        int x = 5;
        int y = 8;
        int z = 2;

        //context.SetVariable("x", x);
        //context.SetVariable("y", y);
        //context.SetVariable("z", z);

        //IExpression expression = new SubtractExpression(
        //    new AddExpression(
        //        new NumberExpression("x"), new NumberExpression("y")
        //        ),
        //    new NumberExpression("z")
        //    );

        //int result = expression.Interpret(context);
        //_outputText.text = result.ToString();
    }
}
