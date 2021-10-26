using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class Data : MonoBehaviour
{
    public static float speed = 5;
    public static int Character = 1;
    public static int JumpForce = 5;
    public static int coin = 0;
    public static int HP = 50;
    public static int Mana = 50;
    public static bool isLamp = false;
    public Image Hp, ManaImagen;
    public static bool Death = false;
    public int SceneNumber = -1;
    private string SceneString;
    private void Start()
    {
        SceneNumber = SceneManager.GetActiveScene().buildIndex;
        SceneString = SceneManager.GetActiveScene().name;
        if (SceneString == "LB4")
        {
            JumpForce = 15;
        }
    }


}
