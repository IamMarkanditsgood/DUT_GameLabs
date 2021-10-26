using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BossConfigeretion : MonoBehaviour
{
    public Image BossHp;
    void Start()
    { 
        BossHp.fillAmount = 1f;
    }
    void Update()
    {
        if (BossHp.fillAmount <= 0)
        {
            Destroy(gameObject);
        }
    }
    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "PlayerBullet" && BossHp.fillAmount> 0)
        {
            BossHp.fillAmount -= 0.1f;

            Destroy(collision.gameObject);
        }
        if (collision.gameObject.tag == "PlayerSword" && BossHp.fillAmount > 0)
        {
            BossHp.fillAmount -= 0.2f;
        }
    }

}
