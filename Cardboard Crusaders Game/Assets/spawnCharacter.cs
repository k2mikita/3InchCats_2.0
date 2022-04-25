using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawnCharacter : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject KnightClass;
    public GameObject MageClass;
    void Start()
    {
        // string currentClass = "";

        string y = CurrentCharacter.getRole();
        Debug.Log(y);
        if (y == "Knight"){
            Instantiate(KnightClass, transform.position, transform.rotation);
        }
        else
        {
            Instantiate(MageClass, transform.position, transform.rotation);
        }
        Destroy(gameObject);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
