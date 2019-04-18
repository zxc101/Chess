using UnityEngine;

namespace Chess.Managers
{
    public class FiguresManager : MonoBehaviour
    {
        [SerializeField] private GameObject _blackRock;
        [SerializeField] private GameObject _blackKnight;
        [SerializeField] private GameObject _blackBishop;
        [SerializeField] private GameObject _blackKing;
        [SerializeField] private GameObject _blackQueen;
        [SerializeField] private GameObject _blackPawn;

        [SerializeField] private GameObject _whiteRock;
        [SerializeField] private GameObject _whiteKnight;
        [SerializeField] private GameObject _whiteBishop;
        [SerializeField] private GameObject _whiteKing;
        [SerializeField] private GameObject _whiteQueen;
        [SerializeField] private GameObject _whitePawn;

        internal GameObject GetBlackRock() => _blackRock;
        internal GameObject GetBlackKnight() => _blackKnight;
        internal GameObject GetBlackBishop() => _blackBishop;
        internal GameObject GetBlackKing() => _blackKing;
        internal GameObject GetBlackQueen() => _blackQueen;
        internal GameObject GetBlackPawn() => _blackPawn;

        internal GameObject GetWhiteRock() => _whiteRock;
        internal GameObject GetWhiteKnight() => _whiteKnight;
        internal GameObject GetWhiteBishop() => _whiteBishop;
        internal GameObject GetWhiteKing() => _whiteKing;
        internal GameObject GetWhiteQueen() => _whiteQueen;
        internal GameObject GetWhitePawn() => _whitePawn;
    }
}