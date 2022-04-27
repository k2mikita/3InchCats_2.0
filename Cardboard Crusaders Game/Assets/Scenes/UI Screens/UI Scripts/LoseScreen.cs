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
        FindObjectOfType<AudioManager>().Stop("BedroomMusic");
        SceneManager.LoadScene("Main Menu");
        
    }

    public void LoseRetryMenuButton()
    {
        FindObjectOfType<AudioManager>().Stop("BedroomMusic");
        if(LevelTracker.checkLevel() == "Bedroom")
        {
            SceneManager.LoadScene("BedroomLevel V2");
        }
        else if (LevelTracker.checkLevel() == "Attic")
        {
            SceneManager.LoadScene("Attic Level");
        }
        else if (LevelTracker.checkLevel() == "Kitchen")
        {
            SceneManager.LoadScene("Kitchen Level");
        }
        else if (LevelTracker.checkLevel() == "Backyard")
        {
            SceneManager.LoadScene("Backyard");
        }
        else
        {
            SceneManager.LoadScene("BedroomLevel V2");
        }




    }

}
