using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameInfo : MonoBehaviour
{
    void Start()
    {
        
    }
    public void GameInfoBackButton()
    {
        SceneManager.LoadScene("Settings & Controls");
    }
}
