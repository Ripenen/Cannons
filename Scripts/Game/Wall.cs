using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    [SerializeField] private float MoveDistance = 0;
    [SerializeField] private float Speed = 0;
    public bool MovingXAxis;

    private Vector3 _target1;
    private Vector3 _target2;

    private bool firstMove;
    void Start()
    {
        if (MovingXAxis)
        {
            _target1 = transform.localPosition + new Vector3(MoveDistance, 0);
            _target2 = _target1 - new Vector3(MoveDistance * 2, 0);
        }
        else
        {
            _target1 = transform.localPosition + new Vector3(0, 0, MoveDistance);
            _target2 = _target1 - new Vector3(0, 0, MoveDistance * 2);
        }

        firstMove = true;

    }
    void Update()
    {
        if (transform.position == _target1)
        {
            firstMove = false;
        }
        if (transform.position == _target2)
        {
            firstMove = true;
        }

        if (firstMove)
        {
            transform.position = Vector3.MoveTowards(transform.position, _target1, Speed * Time.deltaTime);
        }
        else
        {
            transform.position = Vector3.MoveTowards(transform.position, _target2, Speed * Time.deltaTime);
        }

    }
}
