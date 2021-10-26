using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossBullet : MonoBehaviour
{
    [SerializeField] private float _speed;
    private void FixedUpdate()
    {
        transform.position = transform.position + transform.right * _speed * Time.deltaTime;
    }
}
