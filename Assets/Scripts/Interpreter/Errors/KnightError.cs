﻿using System.Collections.Generic;
using UnityEngine;

using Chess.Configuration;
using Chess.Enums;

namespace Chess.Errors
{
    public class KnightError : AbstractFigureError
    {
        private const int STEP = 10;

        internal KnightError(Position startPosition, Position endPosition) : base(startPosition, endPosition)
        {
            ErrorMove();
        }

        internal override List<string> GetError() => Errors;

        protected override void ErrorMove()
        {
            if (
                (Mathf.Abs(startPos.x - endPos.x) == STEP * 2 && Mathf.Abs(startPos.z - endPos.z) == STEP) ||
                (Mathf.Abs(startPos.x - endPos.x) == STEP && Mathf.Abs(startPos.z - endPos.z) == STEP * 2)
               )
            {
                if (startColor == endColor)
                {
                    switch (endTepe)
                    {
                        case EFigureType.Bishop:
                            Errors.Add($"{name} отказывается атаковать своего слона");
                            break;
                        case EFigureType.King:
                            Errors.Add($"{name} отказывается атаковать своего хозяина");
                            break;
                        case EFigureType.Knight:
                            Errors.Add($"{name} отказывается атаковать своего коня");
                            break;
                        case EFigureType.Pown:
                            Errors.Add($"{name} отказывается атаковать свою пешку");
                            break;
                        case EFigureType.Queen:
                            Errors.Add($"{name} отказывается атаковать свою хозяику");
                            break;
                        case EFigureType.Rock:
                            Errors.Add($"{name} отказывается атаковать свою ладью");
                            break;
                    }
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