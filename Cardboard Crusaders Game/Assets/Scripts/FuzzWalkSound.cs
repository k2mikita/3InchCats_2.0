using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FuzzWalkSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void FuzzStep()
    {
        int num = Random.Range(1, 3);
        //play collision sounds
        if (num == 1)
        {
            FindObjectOfType<AudioManager>().Play("FuzzclopsWalk1");
        }
        if (num == 2)
        {
            FindObjectOfType<AudioManager>().Play("FuzzclopsWalk2");
        }
        if (num == 3)
        {
            FindObjectOfType<AudioManager>().Play("FuzzclopsWalk3");
        }
        
    }
}
