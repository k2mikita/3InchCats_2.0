using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelSelectMenu : MonoBehaviour
{
    public GameObject buttonBed;
    public GameObject buttonKitchen;
    public GameObject buttonBackyard;
    public GameObject buttonAttic;
    void Start()
    {
        //FindObjectOfType<AudioManager>().Play("Space");

        if (LevelTracker.StatusBedroom())
        {
            buttonKitchen.SetActive(true);
        }
        if (LevelTracker.StatusKitchen())
        {
            buttonBackyard.SetActive(true);
        }
        if (LevelTracker.StatusBackyard())
        {
            buttonAttic.SetActive(true);
        }
        if (LevelTracker.StatusAttic())
        {
            //insert game end reward here
        }


    }
    public void LevelSelectBackButton()
    {
        SceneManager.LoadScene("Main Menu");
    }

    public void BedRoomLevelButton()
    {
        SceneManager.LoadScene("Tips From Flynn");
        
    }
    public void KitchenLevelButton()
    {
        SceneManager.LoadScene("Kitchen Level");

    }
    public void AtticLevelButton()
    {
        SceneManager.LoadScene("Attic");

    }
    public void BackyardLevelButton()
    {
        SceneManager.LoadScene("Backyard");

    }



}
