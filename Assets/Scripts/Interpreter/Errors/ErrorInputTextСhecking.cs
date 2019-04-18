using System.Collections.Generic;
using UnityEngine;
using Zenject;

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
            if (position.Equals("")) {
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
        if(!boardManager.GetPosition(position).GetFigure())
        {
            Errors.Push($"Вы выбрали пустую клетку");
            return true;
        }
        return false;
    }

    private void ErrorMove(Position startPosition, Position endPosition)
    {
        switch (startPosition.GetFigure().GetComponent<FigureConfiguration>().GetFigureType())
        {
            case EFigureType.Rock:
                foreach (string error in RockError.ErrorMove(startPosition, endPosition))
                {
                    Errors.Push(error);
                }
                break;
            case EFigureType.Knight:
                foreach (string error in KnightError.ErrorMove(startPosition, endPosition))
                {
                    Errors.Push(error);
                }
                break;
            case EFigureType.Bishop:
                foreach (string error in BishopError.ErrorMove(startPosition, endPosition))
                {
                    Errors.Push(error);
                }
                break;
            case EFigureType.King:
                foreach (string error in KingError.ErrorMove(startPosition, endPosition))
                {
                    Errors.Push(error);
                }
                break;
            case EFigureType.Queen:
                foreach (string error in QueenError.ErrorMove(startPosition, endPosition))
                {
                    Errors.Push(error);
                }
                break;
            case EFigureType.Pown:
                foreach (string error in PawnError.ErrorMove(startPosition, endPosition))
                {
                    Errors.Push(error);
                }
                break;
            default:
                Errors.Push($"Не известная фигура");
                break;
        }
    }

    public Stack<string> GetErrors() => Errors;

    public bool IsHaveErrors() => Errors.ToArray().Length > 0 ? true : false;
}
