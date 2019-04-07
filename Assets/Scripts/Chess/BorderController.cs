using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BorderController : MonoBehaviour
{
    #region FigureGameObjects
    #region BlackFigureGameObjects
    public GameObject LeftBlackRock;
    public GameObject LeftBlackKnight;
    public GameObject LeftBlackBishop;
    public GameObject BlackKing;
    public GameObject BlackQueen;
    public GameObject RightBlackBishop;
    public GameObject RightBlackKnight;
    public GameObject RightBlackRock;
    public GameObject BlackPawn1;
    public GameObject BlackPawn2;
    public GameObject BlackPawn3;
    public GameObject BlackPawn4;
    public GameObject BlackPawn5;
    public GameObject BlackPawn6;
    public GameObject BlackPawn7;
    public GameObject BlackPawn8;
    #endregion
    
    #region WhiteFigureGameObjects
    public GameObject LeftWhiteRock;
    public GameObject LeftWhiteKnight;
    public GameObject LeftWhiteBishop;
    public GameObject WhiteQueen;
    public GameObject WhiteKing;
    public GameObject RightWhiteBishop;
    public GameObject RightWhiteKnight;
    public GameObject RightWhiteRock;
    public GameObject WhitePawn1;
    public GameObject WhitePawn2;
    public GameObject WhitePawn3;
    public GameObject WhitePawn4;
    public GameObject WhitePawn5;
    public GameObject WhitePawn6;
    public GameObject WhitePawn7;
    public GameObject WhitePawn8;
    #endregion
    #endregion

    private Dictionary<string, GameObject> _blackMap;
    private Dictionary<string, GameObject> _whiteMap;

    private void OnValidate()
    {
        #region FigureGameObjects
        #region Find BlackFigureGameObjects
        LeftBlackRock = GameObject.Find("LeftBlackRock");
        LeftBlackKnight = GameObject.Find("LeftBlackKnight");
        LeftBlackBishop = GameObject.Find("LeftBlackBishop");
        BlackKing = GameObject.Find("BlackKing");
        BlackQueen = GameObject.Find("BlackQueen");
        RightBlackBishop = GameObject.Find("RightBlackBishop");
        RightBlackKnight = GameObject.Find("RightBlackKnight");
        RightBlackRock = GameObject.Find("RightBlackRock");
        BlackPawn1 = GameObject.Find("BlackPawn1");
        BlackPawn2 = GameObject.Find("BlackPawn2");
        BlackPawn3 = GameObject.Find("BlackPawn3");
        BlackPawn4 = GameObject.Find("BlackPawn4");
        BlackPawn5 = GameObject.Find("BlackPawn5");
        BlackPawn6 = GameObject.Find("BlackPawn6");
        BlackPawn7 = GameObject.Find("BlackPawn7");
        BlackPawn8 = GameObject.Find("BlackPawn8");
        #endregion

        #region Find WhiteFigureGameObjects
        LeftWhiteRock = GameObject.Find("LeftWhiteRock");
        LeftWhiteKnight = GameObject.Find("LeftWhiteKnight");
        LeftWhiteBishop = GameObject.Find("LeftWhiteBishop");
        WhiteQueen = GameObject.Find("WhiteQueen");
        WhiteKing = GameObject.Find("WhiteKing");
        RightWhiteBishop = GameObject.Find("RightWhiteBishop");
        RightWhiteKnight = GameObject.Find("RightWhiteKnight");
        RightWhiteRock = GameObject.Find("RightWhiteRock");
        WhitePawn1 = GameObject.Find("WhitePawn1");
        WhitePawn2 = GameObject.Find("WhitePawn2");
        WhitePawn3 = GameObject.Find("WhitePawn3");
        WhitePawn4 = GameObject.Find("WhitePawn4");
        WhitePawn5 = GameObject.Find("WhitePawn5");
        WhitePawn6 = GameObject.Find("WhitePawn6");
        WhitePawn7 = GameObject.Find("WhitePawn7");
        WhitePawn8 = GameObject.Find("WhitePawn8");
        #endregion
        #endregion
    }

    private void Start()
    {
        _blackMap = new Dictionary<string, GameObject>();
        _whiteMap = new Dictionary<string, GameObject>();

        #region CreateMaps
        CreateA();
        CreateB();
        CreateC();
        CreateD();
        CreateE();
        CreateF();
        CreateG();
        CreateH();
        #endregion
    }

    #region MethodsCreateMaps
    #region Create A
    private void CreateA()
    {
        CreateBlackA();
        CreateWhiteA();
    }

    private void CreateBlackA()
    {
        _blackMap.Add("A1", LeftBlackRock);
        _blackMap.Add("A2", BlackPawn1);
        _blackMap.Add("A3", null);
        _blackMap.Add("A4", null);
        _blackMap.Add("A5", null);
        _blackMap.Add("A6", null);
        _blackMap.Add("A7", WhitePawn8);
        _blackMap.Add("A8", RightWhiteRock);
    }

    private void CreateWhiteA()
    {
        _whiteMap.Add("A1", LeftWhiteRock);
        _whiteMap.Add("A2", WhitePawn1);
        _whiteMap.Add("A3", null);
        _whiteMap.Add("A4", null);
        _whiteMap.Add("A5", null);
        _whiteMap.Add("A6", null);
        _whiteMap.Add("A7", BlackPawn8);
        _whiteMap.Add("A8", RightBlackRock);
    }
    #endregion

    #region Create B
    private void CreateB()
    {
        CreateBlackB();
        CreateWhiteB();
    }

    private void CreateBlackB()
    {
        _blackMap.Add("B1", LeftBlackKnight);
        _blackMap.Add("B2", BlackPawn2);
        _blackMap.Add("B3", null);
        _blackMap.Add("B4", null);
        _blackMap.Add("B5", null);
        _blackMap.Add("B6", null);
        _blackMap.Add("B7", WhitePawn7);
        _blackMap.Add("B8", RightWhiteKnight);
    }

    private void CreateWhiteB()
    {
        _whiteMap.Add("B1", LeftWhiteKnight);
        _whiteMap.Add("B2", WhitePawn2);
        _whiteMap.Add("B3", null);
        _whiteMap.Add("B4", null);
        _whiteMap.Add("B5", null);
        _whiteMap.Add("B6", null);
        _whiteMap.Add("B7", BlackPawn7);
        _whiteMap.Add("B8", RightBlackKnight);
    }
    #endregion

    #region Create C
    private void CreateC()
    {
        CreateBlackC();
        CreateWhiteC();
    }

    private void CreateBlackC()
    {
        _blackMap.Add("C1", LeftBlackBishop);
        _blackMap.Add("C2", BlackPawn3);
        _blackMap.Add("C3", null);
        _blackMap.Add("C4", null);
        _blackMap.Add("C5", null);
        _blackMap.Add("C6", null);
        _blackMap.Add("C7", WhitePawn6);
        _blackMap.Add("C8", RightWhiteBishop);
    }

    private void CreateWhiteC()
    {
        _whiteMap.Add("C1", LeftWhiteBishop);
        _whiteMap.Add("C2", WhitePawn3);
        _whiteMap.Add("C3", null);
        _whiteMap.Add("C4", null);
        _whiteMap.Add("C5", null);
        _whiteMap.Add("C6", null);
        _whiteMap.Add("C7", BlackPawn6);
        _whiteMap.Add("C8", RightBlackBishop);
    }
    #endregion

    #region Create D
    private void CreateD()
    {
        CreateBlackD();
        CreateWhiteD();
    }

    private void CreateBlackD()
    {
        _blackMap.Add("D1", BlackKing);
        _blackMap.Add("D2", BlackPawn4);
        _blackMap.Add("D3", null);
        _blackMap.Add("D4", null);
        _blackMap.Add("D5", null);
        _blackMap.Add("D6", null);
        _blackMap.Add("D7", WhitePawn5);
        _blackMap.Add("D8", WhiteKing);
    }

    private void CreateWhiteD()
    {
        _whiteMap.Add("D1", WhiteQueen);
        _whiteMap.Add("D2", WhitePawn4);
        _whiteMap.Add("D3", null);
        _whiteMap.Add("D4", null);
        _whiteMap.Add("D5", null);
        _whiteMap.Add("D6", null);
        _whiteMap.Add("D7", BlackPawn5);
        _whiteMap.Add("D8", BlackQueen);
    }
    #endregion

    #region Create E
    private void CreateE()
    {
        CreateBlackE();
        CreateWhiteE();
    }

    private void CreateBlackE()
    {
        _blackMap.Add("E1", BlackQueen);
        _blackMap.Add("E2", BlackPawn5);
        _blackMap.Add("E3", null);
        _blackMap.Add("E4", null);
        _blackMap.Add("E5", null);
        _blackMap.Add("E6", null);
        _blackMap.Add("E7", WhitePawn4);
        _blackMap.Add("E8", WhiteQueen);
    }

    private void CreateWhiteE()
    {
        _whiteMap.Add("E1", WhiteKing);
        _whiteMap.Add("E2", WhitePawn5);
        _whiteMap.Add("E3", null);
        _whiteMap.Add("E4", null);
        _whiteMap.Add("E5", null);
        _whiteMap.Add("E6", null);
        _whiteMap.Add("E7", BlackPawn4);
        _whiteMap.Add("E8", BlackKing);
    }
    #endregion

    #region Create F
    private void CreateF()
    {
        CreateBlackF();
        CreateWhiteF();
    }

    private void CreateBlackF()
    {
        _blackMap.Add("F1", RightBlackBishop);
        _blackMap.Add("F2", BlackPawn6);
        _blackMap.Add("F3", null);
        _blackMap.Add("F4", null);
        _blackMap.Add("F5", null);
        _blackMap.Add("F6", null);
        _blackMap.Add("F7", WhitePawn3);
        _blackMap.Add("F8", LeftWhiteBishop);
    }

    private void CreateWhiteF()
    {
        _whiteMap.Add("F1", RightWhiteBishop);
        _whiteMap.Add("F2", WhitePawn6);
        _whiteMap.Add("F3", null);
        _whiteMap.Add("F4", null);
        _whiteMap.Add("F5", null);
        _whiteMap.Add("F6", null);
        _whiteMap.Add("F7", BlackPawn3);
        _whiteMap.Add("F8", LeftBlackBishop);
    }
    #endregion

    #region Create G
    private void CreateG()
    {
        CreateBlackG();
        CreateWhiteG();
    }

    private void CreateBlackG()
    {
        _blackMap.Add("G1", RightBlackKnight);
        _blackMap.Add("G2", BlackPawn7);
        _blackMap.Add("G3", null);
        _blackMap.Add("G4", null);
        _blackMap.Add("G5", null);
        _blackMap.Add("G6", null);
        _blackMap.Add("G7", WhitePawn2);
        _blackMap.Add("G8", LeftWhiteKnight);
    }

    private void CreateWhiteG()
    {
        _whiteMap.Add("G1", RightWhiteKnight);
        _whiteMap.Add("G2", WhitePawn7);
        _whiteMap.Add("G3", null);
        _whiteMap.Add("G4", null);
        _whiteMap.Add("G5", null);
        _whiteMap.Add("G6", null);
        _whiteMap.Add("G7", BlackPawn2);
        _whiteMap.Add("G8", LeftBlackKnight);
    }
    #endregion

    #region Create H
    private void CreateH()
    {
        CreateBlackH();
        CreateWhiteH();
    }

    private void CreateBlackH()
    {
        _blackMap.Add("H1", RightBlackRock);
        _blackMap.Add("H2", BlackPawn8);
        _blackMap.Add("H3", null);
        _blackMap.Add("H4", null);
        _blackMap.Add("H5", null);
        _blackMap.Add("H6", null);
        _blackMap.Add("H7", WhitePawn1);
        _blackMap.Add("H8", LeftWhiteRock);
    }

    private void CreateWhiteH()
    {
        _whiteMap.Add("H1", RightWhiteRock);
        _whiteMap.Add("H2", WhitePawn8);
        _whiteMap.Add("H3", null);
        _whiteMap.Add("H4", null);
        _whiteMap.Add("H5", null);
        _whiteMap.Add("H6", null);
        _whiteMap.Add("H7", BlackPawn1);
        _whiteMap.Add("H8", LeftBlackRock);
    }
    #endregion
    #endregion

    /// <summary>
    /// Находит обратное название для чёрных/белых
    /// </summary>
    /// <param name="namePosition">Название позиции</param>
    /// <returns>Обратное название</returns>
    public string GetReflectedNamePosition(string namePosition)
    {
        string reflectedNamePosition = "";
        int numberPosition;

        switch (namePosition[0])
        {
            case 'A':
                reflectedNamePosition = "H";
                break;
            case 'B':
                reflectedNamePosition = "G";
                break;
            case 'C':
                reflectedNamePosition = "F";
                break;
            case 'D':
                reflectedNamePosition = "E";
                break;
            case 'E':
                reflectedNamePosition = "D";
                break;
            case 'F':
                reflectedNamePosition = "C";
                break;
            case 'G':
                reflectedNamePosition = "B";
                break;
            case 'H':
                reflectedNamePosition = "A";
                break;
        }

        if (int.TryParse(namePosition[1].ToString(), out numberPosition))
        {
            if(numberPosition >= 1 && numberPosition <= 8)
            {
                reflectedNamePosition += 9 - numberPosition;
            }
        }
        return reflectedNamePosition;
    }
}
