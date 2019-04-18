using UnityEngine;

using Chess.Enums;

namespace Chess.Configuration
{
    public class FigureConfiguration : MonoBehaviour
    {
        [SerializeField] private EFigureColor _color;
        [SerializeField] private EFigureType _type;

        internal EFigureColor GetColor()
        {
            return _color;
        }

        internal EFigureType GetType()
        {
            return _type;
        }
    }
}
