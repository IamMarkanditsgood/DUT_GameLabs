using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FolowCam : MonoBehaviour
{
    public Transform who;
    Vector3 position;
    private void Start()
    {
       
    }
    void Update()
    {
        position = who.position;
        position.z = -10f;
 
        transform.position = Vector3.Lerp(transform.position, position, 1f * Time.deltaTime);
    }
}
