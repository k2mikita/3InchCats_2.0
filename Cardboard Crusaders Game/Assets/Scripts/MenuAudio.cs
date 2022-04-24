using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAudio : MonoBehaviour
{
    public float introTimer = 13.035f;

    public bool menuBool = false;

    void Awake()
    {
        Debug.Log("help");
        FindObjectOfType<AudioManager>().Play("MenuIntro");
        menuBool = false;
    }

    // Update is called once per frame
    void Update()
    {
        FindObjectOfType<AudioManager>().Stop("Level1Loop");
        FindObjectOfType<AudioManager>().Stop("Level1Intro");
        //FindObjectOfType<AudioManager>().Stop("ConstructionLoop");
        //FindObjectOfType<AudioManager>().Stop("ConstructionIntro");
        introTimer -= Time.deltaTime;
        if (introTimer <= 0 && menuBool == false)
        {
            FindObjectOfType<AudioManager>().Play("MenuLoop");
            menuBool = true;
        }
    }
}
