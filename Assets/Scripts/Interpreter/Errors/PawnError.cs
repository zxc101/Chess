using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PawnError
{
    public static List<string> ErrorMove(Position startPosition, Position endPosition)
    {
        const int STEP = 10;
        const int START_POSITION = 25;

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

        if(startPos == endPos)
        {
            Errors.Add("Пешка не может атаковать себя");
        }

        if(Physics.Raycast(startPos, endPos - startPos, out hit, Mathf.Sqrt(Mathf.Pow(Mathf.Abs(startPos.x - endPos.x), 2) + Mathf.Pow(Mathf.Abs(startPos.z - endPos.z), 2))))
        {
            if(hit.transform.position != endPos)
            {
                switch (hit.transform.name.Substring(5))
                {
                    case "Rock":
                        Errors.Add($"Пешка не может перескочить ладью");
                        break;
                    case "Knight":
                        Errors.Add($"Пешка не может перескочить коня");
                        break;
                    case "Bishop":
                        Errors.Add($"Пешка не может перескочить слона");
                        break;
                    case "King":
                        Errors.Add($"Пешка не может перескочить короля");
                        break;
                    case "Queen":
                        Errors.Add($"Пешка не может перескочить королеву");
                        break;
                    case "Pawn":
                        Errors.Add($"Пешка не может перескочить другую пешку");
                        break;
                }
            }
        }

        // Передвижение
        if (endColor == EFigureColor.None)
        {
            if (
                 !(
                    startColor == EFigureColor.White &&
                        (startPos.z == -START_POSITION &&
                            (endPos - startPos) == Vector3.forward * STEP || (endPos - startPos) == Vector3.forward * STEP * 2) ||
                        (startPos.z > -START_POSITION &&
                            (endPos - startPos) == Vector3.forward * STEP)
                            
                            ||

                    startColor == EFigureColor.Black &&
                        (startPos.z == START_POSITION &&
                            (endPos - startPos) == -Vector3.forward * STEP || (endPos - startPos) == -Vector3.forward * STEP * 2) ||
                        (startPos.z < START_POSITION &&
                            (endPos - startPos) == -Vector3.forward * STEP)
                  )
               )
            {
                Errors.Add($"Пешка не может так ходить");
            }
        }
        // Атака
        else
        {
            if (
                    startColor == EFigureColor.White &&
                        (startPos.z >= -START_POSITION &&
                            (endPos - startPos) == (Vector3.forward + Vector3.left) * STEP || (endPos - startPos) == (Vector3.forward - Vector3.left) * STEP)

                            ||

                    startColor == EFigureColor.Black &&
                        (startPos.z <= START_POSITION &&
                            (endPos - startPos) == (-Vector3.forward + Vector3.left) * STEP || (endPos - startPos) == (-Vector3.forward - Vector3.left) * STEP)
               )
            {
                if (startColor == endColor)
                {
                    Errors.Add($"Пешка не может атаковать своих");
                }
            }
            else
            {
                Errors.Add($"Пешка не может так атаковать");
            }
        }

        return Errors;
    }
}
