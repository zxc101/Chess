using Chess.Configuration;
using Chess.Enums;

namespace Chess.Managers
{
    public interface IBoardManager
    {
        Position GetPosition(string namePosition);
        void MakeStep(string startPosition, string endPosition);
        EFigureColor GetPlayerColor();
    }
}