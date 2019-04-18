using System.Collections;
using System.Collections.Generic;
using UnityEngine;

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

    public GameObject GetBlackRock() => _blackRock;
    public GameObject GetBlackKnight() => _blackKnight;
    public GameObject GetBlackBishop() => _blackBishop;
    public GameObject GetBlackKing() => _blackKing;
    public GameObject GetBlackQueen() => _blackQueen;
    public GameObject GetBlackPawn() => _blackPawn;

    public GameObject GetWhiteRock() => _whiteRock;
    public GameObject GetWhiteKnight() => _whiteKnight;
    public GameObject GetWhiteBishop() => _whiteBishop;
    public GameObject GetWhiteKing() => _whiteKing;
    public GameObject GetWhiteQueen() => _whiteQueen;
    public GameObject GetWhitePawn() => _whitePawn;
}
