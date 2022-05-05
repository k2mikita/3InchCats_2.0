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
        Debug.Log("a");
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
        gameObject.SendMessage("setLevel", "Bedroom");
        SceneManager.LoadScene("Tips From Flynn");
        
    }
    public void KitchenLevelButton()
    {
        gameObject.SendMessage("setLevel", "Kitchen");
        SceneManager.LoadScene("Crossbow_BigBear");

    }
    public void AtticLevelButton()
    {
        gameObject.SendMessage("setLevel", "Attic");
        SceneManager.LoadScene("Spinner_Boss");

    }
    public void BackyardLevelButton()
    {
        gameObject.SendMessage("setLevel", "Backyard");
        SceneManager.LoadScene("Cannon_Bomber");

    }



}
