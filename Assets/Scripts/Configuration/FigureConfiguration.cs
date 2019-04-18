using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FigureConfiguration : MonoBehaviour
{
    [SerializeField] private EFigureColor _color;
    [SerializeField] private EFigureType _type;

    public EFigureColor GetColor()
    {
        return _color;
    }

    public EFigureType GetFigureType()
    {
        return _type;
    }
}
