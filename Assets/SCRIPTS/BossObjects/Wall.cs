using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    // Start is called before the first frame update
    void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == " Projectile")
        {
            
            Destroy(collider.gameObject);
        }
    }
}
