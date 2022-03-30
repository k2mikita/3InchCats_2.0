using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwordSwingSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Swing()
    {
        int num = Random.Range(1, 4);
        //play collision sounds
        if (num == 1)
        {
            FindObjectOfType<AudioManager>().Play("SwordSwing1");
        }
        if (num == 2)
        {
            FindObjectOfType<AudioManager>().Play("SwordSwing2");
        }
        if (num == 3)
        {
            FindObjectOfType<AudioManager>().Play("SwordSwing3");
        }
        if (num == 4)
        {
            FindObjectOfType<AudioManager>().Play("SwordSwing4");
        }
        
    }
}
