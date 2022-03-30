using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{
    void Start()
    {
        //FindObjectOfType<AudioManager>().Play("Space");
    }
    public void LevelSelectBackButton()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void BedRoomLevelButton()
    {
        SceneManager.LoadScene("Tips From Flynn");
        
    }

}
