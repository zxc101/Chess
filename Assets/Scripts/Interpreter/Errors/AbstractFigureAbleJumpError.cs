using UnityEngine;

using Chess.Configuration;

namespace Chess.Errors
{
    public abstract class AbstractFigureAbleJumpError : AbstractFigureError
    {
        internal AbstractFigureAbleJumpError(Position startPosition, Position endPosition) : base(startPosition, endPosition)
        {
            JumpError();
        }

        private void JumpError()
        {
            RaycastHit hit;

            if (Physics.Raycast(startPos, endPos - startPos, out hit, Mathf.Sqrt(Mathf.Pow(Mathf.Abs(startPos.x - endPos.x), 2) + Mathf.Pow(Mathf.Abs(startPos.z - endPos.z), 2))))
            {
                if (hit.transform.position != endPos)
                {
                    switch (hit.transform.name.Substring(5))
                    {
                        case "Rock":
                            Errors.Add($"{name} не может перескочить ладью");
                            break;
                        case "Knight":
                            Errors.Add($"{name} не может перескочить коня");
                            break;
                        case "Bishop":
                            Errors.Add($"{name} не может перескочить слона");
                            break;
                        case "King":
                            Errors.Add($"{name} не может перескочить короля");
                            break;
                        case "Queen":
                            Errors.Add($"{name} не может перескочить королеву");
                            break;
                        case "Pawn":
                            Errors.Add($"{name} не может перескочить пешку");
                            break;
                    }
                }
            }
        }
    }
}
