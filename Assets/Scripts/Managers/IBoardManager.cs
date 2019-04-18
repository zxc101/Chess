using Chess.Configuration;
using Chess.Enums;

namespace Chess.Managers
{
    public interface IBoardManager
    {
        Position GetPosition(string namePosition);

        EFigureColor GetPlayerColor();

        void MakeStepForward(string startPosition, string endPosition);
        void MakeStepBack();
    }
}