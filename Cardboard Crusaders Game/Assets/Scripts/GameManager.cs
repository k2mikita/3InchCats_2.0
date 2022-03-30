using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    bool gameHasEnded = false;
    bool gameHasWon = false;
    public static int EnemiesAlive;
    public static int EnemiesKilled;
    void Start()
    {
        FindObjectOfType<AudioManager>().Play("BedroomMusic");
        FindObjectOfType<AudioManager>().Stop("Space");
        gameHasEnded = false;
        gameHasWon = false;
    }
    
    
    public void EndGame()
    {
        if(gameHasEnded == false)
        {
            EnemiesKilled = 0;
            EnemiesAlive = 0;
            gameHasEnded = true;
            SceneManager.LoadScene("Lose Screen");
        }
        
    }

    public void GameWin()
    {
        
        if (gameHasWon == false)
        {
            EnemiesKilled = 0;
            EnemiesAlive = 0;
            gameHasWon = true;
            SceneManager.LoadScene("Win Screen");
        }
        
    }
   
}
