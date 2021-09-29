using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerLB2 : MonoBehaviour
{
    Rigidbody2D rb;

    void Start()
    {

        rb = GetComponent<Rigidbody2D>();
    }
    private void FixedUpdate()
    {
        if (Input.GetAxis("Horizontal") < 0)
        {

            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }
        else if (Input.GetAxis("Horizontal") > 0)
        {

            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }

        rb.velocity = new Vector2(Input.GetAxis("Horizontal") * Data.speed, rb.velocity.y);

    }
}
