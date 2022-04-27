using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fuzzclops_ANIM : MonoBehaviour
{
    private Animation walk;

    
    // Start is called before the first frame update
    void Start()
    {
        walk = gameObject.GetComponent<Animation>();
        walk.Play("TestFuzz");
        Debug.Log("anim start");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
