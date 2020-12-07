using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Bullet : MonoBehaviour
{
    public float Speed;
    public int Damage;
    [HideInInspector] public Vector3 Direction;
    [HideInInspector] public Player player;

    private void Update()
    {
        transform.Translate(new Vector3(Direction.x, 0, Direction.z) * Speed * Time.deltaTime);
    }
    private void OnCollisionEnter(Collision collision)
    {
        Destroy(gameObject);

        if(collision.collider.gameObject == player.gameObject)
        {
            player.ApplyDamage(Damage);
            Destroy(gameObject);
        }
    }
}
