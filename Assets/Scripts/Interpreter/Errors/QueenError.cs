using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QueenError
{
    public static List<string> ErrorMove(Position startPosition, Position endPosition)
    {
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
            Errors.Add("Королева не может атаковать себя");
        }

        if (Physics.Raycast(startPos, endPos - startPos, out hit, Mathf.Sqrt(Mathf.Pow(Mathf.Abs(startPos.x - endPos.x), 2) + Mathf.Pow(Mathf.Abs(startPos.z - endPos.z), 2))))
        {
            if (hit.transform.position != endPos)
            {
                switch (hit.transform.name.Substring(5))
                {
                    case "Rock":
                        Errors.Add($"Королева не может перескочить ладью");
                        break;
                    case "Knight":
                        Errors.Add($"Королева не может перескочить коня");
                        break;
                    case "Bishop":
                        Errors.Add($"Королева не может перескочить слона");
                        break;
                    case "King":
                        Errors.Add($"Королева не может перескочить короля");
                        break;
                    case "Queen":
                        Errors.Add($"Королева не может перескочить другую королеву");
                        break;
                    case "Pawn":
                        Errors.Add($"Королева не может перескочить пешку");
                        break;
                }
            }
        }

        if (Mathf.Abs(startPos.x - endPos.x) - Mathf.Abs(startPos.z - endPos.z) == 0 ||
            startPos.x == endPos.x && startPos.z != endPos.z ||
            startPos.x != endPos.x && startPos.z == endPos.z)
        {
            if (startColor == endColor)
            {
                Errors.Add($"Королева не может атаковать своих");
            }
        }
        else
        {
            if (endColor == EFigureColor.None)
            {
                Errors.Add($"Королева не может так ходить");
            }
            else
            {
                Errors.Add($"Королева не может так атаковать");
            }
        }
        return Errors;
    }
}
