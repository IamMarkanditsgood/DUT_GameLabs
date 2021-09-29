using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Skills : MonoBehaviour
{
    public static bool lightCheck = false;
  
    public GameObject Sword;
    public GameObject FonarikInHend;
    void Update()
    {
        OnLight();
    }
    private void OnLight()
    {
        if (Input.GetKeyDown(KeyCode.V) && Data.isLamp && !lightCheck)
        {
            print("fonarick good");
      
            Sword.SetActive(false);
            FonarikInHend.SetActive(true);
            lightCheck = true;
        }
        else if (Input.GetKeyDown(KeyCode.V) && Data.isLamp && lightCheck)
        {
         
            lightCheck = false;
            Sword.SetActive(true);
            FonarikInHend.SetActive(false);
        }
    }
}
