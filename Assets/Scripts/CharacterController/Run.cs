using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Run : AbstractCommand
{
    private Vector3 _newPosition;
    private float _moveSpeed;

    public Run(Transform transform, Vector3 newPosition, float speedMove) : base(transform)
    {
        _newPosition = newPosition;
        _moveSpeed = speedMove;
    }

    public override void Command()
    {
        if (!_transform.gameObject.GetComponent<CharacterState>().state.Equals(ECharacterState.Run))
        {
            if (_transform.position != _newPosition)
            {
                _transform.Translate(_transform.forward * _moveSpeed * Time.deltaTime);
            }
            else
            {
                _transform.gameObject.GetComponent<CharacterState>().state = ECharacterState.Idle;
            }
        }
    }
}
