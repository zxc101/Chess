using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BishopError
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
            Errors.Add("Слон не может атаковать себя");
        }

        if (Physics.Raycast(startPos, endPos - startPos, out hit, Mathf.Sqrt(Mathf.Pow(Mathf.Abs(startPos.x - endPos.x), 2) + Mathf.Pow(Mathf.Abs(startPos.z - endPos.z), 2))))
        {
            if (hit.transform.position != endPos)
            {
                switch (hit.transform.name.Substring(5))
                {
                    case "Rock":
                        Errors.Add($"Слон не может перескочить ладью");
                        break;
                    case "Knight":
                        Errors.Add($"Слон не может перескочить коня");
                        break;
                    case "Bishop":
                        Errors.Add($"Слон не может перескочить другого слона");
                        break;
                    case "King":
                        Errors.Add($"Слон не может перескочить короля");
                        break;
                    case "Queen":
                        Errors.Add($"Слон не может перескочить королеву");
                        break;
                    case "Pawn":
                        Errors.Add($"Слон не может перескочить пешку");
                        break;
                }
            }
        }

        if(Mathf.Abs(startPos.x - endPos.x) - Mathf.Abs(startPos.z - endPos.z) == 0)
        {
            if (startColor == endColor)
            {
                Errors.Add($"Слон не может атаковать своих");
            }
        }
        else
        {
            if (endColor == EFigureColor.None)
            {
                Errors.Add($"Слон не может так ходить");
            }
            else
            {
                Errors.Add($"Слон не может так атаковать");
            }
        }

        return Errors;
    }
}
