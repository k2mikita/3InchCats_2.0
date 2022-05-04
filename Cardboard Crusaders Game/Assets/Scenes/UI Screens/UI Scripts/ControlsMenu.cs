using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;

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

    public void GameInfo()
    {
        SceneManager.LoadScene("Game Info");

    }

    public void DeleteSaveData()
    {
        gameObject.SendMessage("resetData");
        string path = Application.persistentDataPath + "/" + "levelData.txt";
        StreamWriter writer = new StreamWriter(path, false);

            writer.WriteLine("false");
        writer.WriteLine("false");
        writer.WriteLine("false");
        writer.WriteLine("false");

        writer.Close();
    }

}
