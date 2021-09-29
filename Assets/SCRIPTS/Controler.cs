using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controler : MonoBehaviour
{
    public GameObject[] objects;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            for (int i = 0; i < 6; i++)
            {
                objects[i].SetActive(false);
            }
            objects[0].SetActive(true);

        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            for (int i = 0; i < 6; i++)
            {
                objects[i].SetActive(false);
            }
            objects[1].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            for (int i = 0; i < 6; i++)
            {
                objects[i].SetActive(false);
            }
            objects[2].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            for (int i = 0; i < 6; i++)
            {
                objects[i].SetActive(false);
            }
            objects[3].SetActive(true);
        }
        if (Input.GetKeyDown(KeyCode.Alpha5))
        {
            for (int i = 0; i < 6; i++)
            {
                objects[i].SetActive(false);
            }
            objects[4].SetActive(true);
        }

        if (Input.GetKeyDown(KeyCode.Alpha6))
        {
            for (int i = 0; i < 6; i++)
            {
                objects[i].SetActive(false);
            }
            objects[5].SetActive(true);
        }
    }
}
