using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FixedUpdateController : MonoBehaviour
{
    private readonly List<IFixedUpdate> _fixedUpdatesList = new List<IFixedUpdate>();

    public void AddFixedUpdate(IFixedUpdate fixedUpdate)
    {
        _fixedUpdatesList.Add(fixedUpdate);
    }

    private void FixedUpdate()
    {
        foreach (IFixedUpdate fixedUpdate in _fixedUpdatesList)
        {
            fixedUpdate.OnFixedUpdate();
        }
    }
}
