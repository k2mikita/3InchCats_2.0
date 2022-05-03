using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RangeCircle : MonoBehaviour
{
    public GameObject targetCircle;
    bool circle;
    
    // Start is called before the first frame update
    void Start()
    {
        targetCircle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if (circle)
        {
            targetCircle.SetActive(true);
            circle = false;
        }
        else
        {
            targetCircle.SetActive(false);
        }
    }

    void OnMouseOver()
    {
        if (Input.GetKey(KeyCode.LeftAlt))
        {

            //targetCircle.SetActive(true);
            if (gameObject.tag == "tower")
            {
                circle = true;


            }

        }
        //else
        //{
            //targetCircle.SetActive(false);
        //}


    }
}
