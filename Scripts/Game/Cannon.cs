using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cannon : MonoBehaviour
{
    public GameObject Bullet;
    public float RechargeTime;
    private Player _player;
    private Vector3 _direction;
    private bool _isRecharge;

    private void Start()
    {
        _player = FindObjectOfType<Player>();
    }
    private void FixedUpdate()
    {
        _direction = _player.transform.position - transform.position;

        Physics.Raycast(transform.position, _direction, out RaycastHit hit);

        if(hit.collider.gameObject == _player.gameObject)
        {
            if(_isRecharge == false)
            {
                StartCoroutine(Shoot());
                _isRecharge = true;
            }
        }
    }

    private IEnumerator Shoot()
    {
        Bullet _bullet = Instantiate(Bullet, transform.position + new Vector3(0, 2.5f), Quaternion.identity).GetComponent<Bullet>();
        _bullet.Direction = _direction;
        _bullet.player = _player;

        yield return new WaitForSecondsRealtime(RechargeTime);

        _isRecharge = false;
        StopCoroutine(Shoot());
    }
}
