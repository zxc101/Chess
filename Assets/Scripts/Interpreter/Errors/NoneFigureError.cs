using System.Collections.Generic;

using Chess.Configuration;

namespace Chess.Errors
{
    public class NoneFigureError : AbstractFigureError
    {
        internal NoneFigureError(Position startPosition, Position endPosition) : base(startPosition, endPosition) { }

        internal override List<string> GetError() => Errors;

        protected override void ErrorMove() { }
    }
}