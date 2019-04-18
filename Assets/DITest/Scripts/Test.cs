using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace DI
{
    public class Test : MonoBehaviour
    {
        [Inject]
        private ISFXManager sfxManager;

        void Start()
        {
            sfxManager.GenerateSound("Lindsy Stirling");
        }
    }
}
