using System.Collections.Generic;
using UnityEngine;

using Chess.Configuration;
using Chess.Enums;

namespace Chess.Errors
{
    public class PawnError : AbstractFigureAbleJumpError
    {
        private const int START_POSITION = 25;
        private const int STEP = 10;

        internal PawnError(Position startPosition, Position endPosition) : base(startPosition, endPosition)
        {
            ErrorMove();
        }

        internal override List<string> GetError() => Errors;

        protected override void ErrorMove()
        {
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
                    Errors.Add($"{name} не может так ходить");
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
                        switch (endTepe)
                        {
                            case EFigureType.Bishop:
                                Errors.Add($"{name} отказывается атаковать своего слона");
                                break;
                            case EFigureType.King:
                                Errors.Add($"{name} верна своему королю");
                                break;
                            case EFigureType.Knight:
                                Errors.Add($"{name} отказывается атаковать своего коня");
                                break;
                            case EFigureType.Pown:
                                Errors.Add($"{name} верна своей королеве");
                                break;
                            case EFigureType.Queen:
                                Errors.Add($"{name} не может атаковать свою королеву");
                                break;
                            case EFigureType.Rock:
                                Errors.Add($"{name} отказывается атаковать свою ладью");
                                break;
                        }
                    }
                }
                else
                {
                    Errors.Add($"{name} не может так атаковать");
                }
            }
        }
    }
}