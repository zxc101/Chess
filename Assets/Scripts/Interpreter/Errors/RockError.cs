using System.Collections.Generic;

using Chess.Configuration;
using Chess.Enums;

namespace Chess.Errors
{
    public class RockError : AbstractFigureAbleJumpError
    {
        internal RockError(Position startPosition, Position endPosition) : base(startPosition, endPosition)
        {
            ErrorMove();
        }

        internal override List<string> GetError() => Errors;

        protected override void ErrorMove()
        {
            if (startPos.x == endPos.x && startPos.z != endPos.z ||
                startPos.x != endPos.x && startPos.z == endPos.z)
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