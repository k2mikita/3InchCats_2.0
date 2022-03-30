using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ControlsMenu : MonoBehaviour
{
    void Start()
    {
       // FindObjectOfType<AudioManager>().Play("Space");
    }
    public void ControlsMenuBackButton()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 2);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();

    }

}
