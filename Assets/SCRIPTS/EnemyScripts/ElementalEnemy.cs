using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ElementalEnemy : MonoBehaviour
{
    [SerializeField] private float _ShootTime;
    private float _lastShootTime;
    [SerializeField] private LayerMask playerMask;
    [SerializeField] private GameObject Projectile;
    private void Update()
    {
        Ray2D ray = new Ray2D(transform.position, transform.right);
        Debug.DrawRay(ray.origin, ray.direction * 5);
        if (Physics2D.Raycast(ray.origin, ray.direction, 5f, playerMask))
        {
            enemy_run.NotAttacking = true;
            if (Time.time - _lastShootTime > _ShootTime)
            {
                _lastShootTime = Time.time;
                Attack();
            }
           
        }
        else
        {
            enemy_run.NotAttacking = false; 
        }
    }
    void Attack()
    {
        Instantiate(Projectile, transform.position,transform.rotation);
    }
}
