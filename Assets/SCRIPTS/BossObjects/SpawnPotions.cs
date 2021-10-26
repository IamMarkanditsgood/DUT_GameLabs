using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnPotions : MonoBehaviour
{
    [SerializeField] private float[] x;// Межі краще не трогати але якщо треба то це робити на сцені
    [SerializeField] private float[] y;
    [SerializeField] private float _TimeForSpawn;
    private float _lastTime;
    [SerializeField] private GameObject[] HealsAndManaPotion;
    public static int NumberofPotions = 0;
    private Vector2 target;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (NumberofPotions <= 100 && Time.time - _lastTime > _TimeForSpawn)
        {
            _lastTime = Time.time;
            target = new Vector2(Random.Range(x[0], x[1]), Random.Range(y[0], y[1]));
            int i = Random.Range(0, 2);
            ++NumberofPotions;
            Instantiate(HealsAndManaPotion[i], target,Quaternion.Euler(0,0,0));
        }
    }
}
