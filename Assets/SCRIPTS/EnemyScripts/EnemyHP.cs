using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EnemyHP : MonoBehaviour
{
    [SerializeField] private int HP;
    [SerializeField] private GameObject HpBar;
    Vector3 Scale;
    [SerializeField] private float TakeDamage = 10f;
    void Start()
    {
        HP = 100;
    }
    void Update()
    {
        if(HP <= 0)
        {
            Destroy(gameObject);
        }
    }
   public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet" && HP >0 )
        {
            HP -= 10;
            Scale = new Vector3(TakeDamage * 0.01f, 0,0);
            HpBar.transform.localScale -= Scale;
            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "PlayerSword" && HP > 0 && AnimationController.CanTackeSwordDamage)
        {
            HP -= 20;
            Scale = new Vector3(TakeDamage*2 * 0.01f, 0, 0);
            HpBar.transform.localScale -= Scale;
        }
    }
}
