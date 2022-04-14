using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RaycastRecieve : MonoBehaviour
{
    bool outline;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (outline)
        {
            gameObject.GetComponent<Outline>().enabled = true;
            outline = false;
        }
        else
        {
            gameObject.GetComponent<Outline>().enabled = false;
        }
    }
    void toggleOutline()
    {
        
    }
    void OnMouseOver()
    {
        if (Input.GetKey(KeyCode.LeftAlt))
        {
            if (!outline)
            {
                outline = true;
            }
        }

    }
}
