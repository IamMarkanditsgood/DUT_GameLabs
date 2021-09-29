using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class UIElements : MonoBehaviour
{
    public Text scoreText;
    void Update()
    {
        scoreText.text = Data.coin.ToString();
    }
}
