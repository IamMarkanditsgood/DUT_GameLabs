using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Boss : MonoBehaviour
{
    [SerializeField] private float[] x;// Межі краще не трогати але якщо треба то це робити на сцені
    [SerializeField] private float[] y;
    Rigidbody2D rb;
    [SerializeField]private float speed;
    private Vector2 target;
    private bool NextTarget = true;
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }
    void Update()
    {
        if(NextTarget)
        {

            NextTarget = false;
            target = new Vector2(Random.Range(x[0], x[1]), Random.Range(y[0], y[1]));
   
        }
        else if(transform.position.x < (target.x + 1) && transform.position.x > (target.x - 1) && transform.position.y > (target.y -1) && transform.position.y < (target.y + 1))
        {
            NextTarget = true;
  
        }
        transform.position = Vector2.MoveTowards(transform.position, target, speed * Time.deltaTime);
        
    }

}
