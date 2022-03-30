using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CannonShootSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void CannonShoot()
    {
        int num = Random.Range(1, 4);
        //play collision sounds
        if (num == 1)
        {
            FindObjectOfType<AudioManager>().Play("Cannon1");
        }
        if (num == 2)
        {
            FindObjectOfType<AudioManager>().Play("Cannon2");
        }
        if (num == 3)
        {
            FindObjectOfType<AudioManager>().Play("Cannon3");
        }
        if (num == 4)
        {
            FindObjectOfType<AudioManager>().Play("Cannon4");
        }
        
    }
}
