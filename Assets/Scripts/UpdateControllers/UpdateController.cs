using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UpdateController : MonoBehaviour
{
    private readonly List<IUpdate> _UpdatesList = new List<IUpdate>();

    public void AddFixedUpdate(IUpdate update)
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
