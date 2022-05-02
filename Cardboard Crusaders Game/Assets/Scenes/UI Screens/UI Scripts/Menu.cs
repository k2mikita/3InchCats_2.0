using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using System.IO;
using System;

public class Menu : MonoBehaviour
{
    void Start()
    {
        //FindObjectOfType<AudioManager>().Play("Space");
        WaveSpawner.EnemiesKilled = 0;


        //Load Save Data

        string path = Application.persistentDataPath + "/" + "levelData.txt";
        Debug.Log(path);
        string rawtext = "";

        if (System.IO.File.Exists(path))
        {
            //Load from Appdata

            StreamReader reader = new StreamReader(path);

            if (Convert.ToBoolean(reader.ReadLine()))
            {
                gameObject.SendMessage("winBedroom");
            }
            if (Convert.ToBoolean(reader.ReadLine()))
            {
                gameObject.SendMessage("winKitchen");
            }
            if (Convert.ToBoolean(reader.ReadLine()))
            {
                gameObject.SendMessage("winBackyard");
            }
            if (Convert.ToBoolean(reader.ReadLine()))
            {
                gameObject.SendMessage("winAttic");
            }

            reader.Close();

        }

            StreamWriter writer = new StreamWriter(path, false);
            if (LevelTracker.StatusBedroom())
            {
                writer.WriteLine("true");
            }
            else
            {
                writer.WriteLine("false");
            }
            if (LevelTracker.StatusKitchen())
            {
                writer.WriteLine("true");
            }
            else
            {
                writer.WriteLine("false");
            }
            if (LevelTracker.StatusBackyard())
            {
                writer.WriteLine("true");
            }
            else
            {
                writer.WriteLine("false");
            }
            if (LevelTracker.StatusAttic())
            {
                writer.WriteLine("true");
            }
            else
            {
                writer.WriteLine("false");
            }
            writer.Close();
        

    }

    public void PlayGame ()
    {
        SceneManager.LoadScene(9);
    }

    public void Settings()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 2);
    }

    public void Credits()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 3);
    }

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();

    }

}
