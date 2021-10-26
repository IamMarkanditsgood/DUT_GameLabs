using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveBullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    Rigidbody2D rb;

    private void Start()
    {
        
        rb = GetComponent<Rigidbody2D>();
    }
   
    void FixedUpdate()
    {
        transform.position = transform.position + transform.right * _speed * Time.deltaTime;
    }
}
