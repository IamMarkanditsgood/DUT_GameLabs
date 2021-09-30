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
        mana_and_hp.Hp.fillAmount = 0.5f;
        mana_and_hp.ManaImagen.fillAmount = 0.5f;
        time_for_hp = 0;
    }
    void Update()
    {
        time_for_hp = time_for_hp + Time.deltaTime;
        if (mana_and_hp.Hp.fillAmount <= 0)
        {
            Data.Death = true;
             
        }
        else if (time_for_hp >= 5)
        {
            
            mana_and_hp.Hp.fillAmount += 0.02f;
            time_for_hp = 0;
        }
        if(Data.Death)
        {
            Invoke("Dead", 1f);
        }
    }
    public void Dead()
    {

        Time.timeScale = 0;
    }
}
