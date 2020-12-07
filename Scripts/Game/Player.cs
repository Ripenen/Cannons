using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Player : MonoBehaviour
{
    public int Health;
    public HealthBar HealthBar;
    public UnityEvent OnDead;
    public void ApplyDamage(int damage)
    {
        if(damage > Health)
        {
            Health = 0;
        }
        else
        {
            Health -= damage;

            HealthBar.Show();
        }

        if (Health == 0)
        {
            OnDead.Invoke();
        }
    }
}
