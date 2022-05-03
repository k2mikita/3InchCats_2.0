using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WalkSoundScript : MonoBehaviour
{
    

    // Start is called before the first frame update
    void Awake()
    {
        
    }

    // Update is called once per frame
    public void Step()
    {
        int num = Random.Range(1, 8);
        //play collision sounds
        if (num == 1)
        {
            FindObjectOfType<AudioManager>().Play("Step1");
        }
        if (num == 2)
        {
            FindObjectOfType<AudioManager>().Play("Step2");
        }
        if (num == 3)
        {
            FindObjectOfType<AudioManager>().Play("Step3");
        }
        if (num == 4)
        {
            FindObjectOfType<AudioManager>().Play("Step4");
        }
        if (num == 5)
        {
            FindObjectOfType<AudioManager>().Play("Step5");
        }
        if (num == 6)
        {
            FindObjectOfType<AudioManager>().Play("Step6");
        }
        if (num == 7)
        {
            FindObjectOfType<AudioManager>().Play("Step7");
        }
        if (num == 8)
        {
            FindObjectOfType<AudioManager>().Play("Step8");
        }
    }
}
