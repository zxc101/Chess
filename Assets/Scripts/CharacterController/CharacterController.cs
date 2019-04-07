using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterController : MonoBehaviour, IFixedUpdate
{
    [SerializeField] private float _moveSpeed = 10;
    [SerializeField] private float _distance = 4;
    
    private Vector3 _newPosition;
    private ECharacterState _characterState;
    private EDirectionState _directionState;

    private void Start()
    {
        FindObjectOfType<FixedUpdateController>()?.AddFixedUpdate(this);
        
        _newPosition = transform.position;

        _characterState = ECharacterState.Idle;
    }

    public void OnFixedUpdate()
    {
        if (_characterState == ECharacterState.Idle)
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                _characterState = ECharacterState.Run;
                _newPosition += Vector3.forward * _distance;
                _directionState = EDirectionState.Forward;
            }
            else if (Input.GetKeyDown(KeyCode.S))
            {
                _characterState = ECharacterState.Run;
                _newPosition += Vector3.back * _distance;
                _directionState = EDirectionState.Back;
            }
            else if (Input.GetKeyDown(KeyCode.D))
            {
                _characterState = ECharacterState.Run;
                _newPosition += Vector3.right * _distance;
                _directionState = EDirectionState.Right;
            }
            else if (Input.GetKeyDown(KeyCode.A))
            {
                _characterState = ECharacterState.Run;
                _newPosition += Vector3.left * _distance;
                _directionState = EDirectionState.Left;
            }
        }

        switch (_characterState)
        {
            case ECharacterState.Idle:
                break;
            case ECharacterState.Run:
                Run(_directionState, _moveSpeed);
                break;
        }
    }
    
    private void Run(EDirectionState direction, float speed)
    {
        switch (direction)
        {
            case EDirectionState.Forward:
                transform.Translate(transform.forward * speed * Time.deltaTime);
                break;
            case EDirectionState.Back:
                transform.Translate(-transform.forward * speed * Time.deltaTime);
                break;
            case EDirectionState.Right:
                transform.Translate(transform.right * speed * Time.deltaTime);
                break;
            case EDirectionState.Left:
                transform.Translate(-transform.right * speed * Time.deltaTime);
                break;
        }

        if (transform.position == _newPosition)
        {
            _characterState = ECharacterState.Idle;
        }
    }
}
