using System.Collections.Generic;
using UnityEngine;

using Chess.Configuration;
using Chess.Enums;

namespace Chess.Managers
{
    public class BoardManager : IBoardManager
    {
        #region Positions
        #region AH
        public Position A1H8;
        public Position A2H7;
        public Position A3H6;
        public Position A4H5;
        public Position A5H4;
        public Position A6H3;
        public Position A7H2;
        public Position A8H1;
        #endregion

        #region BG
        public Position B1G8;
        public Position B2G7;
        public Position B3G6;
        public Position B4G5;
        public Position B5G4;
        public Position B6G3;
        public Position B7G2;
        public Position B8G1;
        #endregion

        #region CF
        public Position C1F8;
        public Position C2F7;
        public Position C3F6;
        public Position C4F5;
        public Position C5F4;
        public Position C6F3;
        public Position C7F2;
        public Position C8F1;
        #endregion

        #region DE
        public Position D1E8;
        public Position D2E7;
        public Position D3E6;
        public Position D4E5;
        public Position D5E4;
        public Position D6E3;
        public Position D7E2;
        public Position D8E1;
        #endregion

        #region ED
        public Position E1D8;
        public Position E2D7;
        public Position E3D6;
        public Position E4D5;
        public Position E5D4;
        public Position E6D3;
        public Position E7D2;
        public Position E8D1;
        #endregion

        #region FC
        public Position F1C8;
        public Position F2C7;
        public Position F3C6;
        public Position F4C5;
        public Position F5C4;
        public Position F6C3;
        public Position F7C2;
        public Position F8C1;
        #endregion

        #region GB
        public Position G1B8;
        public Position G2B7;
        public Position G3B6;
        public Position G4B5;
        public Position G5B4;
        public Position G6B3;
        public Position G7B2;
        public Position G8B1;
        #endregion

        #region HA
        public Position H1A8;
        public Position H2A7;
        public Position H3A6;
        public Position H4A5;
        public Position H5A4;
        public Position H6A3;
        public Position H7A2;
        public Position H8A1;
        #endregion
        #endregion
        
        private Dictionary<string, Position> _blackMap;
        private Dictionary<string, Position> _whiteMap;

        private EFigureColor _playerColor;

        GameObject blackCamera;
        GameObject whiteCamera;

        private BoardManager()
        {
            FiguresManager figuresManager = GameObject.Find("FiguresManager").GetComponent<FiguresManager>();

            blackCamera = GameObject.Find("BlackCamera");
            whiteCamera = GameObject.Find("WhiteCamera");

            #region Find positions

            #region Find AH
            A1H8 = GameObject.Find("A1H8").GetComponent<Position>();
            A2H7 = GameObject.Find("A2H7").GetComponent<Position>();
            A3H6 = GameObject.Find("A3H6").GetComponent<Position>();
            A4H5 = GameObject.Find("A4H5").GetComponent<Position>();
            A5H4 = GameObject.Find("A5H4").GetComponent<Position>();
            A6H3 = GameObject.Find("A6H3").GetComponent<Position>();
            A7H2 = GameObject.Find("A7H2").GetComponent<Position>();
            A8H1 = GameObject.Find("A8H1").GetComponent<Position>();
            #endregion

            #region Find BG
            B1G8 = GameObject.Find("B1G8").GetComponent<Position>();
            B2G7 = GameObject.Find("B2G7").GetComponent<Position>();
            B3G6 = GameObject.Find("B3G6").GetComponent<Position>();
            B4G5 = GameObject.Find("B4G5").GetComponent<Position>();
            B5G4 = GameObject.Find("B5G4").GetComponent<Position>();
            B6G3 = GameObject.Find("B6G3").GetComponent<Position>();
            B7G2 = GameObject.Find("B7G2").GetComponent<Position>();
            B8G1 = GameObject.Find("B8G1").GetComponent<Position>();
            #endregion

            #region Find CF
            C1F8 = GameObject.Find("C1F8").GetComponent<Position>();
            C2F7 = GameObject.Find("C2F7").GetComponent<Position>();
            C3F6 = GameObject.Find("C3F6").GetComponent<Position>();
            C4F5 = GameObject.Find("C4F5").GetComponent<Position>();
            C5F4 = GameObject.Find("C5F4").GetComponent<Position>();
            C6F3 = GameObject.Find("C6F3").GetComponent<Position>();
            C7F2 = GameObject.Find("C7F2").GetComponent<Position>();
            C8F1 = GameObject.Find("C8F1").GetComponent<Position>();
            #endregion

            #region Find DE
            D1E8 = GameObject.Find("D1E8").GetComponent<Position>();
            D2E7 = GameObject.Find("D2E7").GetComponent<Position>();
            D3E6 = GameObject.Find("D3E6").GetComponent<Position>();
            D4E5 = GameObject.Find("D4E5").GetComponent<Position>();
            D5E4 = GameObject.Find("D5E4").GetComponent<Position>();
            D6E3 = GameObject.Find("D6E3").GetComponent<Position>();
            D7E2 = GameObject.Find("D7E2").GetComponent<Position>();
            D8E1 = GameObject.Find("D8E1").GetComponent<Position>();
            #endregion

            #region Find ED
            E1D8 = GameObject.Find("E1D8").GetComponent<Position>();
            E2D7 = GameObject.Find("E2D7").GetComponent<Position>();
            E3D6 = GameObject.Find("E3D6").GetComponent<Position>();
            E4D5 = GameObject.Find("E4D5").GetComponent<Position>();
            E5D4 = GameObject.Find("E5D4").GetComponent<Position>();
            E6D3 = GameObject.Find("E6D3").GetComponent<Position>();
            E7D2 = GameObject.Find("E7D2").GetComponent<Position>();
            E8D1 = GameObject.Find("E8D1").GetComponent<Position>();
            #endregion

            #region Find FC
            F1C8 = GameObject.Find("F1C8").GetComponent<Position>();
            F2C7 = GameObject.Find("F2C7").GetComponent<Position>();
            F3C6 = GameObject.Find("F3C6").GetComponent<Position>();
            F4C5 = GameObject.Find("F4C5").GetComponent<Position>();
            F5C4 = GameObject.Find("F5C4").GetComponent<Position>();
            F6C3 = GameObject.Find("F6C3").GetComponent<Position>();
            F7C2 = GameObject.Find("F7C2").GetComponent<Position>();
            F8C1 = GameObject.Find("F8C1").GetComponent<Position>();
            #endregion

            #region Find GB
            G1B8 = GameObject.Find("G1B8").GetComponent<Position>();
            G2B7 = GameObject.Find("G2B7").GetComponent<Position>();
            G3B6 = GameObject.Find("G3B6").GetComponent<Position>();
            G4B5 = GameObject.Find("G4B5").GetComponent<Position>();
            G5B4 = GameObject.Find("G5B4").GetComponent<Position>();
            G6B3 = GameObject.Find("G6B3").GetComponent<Position>();
            G7B2 = GameObject.Find("G7B2").GetComponent<Position>();
            G8B1 = GameObject.Find("G8B1").GetComponent<Position>();
            #endregion

            #region Find HA
            H1A8 = GameObject.Find("H1A8").GetComponent<Position>();
            H2A7 = GameObject.Find("H2A7").GetComponent<Position>();
            H3A6 = GameObject.Find("H3A6").GetComponent<Position>();
            H4A5 = GameObject.Find("H4A5").GetComponent<Position>();
            H5A4 = GameObject.Find("H5A4").GetComponent<Position>();
            H6A3 = GameObject.Find("H6A3").GetComponent<Position>();
            H7A2 = GameObject.Find("H7A2").GetComponent<Position>();
            H8A1 = GameObject.Find("H8A1").GetComponent<Position>();
            #endregion
            #endregion

            #region Set figures on positions

            #region Set AH
            A1H8.SetFigure(figuresManager.GetBlackRock());
            A2H7.SetFigure(figuresManager.GetBlackPawn());
            A7H2.SetFigure(figuresManager.GetWhitePawn());
            A8H1.SetFigure(figuresManager.GetWhiteRock());
            #endregion

            #region Set BG
            B1G8.SetFigure(figuresManager.GetBlackKnight());
            B2G7.SetFigure(figuresManager.GetBlackPawn());
            B7G2.SetFigure(figuresManager.GetWhitePawn());
            B8G1.SetFigure(figuresManager.GetWhiteKnight());
            #endregion

            #region Set CF
            C1F8.SetFigure(figuresManager.GetBlackBishop());
            C2F7.SetFigure(figuresManager.GetBlackPawn());
            C7F2.SetFigure(figuresManager.GetWhitePawn());
            C8F1.SetFigure(figuresManager.GetWhiteBishop());
            #endregion

            #region Set DE
            D1E8.SetFigure(figuresManager.GetBlackKing());
            D2E7.SetFigure(figuresManager.GetBlackPawn());
            D7E2.SetFigure(figuresManager.GetWhitePawn());
            D8E1.SetFigure(figuresManager.GetWhiteQueen());
            #endregion

            #region Set ED
            E1D8.SetFigure(figuresManager.GetBlackQueen());
            E2D7.SetFigure(figuresManager.GetBlackPawn());
            E7D2.SetFigure(figuresManager.GetWhitePawn());
            E8D1.SetFigure(figuresManager.GetWhiteKing());
            #endregion

            #region Set FC
            F1C8.SetFigure(figuresManager.GetBlackBishop());
            F2C7.SetFigure(figuresManager.GetBlackPawn());
            F7C2.SetFigure(figuresManager.GetWhitePawn());
            F8C1.SetFigure(figuresManager.GetWhiteBishop());
            #endregion

            #region Find GB
            G1B8.SetFigure(figuresManager.GetBlackKnight());
            G2B7.SetFigure(figuresManager.GetBlackPawn());
            G7B2.SetFigure(figuresManager.GetWhitePawn());
            G8B1.SetFigure(figuresManager.GetWhiteKnight());
            #endregion

            #region Find HA
            H1A8.SetFigure(figuresManager.GetBlackRock());
            H2A7.SetFigure(figuresManager.GetBlackPawn());
            H7A2.SetFigure(figuresManager.GetWhitePawn());
            H8A1.SetFigure(figuresManager.GetWhiteRock());
            #endregion
            #endregion

            _blackMap = new Dictionary<string, Position>();
            _whiteMap = new Dictionary<string, Position>();

            blackCamera.SetActive(false);
            _playerColor = EFigureColor.White;

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
            _blackMap.Add("A1", A1H8);
            _blackMap.Add("A2", A2H7);
            _blackMap.Add("A3", A3H6);
            _blackMap.Add("A4", A4H5);
            _blackMap.Add("A5", A5H4);
            _blackMap.Add("A6", A6H3);
            _blackMap.Add("A7", A7H2);
            _blackMap.Add("A8", A8H1);
        }

        private void CreateWhiteA()
        {
            _whiteMap.Add("A1", H8A1);
            _whiteMap.Add("A2", H7A2);
            _whiteMap.Add("A3", H6A3);
            _whiteMap.Add("A4", H5A4);
            _whiteMap.Add("A5", H4A5);
            _whiteMap.Add("A6", H3A6);
            _whiteMap.Add("A7", H2A7);
            _whiteMap.Add("A8", H1A8);
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
            _blackMap.Add("B1", B1G8);
            _blackMap.Add("B2", B2G7);
            _blackMap.Add("B3", B3G6);
            _blackMap.Add("B4", B4G5);
            _blackMap.Add("B5", B5G4);
            _blackMap.Add("B6", B6G3);
            _blackMap.Add("B7", B7G2);
            _blackMap.Add("B8", B8G1);
        }

        private void CreateWhiteB()
        {
            _whiteMap.Add("B1", G8B1);
            _whiteMap.Add("B2", G7B2);
            _whiteMap.Add("B3", G6B3);
            _whiteMap.Add("B4", G5B4);
            _whiteMap.Add("B5", G4B5);
            _whiteMap.Add("B6", G3B6);
            _whiteMap.Add("B7", G2B7);
            _whiteMap.Add("B8", G1B8);
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
            _blackMap.Add("C1", C1F8);
            _blackMap.Add("C2", C2F7);
            _blackMap.Add("C3", C3F6);
            _blackMap.Add("C4", C4F5);
            _blackMap.Add("C5", C5F4);
            _blackMap.Add("C6", C6F3);
            _blackMap.Add("C7", C7F2);
            _blackMap.Add("C8", C8F1);
        }

        private void CreateWhiteC()
        {
            _whiteMap.Add("C1", F8C1);
            _whiteMap.Add("C2", F7C2);
            _whiteMap.Add("C3", F6C3);
            _whiteMap.Add("C4", F5C4);
            _whiteMap.Add("C5", F4C5);
            _whiteMap.Add("C6", F3C6);
            _whiteMap.Add("C7", F2C7);
            _whiteMap.Add("C8", F1C8);
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
            _blackMap.Add("D1", D1E8);
            _blackMap.Add("D2", D2E7);
            _blackMap.Add("D3", D3E6);
            _blackMap.Add("D4", D4E5);
            _blackMap.Add("D5", D5E4);
            _blackMap.Add("D6", D6E3);
            _blackMap.Add("D7", D7E2);
            _blackMap.Add("D8", D8E1);
        }

        private void CreateWhiteD()
        {
            _whiteMap.Add("D1", E8D1);
            _whiteMap.Add("D2", E7D2);
            _whiteMap.Add("D3", E6D3);
            _whiteMap.Add("D4", E5D4);
            _whiteMap.Add("D5", E4D5);
            _whiteMap.Add("D6", E3D6);
            _whiteMap.Add("D7", E2D7);
            _whiteMap.Add("D8", E1D8);
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
            _blackMap.Add("E1", E1D8);
            _blackMap.Add("E2", E2D7);
            _blackMap.Add("E3", E3D6);
            _blackMap.Add("E4", E4D5);
            _blackMap.Add("E5", E5D4);
            _blackMap.Add("E6", E6D3);
            _blackMap.Add("E7", E7D2);
            _blackMap.Add("E8", E8D1);
        }

        private void CreateWhiteE()
        {
            _whiteMap.Add("E1", D8E1);
            _whiteMap.Add("E2", D7E2);
            _whiteMap.Add("E3", D6E3);
            _whiteMap.Add("E4", D5E4);
            _whiteMap.Add("E5", D4E5);
            _whiteMap.Add("E6", D3E6);
            _whiteMap.Add("E7", D2E7);
            _whiteMap.Add("E8", D1E8);
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
            _blackMap.Add("F1", F1C8);
            _blackMap.Add("F2", F2C7);
            _blackMap.Add("F3", F3C6);
            _blackMap.Add("F4", F4C5);
            _blackMap.Add("F5", F5C4);
            _blackMap.Add("F6", F6C3);
            _blackMap.Add("F7", F7C2);
            _blackMap.Add("F8", F8C1);
        }

        private void CreateWhiteF()
        {
            _whiteMap.Add("F1", C8F1);
            _whiteMap.Add("F2", C7F2);
            _whiteMap.Add("F3", C6F3);
            _whiteMap.Add("F4", C5F4);
            _whiteMap.Add("F5", C4F5);
            _whiteMap.Add("F6", C3F6);
            _whiteMap.Add("F7", C2F7);
            _whiteMap.Add("F8", C1F8);
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
            _blackMap.Add("G1", G1B8);
            _blackMap.Add("G2", G2B7);
            _blackMap.Add("G3", G3B6);
            _blackMap.Add("G4", G4B5);
            _blackMap.Add("G5", G5B4);
            _blackMap.Add("G6", G6B3);
            _blackMap.Add("G7", G7B2);
            _blackMap.Add("G8", G8B1);
        }

        private void CreateWhiteG()
        {
            _whiteMap.Add("G1", B8G1);
            _whiteMap.Add("G2", B7G2);
            _whiteMap.Add("G3", B6G3);
            _whiteMap.Add("G4", B5G4);
            _whiteMap.Add("G5", B4G5);
            _whiteMap.Add("G6", B3G6);
            _whiteMap.Add("G7", B2G7);
            _whiteMap.Add("G8", B1G8);
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
            _blackMap.Add("H1", H1A8);
            _blackMap.Add("H2", H2A7);
            _blackMap.Add("H3", H3A6);
            _blackMap.Add("H4", H4A5);
            _blackMap.Add("H5", H5A4);
            _blackMap.Add("H6", H6A3);
            _blackMap.Add("H7", H7A2);
            _blackMap.Add("H8", H8A1);
        }

        private void CreateWhiteH()
        {
            _whiteMap.Add("H1", A8H1);
            _whiteMap.Add("H2", A7H2);
            _whiteMap.Add("H3", A6H3);
            _whiteMap.Add("H4", A5H4);
            _whiteMap.Add("H5", A4H5);
            _whiteMap.Add("H6", A3H6);
            _whiteMap.Add("H7", A2H7);
            _whiteMap.Add("H8", A1H8);
        }
        #endregion
        #endregion

        public Position GetPosition(string namePosition)
        {
            switch (_playerColor)
            {
                case EFigureColor.Black:
                    return _blackMap[namePosition];
                case EFigureColor.White:
                    return _whiteMap[namePosition];
                default:
                    Debug.LogError($"{_playerColor} цвет отсутствует");
                    return null;
            }
        }

        public void MakeStep(string startPosition, string endPosition)
        {
            GameObject figure;

            switch (_playerColor)
            {
                case EFigureColor.Black:

                    figure = _blackMap[startPosition].GetFigure();

                    // Атака
                    if (_blackMap[endPosition].GetFigure())
                    {
                        _blackMap[startPosition].SetFigure(null);
                        _whiteMap[GetReflectedNamePosition(startPosition)].SetFigure(null);
                        _blackMap[endPosition].SetFigure(null);
                        _whiteMap[GetReflectedNamePosition(endPosition)].SetFigure(null);
                        _blackMap[endPosition].SetFigure(figure);
                        _whiteMap[GetReflectedNamePosition(endPosition)].SetFigure(figure);
                    }
                    // Передвижение
                    else
                    {
                        _blackMap[startPosition].SetFigure(null);
                        _whiteMap[GetReflectedNamePosition(startPosition)].SetFigure(null);
                        _blackMap[endPosition].SetFigure(figure);
                        _whiteMap[GetReflectedNamePosition(endPosition)].SetFigure(figure);
                    }

                    blackCamera.SetActive(false);
                    whiteCamera.SetActive(true);
                    _playerColor = EFigureColor.White;

                    break;

                case EFigureColor.White:

                    figure = _whiteMap[startPosition].GetFigure();

                    // Атака
                    if (_whiteMap[endPosition])
                    {
                        _whiteMap[startPosition].SetFigure(null);
                        _blackMap[GetReflectedNamePosition(startPosition)].SetFigure(null);
                        _whiteMap[endPosition].SetFigure(null);
                        _blackMap[GetReflectedNamePosition(endPosition)].SetFigure(null);
                        _whiteMap[endPosition].SetFigure(figure);
                        _blackMap[GetReflectedNamePosition(endPosition)].SetFigure(figure);
                    }
                    // Передвижение
                    else
                    {
                        _whiteMap[startPosition].SetFigure(null);
                        _blackMap[GetReflectedNamePosition(startPosition)].SetFigure(null);
                        _whiteMap[endPosition].SetFigure(figure);
                        _blackMap[GetReflectedNamePosition(endPosition)].SetFigure(figure);
                    }

                    blackCamera.SetActive(true);
                    whiteCamera.SetActive(false);
                    _playerColor = EFigureColor.Black;

                    break;
            }

            //Debug.Log($"{_playerColor}'s next move");
        }

        public EFigureColor GetPlayerColor()
        {
            return _playerColor;
        }

        /// <summary>
        /// Находит обратное название для чёрных/белых
        /// </summary>
        /// <param name="namePosition">Название позиции</param>
        /// <returns>Обратное название</returns>
        internal string GetReflectedNamePosition(string namePosition)
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
                if (numberPosition >= 1 && numberPosition <= 8)
                {
                    reflectedNamePosition += 9 - numberPosition;
                }
            }
            return reflectedNamePosition;
        }
    }
}

