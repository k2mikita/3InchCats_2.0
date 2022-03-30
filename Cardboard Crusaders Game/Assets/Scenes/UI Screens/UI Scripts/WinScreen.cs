using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinScreen : MonoBehaviour
{
    private void Start()
    {
        Cursor.visible = true;
    }

    public void WinMainMenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 7);
        FindObjectOfType<AudioManager>().Stop("BedroomMusic");
    }

    public void WinRetryMenuButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 3);
        FindObjectOfType<AudioManager>().Stop("BedroomMusic");
    }

}
