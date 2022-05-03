using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeddyBearWalkSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    public void BearStep()
    {
        int num = Random.Range(1, 4);
        //play collision sounds
        if (num == 1)
        {
            FindObjectOfType<AudioManager>().Play("BearWalk1");
        }
        if (num == 2)
        {
            FindObjectOfType<AudioManager>().Play("BearWalk2");
        }
        if (num == 3)
        {
            FindObjectOfType<AudioManager>().Play("BearWalk3");
        }
        if (num == 4)
        {
            FindObjectOfType<AudioManager>().Play("BearWalk3");
        }

    }
    public void BearStepStop()
    {

        FindObjectOfType<AudioManager>().Stop("BearWalk1");

        FindObjectOfType<AudioManager>().Stop("BearWalk2");

        FindObjectOfType<AudioManager>().Stop("BearWalk3");

        FindObjectOfType<AudioManager>().Stop("BearWalk3");
    }
}
