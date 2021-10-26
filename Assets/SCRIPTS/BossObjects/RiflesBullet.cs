using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RiflesBullet : MonoBehaviour
{
    private float _speed = 10;
    Rigidbody2D rb;

    private float _DestroyDelay = 6;
    private float _lastDeleyTime;


    private void Start()
    {
        _lastDeleyTime = Time.time;
        rb = GetComponent<Rigidbody2D>();
    }
    
    void FixedUpdate()
    {
        if (Time.time - _lastDeleyTime > _DestroyDelay)
        {
            _lastDeleyTime = Time.time;
            Destroy(gameObject);
        }
        transform.position = transform.position + transform.right * _speed * Time.deltaTime;
    }
}
