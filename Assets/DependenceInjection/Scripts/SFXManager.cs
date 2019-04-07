using UnityEngine;

namespace DI
{
    public class SFXManager : ISFXManager
    {
        public void GenerateSound(string soundName)
        {
            Debug.Log("Playing Sound: " + soundName);
        }
    }
}
