using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MenuAudio : MonoBehaviour
{
    public float introTimer = 1f;

    public bool menuBool = false;

    void Awake()
    {
        float startTimer = 0.001f;
        startTimer -= Time.deltaTime;
        if (startTimer <= 0)
        {
            Debug.Log("help");
            //FindObjectOfType<AudioManager>().Play("MenuIntro");
            menuBool = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        FindObjectOfType<AudioManager>().Stop("Level1Loop");
        FindObjectOfType<AudioManager>().Stop("Level3Loop");
        FindObjectOfType<AudioManager>().Stop("Level2Loop");
        FindObjectOfType<AudioManager>().Stop("BossIntro");
        FindObjectOfType<AudioManager>().Stop("BossLoop");
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
