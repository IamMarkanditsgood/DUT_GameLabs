using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Configuration : MonoBehaviour
{
    private float time_for_hp;
    Data mana_and_hp;
    public GameObject data_script;

    void Start()
    {
        mana_and_hp = data_script.GetComponent<Data>();
        mana_and_hp.Hp.fillAmount = 0.8f;
        mana_and_hp.ManaImagen.fillAmount = 0.8f;
        time_for_hp = 0;
        Data.HP = 80;
        Data.Mana = 80;
    }
    void Update()
    {
        time_for_hp = time_for_hp + Time.deltaTime;
        if (mana_and_hp.Hp.fillAmount <= 0)
        {
            Data.Death = true;
            Invoke("Dead", 1f);
        }
        else if (time_for_hp >= 5)
        {    
            mana_and_hp.Hp.fillAmount += 0.02f;
            time_for_hp = 0;
        }
        
    }
    public void Dead()
    {
        Time.timeScale = 0;
    }
    void OnTriggerEnter2D(Collider2D collider)
    {
        if(collider.gameObject.tag == " Projectile")
        {
            mana_and_hp.Hp.fillAmount -= 0.1f;
            Data.HP -= 10;
            Destroy(collider.gameObject);
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "RiflesProjectile")
        {
            
            mana_and_hp.Hp.fillAmount -= 0.1f;
            Data.HP -= 10;
        }
    }
}
