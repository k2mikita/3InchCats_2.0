using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroySelfOverTime : MonoBehaviour
{
    // Start is called before the first frame update
    public float time = 5.0f;
    void Start()
    {
        Destroy(gameObject, time);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
