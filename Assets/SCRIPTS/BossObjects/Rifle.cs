using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rifle : MonoBehaviour
{
    [SerializeField] private GameObject Bullet;
    private float _BeforeTime;
    private float _NextTime = 2;

    private void Start()
    {
        _BeforeTime = Time.time;
    }
    private void Update()
    {
    
        if (Time.time - _BeforeTime > _NextTime)
        {
            _BeforeTime = Time.time;
            Instantiate(Bullet, transform.position, transform.rotation);

        }
    }
}
