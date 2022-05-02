using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossAudio : MonoBehaviour
{
    public bool constBool = false;

    public float introTimer = 31.948f;

    void Start()
    {
        FindObjectOfType<AudioManager>().Stop("MenuLoop");
        FindObjectOfType<AudioManager>().Play("BossIntro");
        constBool = false;
    }
    // Update is called once per frame
    void Update()
    {
        introTimer -= Time.deltaTime;
        if (introTimer <= 0 && constBool == false)
        {
            BossLoop();
            constBool = true;
        }
    }

    public void BossLoop()
    {
        FindObjectOfType<AudioManager>().Play("BossLoop");
    }
}
