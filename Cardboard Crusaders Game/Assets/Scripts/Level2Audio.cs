using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level2Audio : MonoBehaviour
{
    public bool constBool = false;

   public float introTimer = 0.001f;

    void Start()
    {
        FindObjectOfType<AudioManager>().Stop("MenuLoop");
       // FindObjectOfType<AudioManager>().Play("Level1Intro");
        constBool = false;
    }
    // Update is called once per frame
    void Update()
    {
        introTimer -= Time.deltaTime;
        if (introTimer <= 0 && constBool == false)
        {
            Level2Loop();
            constBool = true;
        }
    }

    public void Level2Loop()
    {
        FindObjectOfType<AudioManager>().Play("Level2Loop");
    }
}
