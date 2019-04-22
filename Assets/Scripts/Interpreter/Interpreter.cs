using UnityEngine;
using UnityEngine.UI;
using Zenject;

using Chess.Managers;
using Chess.UpdateControllers;

namespace Chess.Interpreter
{
    public class Interpreter : MonoBehaviour, IUpdate
    {
        private IBoardManager _boardManager;

        private InputField _inputText;

        private InputField _outputText;

        [Inject]
        public void Setup(IBoardManager boardManager)
        {
            _boardManager = boardManager;
        }

        private void OnValidate()
        {
            _inputText = transform.Find("InputText").gameObject.GetComponent<InputField>();
            _outputText = transform.Find("OutputText").gameObject.GetComponent<InputField>();

            FindObjectOfType<UpdateController>()?.AddFixedUpdate(this);
        }

        public void OnUpdate()
        {
            if (Input.GetKeyDown(KeyCode.KeypadEnter))
            {
                NextStep();
            }
        }

        public void PrevStep()
        {
            _outputText.text = "";
            _boardManager.MakeStepBack();
        }

        public void NextStep()
        {
            _outputText.text = "";
            Context context = new Context(_inputText.text, ref _boardManager);
            if (context.IsAllRight())
            {
                _boardManager.MakeStepForward(context.StartPosition, context.EndPosition);
            }
            else
            {
                System.Collections.Generic.Stack<string> Errors = context.GetErrors();
                while (context.GetErrors().ToArray().Length > 0)
                {
                    _outputText.text += $"{Errors.Pop()}\n\n";
                }
            }
        }
    }
}
