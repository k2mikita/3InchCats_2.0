using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShieldVFX : MonoBehaviour
{
    public GameObject target;
    public GameObject spellVFX;

    public bool canBlock;

    // Start is called before the first frame update
    void Start()
    {
        canBlock = true;
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    void GetInput()
    {

        if (Input.GetKeyDown("left alt"))
        {
            canBlock = false;
        }
        if (Input.GetKeyUp("left alt"))
        {
            canBlock = true;
        }
        if (Input.GetMouseButtonDown(1) && canBlock == true)
        {
            SpellCast();
        }

    }


    void SpellCast()
    {
        Instantiate(spellVFX, target.transform.position, target.transform.rotation);
       
    }
}
