using UnityEngine;

public interface IBoardManager
{
    Position GetPosition(string namePosition);
    void MakeStep(string startPosition, string endPosition);
    EFigureColor GetPlayerColor();
}
