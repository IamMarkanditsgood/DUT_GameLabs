using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enemy_run : MonoBehaviour
{
    public float speed;

    public int positionOfPatrol;
    public Transform point;
    bool moveingRight;
    bool chill = false;
    bool angry = false;
    bool goBack = false;
    public static bool NotAttacking = false;
    void Update()
    {

            if (Vector2.Distance(transform.position, point.position) < positionOfPatrol && angry == false)
            {
                chill = true;
            }

            if (chill == true && !NotAttacking)
            {
                Chill();
            }
            else if (goBack == true && !NotAttacking)
            {
                Goback();
            }
      
        
    }

    void Chill()
    {
        if (transform.position.x > point.position.x + positionOfPatrol)
        {
            moveingRight = false;
            transform.localRotation = Quaternion.Euler(0, 180, 0);
        }
        else if (transform.position.x < point.position.x - positionOfPatrol)
        {
            moveingRight = true;
            transform.localRotation = Quaternion.Euler(0, 0, 0);
        }

        if (moveingRight)
        {
            transform.position = new Vector2(transform.position.x + speed * Time.deltaTime, transform.position.y);
        }
        else
        {
            transform.position = new Vector2(transform.position.x - speed * Time.deltaTime, transform.position.y);
        }
    }
    void Goback()
    {
        transform.position = Vector2.MoveTowards(transform.position, point.position, speed * Time.deltaTime);
    }
}
