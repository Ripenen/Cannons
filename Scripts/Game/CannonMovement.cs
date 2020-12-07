using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonMovement : MonoBehaviour
{
    public float Distance;
    public float Speed;

    private Vector3[] _directions;
    private Vector3 _target;
    private int _direction;
    private bool _needMove;
    private Vector3 _center;

    private void Start()
    {
        _directions = new Vector3[]{ 
            new Vector3(Distance, 0, 0), 
            new Vector3(0, 0, Distance), 
            new Vector3(-Distance, 0, 0),
            new Vector3(0, 0, -Distance) };
        _center = transform.position;
        UpdateDirection();
    }

    private void Update()
    {
        if (_needMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target, Speed * Time.deltaTime);
        }
        if(transform.position == _target)
        {
            _target = _center;
        }
        if(transform.position == _center)
        {
            UpdateDirection();
        }
    }

    private void UpdateDirection()
    {
        _direction = Random.Range(0, _directions.Length);
        _target = transform.position + _directions[_direction];
        _needMove = true;
    }
}
