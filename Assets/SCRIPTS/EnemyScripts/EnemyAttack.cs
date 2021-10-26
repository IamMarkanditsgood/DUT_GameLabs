using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyAttack : MonoBehaviour
{
    [SerializeField] private LayerMask _objectSelectionMask;
    [SerializeField] private float checkRadius;
    [SerializeField] private Transform groundCheck;
    Data hp;
    [SerializeField] private GameObject player;
    private void Start()
    {
        hp = player.GetComponent<Data>();
    }
    void Update()
    {
        
        if(Physics2D.OverlapCircle(groundCheck.position, checkRadius, _objectSelectionMask))
        {
            transform.Rotate(new Vector3(0, 0, 5000) * Time.deltaTime);
            hp.Hp.fillAmount -= 0.02f;
        }
    }
}
