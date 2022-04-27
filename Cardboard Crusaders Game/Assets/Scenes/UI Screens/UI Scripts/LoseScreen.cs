using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoseScreen : MonoBehaviour
{
    private int prevSceneToLoad;
        

    private void Start()
    {
        Cursor.visible = true;
    }

    public void LoseMainMenuButton()
    {
        SceneManager.LoadScene("Main Menu");
        FindObjectOfType<AudioManager>().Stop("BedroomMusic");
    }

    public void LoseRetryMenuButton()
    {
        SceneManager.LoadScene("BedroomLevel V2");
        FindObjectOfType<AudioManager>().Stop("BedroomMusic");
    }

}
