using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerStats : MonoBehaviour
{
    public static int Money;
    public int startMoney = 400;


    public static float Lives;
    public float startLives = 100;

    public static int Rounds;
    void Start()
    {
        Money = startMoney;
        Lives = startLives;

        Rounds = 0;
    }

    void Update()
    {
        if(Money <= 0)
        {
            Money = 0;
        }
        if (Lives <= 0)
        {
            Lives = 0;
            FindObjectOfType<GameManager>().EndGame();
        }
    }

}
