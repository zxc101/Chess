using System.Collections.Generic;
using UnityEngine;

using Chess.Configuration;
using Chess.Enums;

namespace Chess.Errors
{
    public class BishopError : AbstractFigureAbleJumpError
    {
        internal BishopError(Position startPosition, Position endPosition) : base(startPosition, endPosition)
        {
            ErrorMove();
        }

        internal override List<string> GetError() => Errors;

        protected override void ErrorMove()
        {
            if (Mathf.Abs(startPos.x - endPos.x) - Mathf.Abs(startPos.z - endPos.z) == 0)
            {
                if (startColor == endColor)
                {
                    Errors.Add($"{name} не может атаковать своих");
                }
            }
            else
            {
                if (endColor == EFigureColor.None)
                {
                    Errors.Add($"{name} не может так ходить");
                }
                else
                {
                    Errors.Add($"{name} не может так атаковать");
                }
            }
        }
    }
}
