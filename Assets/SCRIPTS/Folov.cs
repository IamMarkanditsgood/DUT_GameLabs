using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Folov : MonoBehaviour
{
    public Transform who;
    Vector2 position;

    void Update()
    {
        position = who.position;
        transform.position = Vector2.Lerp(transform.position, position, 100f * Time.deltaTime);
    }
}
