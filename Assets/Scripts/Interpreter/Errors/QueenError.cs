using System.Collections.Generic;
using UnityEngine;

using Chess.Configuration;
using Chess.Enums;

namespace Chess.Errors
{
    public class QueenError : AbstractFigureAbleJumpError
    {
        internal QueenError(Position startPosition, Position endPosition) : base(startPosition, endPosition)
        {
            ErrorMove();
        }

        internal override List<string> GetError() => Errors;

        protected override void ErrorMove()
        {
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
        }
    }
}