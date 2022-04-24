using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level1Audio : MonoBehaviour
{
    public bool constBool = false;

    public float introTimer = 13.035f;

    void Start()
    {
        FindObjectOfType<AudioManager>().Play("Level1Intro");
        constBool = false;
    }
    // Update is called once per frame
    void Update()
    {
        introTimer -= Time.deltaTime;
        if (introTimer <= 0  && constBool == false)
        {
            Level1Loop();
            constBool = true;
        }
    }
    
    public void Level1Loop()
    {
        FindObjectOfType<AudioManager>().Play("Level1Loop");
    }
    
}
