using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace DI
{
    public class LightManager : ILightManager
    {
        [Inject]
        public ISFXManager _sfxManager { get; private set; }

        public string Str { get; set; }

        public void TurnLightToggle()
        {
            var lights = GameObject.Find("Lights").GetComponentsInChildren<Light>();

            foreach (var currentLight in lights)
            {
                currentLight.enabled = !currentLight.enabled;
            }

            _sfxManager.GenerateSound("Lights Sound generated");
        }
    }
}
