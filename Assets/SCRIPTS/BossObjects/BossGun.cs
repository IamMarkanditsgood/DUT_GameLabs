using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossGun : MonoBehaviour
{
    [SerializeField] private float _ShootTime;
    private float _lastShootTime;
    [SerializeField] private LayerMask playerMask;
    [SerializeField] private GameObject Projectile;
    private void Update()
    {
        Ray2D ray = new Ray2D(transform.position, transform.right);
        Debug.DrawRay(ray.origin, ray.direction * 50);
        if (Time.time - _lastShootTime > _ShootTime && Physics2D.Raycast(ray.origin, ray.direction, 50f, playerMask))
        {
                _lastShootTime = Time.time;
                Attack();
        }
    }
    void Attack()
    {
        Instantiate(Projectile, transform.position, transform.rotation );
    }
}
