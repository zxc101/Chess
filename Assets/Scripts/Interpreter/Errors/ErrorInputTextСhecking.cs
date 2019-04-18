using System.Collections.Generic;

using Chess.Configuration;
using Chess.Enums;
using Chess.Managers;

namespace Chess.Errors
{
    public class ErrorInputTextСhecking
    {
        private Stack<string> Errors;

        public ErrorInputTextСhecking(string inputText, ref IBoardManager boardManager)
        {
            Errors = new Stack<string>();
            if (inputText.Equals("")) { Errors.Push("Впишите команду"); return; }
            string[] positions = inputText.Split(':');

            ErrorCountPosition(inputText);
            if (ErrorСheckingPositions(positions)) { return; }
            if (ErrorPosition(positions[0], boardManager)) { return; }
            ErrorMove(boardManager.GetPosition(inputText.Split(':')[0]), boardManager.GetPosition(inputText.Split(':')[1]));
        }

        private bool ErrorCountPosition(string inputText)
        {
            string[] positions = inputText.Split(':');
            if (positions.Length > 2)
            {
                Errors.Push("Должна быть только позиция начала и позиция конца хода");
                return true;
            }
            else if (positions.Length < 2)
            {
                Errors.Push("Должна быть позиция начала и позиция конца хода");
                return true;
            }
            return false;
        }

        private bool ErrorСheckingPositions(string[] positions)
        {
            bool b = false;
            foreach (string position in positions)
            {
                if (position.Equals(""))
                {
                    Errors.Push("Одна из позиций пустая.");
                    b = true;
                    continue;
                }

                if (position.Length < 2 || position.Length > 2)
                {
                    Errors.Push($"Название {position} не приемлимо, так как оно должно состоять из одной буквы и одной цифры");
                    b = true;
                    continue;
                }

                if (ErrorLetterPosition(position[0]) && ErrorNumberPosition(position[1]))
                {
                    Errors.Push($"Позиция {position} записана не в том порядке");
                    b = true;
                    continue;
                }

                if (ErrorLetterPosition(position[0]))
                {
                    int numberPosition;
                    if (int.TryParse(position[0].ToString(), out numberPosition))
                    {
                        Errors.Push($"На месте цифры {position[0]} должна быть буква");
                    }
                    else
                    {
                        Errors.Push($"Позиции с буквой \"{position[0]}\" не существует");
                    }
                    b = true;
                }

                if (ErrorNumberPosition(position[1]))
                {
                    Errors.Push($"Позиции с цифрой \"{position[1]}\" не существует");
                    b = true;
                }
            }
            return b;
        }

        private bool ErrorLetterPosition(char namePosition)
        {
            if (namePosition != 'A' &&
                namePosition != 'B' &&
                namePosition != 'C' &&
                namePosition != 'D' &&
                namePosition != 'E' &&
                namePosition != 'F' &&
                namePosition != 'G' &&
                namePosition != 'H')
            {
                return true;
            }
            return false;
        }

        private bool ErrorNumberPosition(char namePosition)
        {
            int numberPosition;
            if (int.TryParse(namePosition.ToString(), out numberPosition))
            {
                if (numberPosition < 1 || numberPosition > 8)
                {
                    return false;
                }
                return false;
            }
            return true;
        }

        private bool ErrorPosition(string position, IBoardManager boardManager)
        {
            if (!boardManager.GetPosition(position).GetFigure())
            {
                Errors.Push($"Вы выбрали пустую клетку");
                return true;
            }
            return false;
        }

        private void ErrorMove(Position startPosition, Position endPosition)
        {
            AbstractFigureError errorsInFigures;
            switch (startPosition.GetFigure().GetComponent<FigureConfiguration>().GetType())
            {
                case EFigureType.Rock:
                    errorsInFigures = new RockError(startPosition, endPosition);
                    break;
                case EFigureType.Knight:
                    errorsInFigures = new KnightError(startPosition, endPosition);
                    break;
                case EFigureType.Bishop:
                    errorsInFigures = new BishopError(startPosition, endPosition);
                    break;
                case EFigureType.King:
                    errorsInFigures = new KingError(startPosition, endPosition);
                    break;
                case EFigureType.Queen:
                    errorsInFigures = new QueenError(startPosition, endPosition);
                    break;
                case EFigureType.Pown:
                    errorsInFigures = new PawnError(startPosition, endPosition);
                    break;
                default:
                    errorsInFigures = new NoneFigureError(startPosition, endPosition);
                    break;
            }

            foreach (string error in errorsInFigures.GetError())
            {
                Errors.Push(error);
            }
        }

        public Stack<string> GetErrors() => Errors;

        public bool IsHaveErrors() => Errors.ToArray().Length > 0 ? true : false;
    }
}