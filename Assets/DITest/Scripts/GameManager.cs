using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace DI
{
    public class GameManager : IGameManager
    {
        private ILightManager _lightManager;
        
        public GameManager(ILightManager lightManager)
        {
            _lightManager = lightManager;
        }

        public void GameManagerStateChanged()
        {
            _lightManager.TurnLightToggle();
            _lightManager.Str = "asd";
            Debug.Log(_lightManager.Str);
        }
    }
}
