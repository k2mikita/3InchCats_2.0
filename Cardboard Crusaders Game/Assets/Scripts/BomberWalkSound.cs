using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BomberWalkSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void BombStep()
    {
        int num = Random.Range(1, 2);
        //play collision sounds
        if (num == 1)
        {
            FindObjectOfType<AudioManager>().Play("BomberWalk1");
        }
        if (num == 2)
        {
            FindObjectOfType<AudioManager>().Play("BomberWalk2");
        }
        

    }
}
