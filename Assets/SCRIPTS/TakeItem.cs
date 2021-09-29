using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class TakeItem : MonoBehaviour
{
    private bool nextItem = true;
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Coin" && nextItem && Data.coin <= 100)
        {
            ++Data.coin;
            print("Coin" + Data.coin);
            Destroy(other.gameObject);
            nextItem = false;
            StartCoroutine(Timer());
        }
        else if (other.gameObject.tag == "HP" && nextItem && Data.HP <= 100)
        {
            Data.HP += 2;
            print("HP" + Data.HP);
            Destroy(other.gameObject);
            nextItem = false;
            StartCoroutine(Timer());
        }
        else if (other.gameObject.tag == "Mana" && nextItem && Data.Mana <=100)
        {
            Data.Mana += 2;
            print("Mana" + Data.Mana);
            Destroy(other.gameObject);
            nextItem = false;
            StartCoroutine(Timer());
        }
        else if (other.gameObject.tag == "Finish" && Data.coin > 0 && Data.HP == 100 && Data.Mana == 100)
        {
            Invoke("NextLevel", 1);
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
        yield return new WaitForSeconds(0.1f);
        nextItem = true;
    }
    void NextLevel()
    {
        SceneManager.LoadScene(2, LoadSceneMode.Single);
    }
}
