using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TakeItem : MonoBehaviour
{
    private bool nextItem = true;
    Data data;
    public GameObject data_script;
    void Start()
    {
        data = data_script.GetComponent<Data>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin" && nextItem )
        {
            ++Data.coin;
            print("Coin" + Data.coin);
            Destroy(other.gameObject);
            nextItem = false;
            StartCoroutine(Timer());
        }
        else if (other.gameObject.tag == "HP" && nextItem && Data.HP < 100)
        { 
            Data.HP += 20;
            print("HP" + Data.HP);
            Destroy(other.gameObject);
            data.Hp.fillAmount += 0.2f;
            SpawnPotions.NumberofPotions--;
            nextItem = false;
            StartCoroutine(Timer());
        }
        else if (other.gameObject.tag == "Mana" && nextItem && Data.Mana <100)
        {
            Data.Mana += 20;
            print("Mana" + Data.Mana);
            SpawnPotions.NumberofPotions--;
            Destroy(other.gameObject);
            data.ManaImagen.fillAmount += 0.2f;
            
            nextItem = false;
            StartCoroutine(Timer());
        }
        else if (data.SceneNumber == 1 && other.gameObject.tag == "Finish" && Data.coin > 0 && Data.HP > 50 && Data.Mana > 50)
        {
            Invoke("NextLevel", 1);
        }
        else if (data.SceneNumber != 1 && other.gameObject.tag == "Finish" )
        {
            Invoke("NextLevel", 1);
        }
        if (Data.HP > 100)
        {
            Data.HP = 100;
            print(Data.HP);
        }
        if (Data.Mana > 100)
        {
            Data.Mana = 100;
        }
    }
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "chest")
        {
            Data.isLamp = true;
        }
    }
    IEnumerator Timer()
    {
        yield return new WaitForSeconds(0.2f);
        nextItem = true;
    }
    void NextLevel()
    {
        SceneManager.LoadScene(data.SceneNumber+1, LoadSceneMode.Single);
    }
}
