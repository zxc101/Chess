using System.Collections.Generic;
using UnityEngine;

using Chess.Configuration;
using Chess.Enums;

public abstract class AbstractFigureError
{
    protected List<string> Errors;

    protected EFigureColor startColor;
    protected Vector3 startPos;

    protected EFigureColor endColor;
    protected Vector3 endPos;

    protected string name;

    internal AbstractFigureError(Position startPosition, Position endPosition)
    {
        Initialization(startPosition, endPosition);
        AttackMySelf();
    }

    private void Initialization(Position startPosition, Position endPosition)
    {
        Errors = new List<string>();

        name = GetName(startPosition);

        startColor = EFigureColor.None;
        startPos = startPosition.GetPosition();

        endColor = EFigureColor.None;
        endPos = endPosition.GetPosition();

        if (startPosition.GetFigure())
        {
            startColor = startPosition.GetFigure().GetComponent<FigureConfiguration>().GetColor();
        }

        if (endPosition.GetFigure())
        {
            endColor = endPosition.GetFigure().GetComponent<FigureConfiguration>().GetColor();
        }
    }

    private string GetName(Position startPosition)
    {
        switch (startPosition.GetFigure().GetComponent<FigureConfiguration>().GetType())
        {
            case EFigureType.Bishop:
                return "Слон";
            case EFigureType.King:
                return "Король";
            case EFigureType.Knight:
                return "Конь";
            case EFigureType.Pown:
                return "Пешка";
            case EFigureType.Queen:
                return "Королева";
            case EFigureType.Rock:
                return "Ладья";
            default:
                return "Неизвестная фигура";
        }
    }

    private void AttackMySelf()
    {
        if (startPos == endPos)
        {
            Errors.Add($"{name} не может атаковать себя");
        }
    }

    internal abstract List<string> GetError();

    protected abstract void ErrorMove();
}
