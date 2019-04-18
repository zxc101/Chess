using UnityEngine;
using UnityEngine.UI;
using Zenject;

namespace DI
{
    public class TestDI : MonoBehaviour
    {
        private ILightManager _lightManager;
        private IGameManager _gameManager;

        [Inject]
        public void Setup(ILightManager lightManager, IGameManager gameManager)
        {
            _lightManager = lightManager;
            _gameManager = gameManager;
        }

        public void Clicker()
        {
            _gameManager.GameManagerStateChanged();
        }
    }
}
