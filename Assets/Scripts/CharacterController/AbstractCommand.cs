using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class AbstractCommand
{
    protected Transform _transform;

    public AbstractCommand(Transform transform)
    {
        _transform = transform;
        if (!_transform.gameObject.GetComponent<CharacterState>())
        {
            _transform.gameObject.AddComponent<CharacterState>();
        }
    }

    public void OnFixedUpdate()
    {
        Command();
    }

    public abstract void Command();
}
