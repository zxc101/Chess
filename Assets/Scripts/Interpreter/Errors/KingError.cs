using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KingError
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
            Errors.Add("Король не может атаковать себя");
        }

        if (Physics.Raycast(startPos, endPos - startPos, out hit, Mathf.Sqrt(Mathf.Pow(Mathf.Abs(startPos.x - endPos.x), 2) + Mathf.Pow(Mathf.Abs(startPos.z - endPos.z), 2))))
        {
            if (hit.transform.position != endPos)
            {
                switch (hit.transform.name.Substring(5))
                {
                    case "Rock":
                        Errors.Add($"Король не может перескочить ладью");
                        break;
                    case "Knight":
                        Errors.Add($"Король не может перескочить коня");
                        break;
                    case "Bishop":
                        Errors.Add($"Король не может перескочить слона");
                        break;
                    case "King":
                        Errors.Add($"Король не может перескочить другого короля");
                        break;
                    case "Queen":
                        Errors.Add($"Король не может перескочить королеву");
                        break;
                    case "Pawn":
                        Errors.Add($"Король не может перескочить пешку");
                        break;
                }
            }
        }

        if ((Mathf.Abs(startPos.x - endPos.x) == STEP || Mathf.Abs(startPos.x - endPos.x) == 0) &&
            (Mathf.Abs(startPos.z - endPos.z) == STEP || Mathf.Abs(startPos.z - endPos.z) == 0) &&
            (Mathf.Abs(startPos.x - endPos.x) - Mathf.Abs(startPos.z - endPos.z) == 0 ||
            startPos.x == endPos.x && startPos.z != endPos.z ||
            startPos.x != endPos.x && startPos.z == endPos.z)
           )
        {
            if (startColor == endColor)
            {
                Errors.Add($"Король не может атаковать своих");
            }
        }
        else
        {
            if (endColor == EFigureColor.None)
            {
                Errors.Add($"Король не может так ходить");
            }
            else
            {
                Errors.Add($"Король не может так атаковать");
            }
        }
        return Errors;
    }
}
