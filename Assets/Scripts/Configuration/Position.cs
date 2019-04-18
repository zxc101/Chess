using UnityEngine;

using Chess.Enums;

namespace Chess.Configuration
{
    public class Position : MonoBehaviour
    {
        [SerializeField] private GameObject _figure;
        private Vector3 position;

        internal GameObject GetFigure()
        {
            return _figure;
        }

        internal void SetFigure(GameObject newFigure)
        {
            if (newFigure)
            {
                if (_figure)
                {
                    if (newFigure == _figure)
                        _figure = GameObject.Find(newFigure.name);
                }
                else
                {
                    _figure = Instantiate(newFigure, transform.position, Quaternion.identity);
                    _figure.name = newFigure.name;

                    if (_figure.GetComponentInChildren<Light>())
                        _figure.GetComponentInChildren<Light>().enabled = true;

                    if (_figure.GetComponent<FigureConfiguration>().GetColor() == EFigureColor.Black)
                    {
                        _figure.transform.rotation = Quaternion.Euler(0, 180, 0);
                    }
                }
            }
            else
            {
                if (_figure)
                {
                    Destroy(_figure);
                    _figure = null;
                }
            }
        }

        private void OnValidate()
        {
            position = transform.position;
        }

        internal Vector3 GetPosition()
        {
            return position;
        }
    }
}
