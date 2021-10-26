using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spike : MonoBehaviour
{
    [SerializeField] private float _damageDelay;
    private float _lastDamageTime;
    private PlayerLB2 _player;
    private Data Mana_And_Hp;
    public GameObject Data_Object;
    private void Start()
    {  
        Mana_And_Hp = Data_Object.GetComponent<Data>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        PlayerLB2 player = other.GetComponent<PlayerLB2>();
        if (player != null)
        {
            _player = player;
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        PlayerLB2 player = other.GetComponent<PlayerLB2>();
        if (player == _player)
        {
            _player = null;
        }
    }

    private void Update()
    {
        if (_player != null && Time.time - _lastDamageTime > _damageDelay)
        {
            _lastDamageTime = Time.time;
            Mana_And_Hp.Hp.fillAmount -= 0.1f;
            Data.HP -= 10;
        }

     }
}