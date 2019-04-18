using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KnightError
{
    public static List<string> ErrorMove(Position startPosition, Position endPosition)
    {
        const int STEP = 10;

        List<string> Errors = new List<string>();

        EFigureColor startColor = EFigureColor.None;
        Vector3 startPos = startPosition.GetPosition();

        EFigureColor endColor = EFigureColor.None;
        Vector3 endPos = endPosition.GetPosition();

        RaycastHit hit;

        if (startPosition.GetFigure())
        {
            startColor = startPosition.GetFigure().GetComponent<FigureConfiguration>().GetColor();
        }

        if (endPosition.GetFigure())
        {
            endColor = endPosition.GetFigure().GetComponent<FigureConfiguration>().GetColor();
        }

        if (startPos == endPos)
        {
            Errors.Add("Конь не может атаковать себя");
        }

        if (
            (Mathf.Abs(startPos.x - endPos.x) == STEP * 2 && Mathf.Abs(startPos.z - endPos.z) == STEP) ||
            (Mathf.Abs(startPos.x - endPos.x) == STEP && Mathf.Abs(startPos.z - endPos.z) == STEP * 2)
           )
        {
            if (startColor == endColor)
            {
                Errors.Add($"Конь не может атаковать своих");
            }
        }
        else
        {
            if (endColor == EFigureColor.None)
            {
                Errors.Add($"Конь не может так ходить");
            }
            else
            {
                Errors.Add($"Конь не может так атаковать");
            }
        }
        return Errors;
    }
}
