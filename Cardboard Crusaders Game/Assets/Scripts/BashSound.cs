using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BashSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void Bash()
    {
        int num = Random.Range(1, 6);
        //play collision sounds
        if (num == 1)
        {
            FindObjectOfType<AudioManager>().Play("ShieldBash1");
        }
        if (num == 2)
        {
            FindObjectOfType<AudioManager>().Play("ShieldBash2");
        }
        if (num == 3)
        {
            FindObjectOfType<AudioManager>().Play("ShieldBash3");
        }
        if (num == 4)
        {
            FindObjectOfType<AudioManager>().Play("ShieldBash4");
        }
        if (num == 5)
        {
            FindObjectOfType<AudioManager>().Play("ShieldBash5");
        }
        if (num == 6)
        {
            FindObjectOfType<AudioManager>().Play("ShieldBash6");
        }
        
        
    }
}
