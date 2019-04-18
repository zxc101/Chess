using System.Collections.Generic;
using UnityEngine;

namespace Chess.UpdateControllers
{
    public class UpdateController : MonoBehaviour
    {
        private readonly List<IUpdate> _UpdatesList = new List<IUpdate>();

        internal void AddFixedUpdate(IUpdate update)
        {
            _UpdatesList.Add(update);
        }

        private void FixedUpdate()
        {
            foreach (IUpdate update in _UpdatesList)
            {
                update.OnUpdate();
            }
        }
    }
}
