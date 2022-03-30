using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CatapultShootSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void CatapultShoot()
    {
        int num = Random.Range(1, 3);
        //play collision sounds
        if (num == 1)
        {
            FindObjectOfType<AudioManager>().Play("Catapult1");
        }
        if (num == 2)
        {
            FindObjectOfType<AudioManager>().Play("Catapult2");
        }
        if (num == 3)
        {
            FindObjectOfType<AudioManager>().Play("Catapult3");
        }
        
    }
}
