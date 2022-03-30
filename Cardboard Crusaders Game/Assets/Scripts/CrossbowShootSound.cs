using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrossbowShootSound : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void CrossbowShoot()
    {
        //int num = Random.Range(1, 8);
        //play collision sounds
            FindObjectOfType<AudioManager>().Play("Crossbow1");
        
        
    }
}
