using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpinnerShoot : MonoBehaviour
{
    //can't  find a function that only plays   the  sound  while  turret is  attacking

    // Update is called once per frame
    public void SpinShoot()
    {
        //int num = Random.Range(1, 8);
        //play collision sounds
        
            FindObjectOfType<AudioManager>().Play("FidgetSpinner1");
        
    }
    public void SpinShootStop()
    {
        //int num = Random.Range(1, 8);
        //play collision sounds

        FindObjectOfType<AudioManager>().Stop("FidgetSpinner1");

    }
}
