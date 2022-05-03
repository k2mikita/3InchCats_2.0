using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonSound : MonoBehaviour
{
    

    public void ClickSound()
    {
        int num = Random.Range(1, 2);
        //play collision sounds
        if (num == 1)
        {
            FindObjectOfType<AudioManager>().Play("Button1");
        }
        if (num == 2)
        {
            FindObjectOfType<AudioManager>().Play("Button2");
        }
        
    }
}
