using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJoystick : MonoBehaviour
{
    public float Speed;
    public FixedJoystick Joystick;
    public GameObject Player;

    private Vector3 _direction;

    private void FixedUpdate()
    {
        _direction = Vector3.forward * Joystick.Vertical + Vector3.right * Joystick.Horizontal;
        Player.transform.Translate(_direction * Speed * Time.fixedDeltaTime);
    }
}
