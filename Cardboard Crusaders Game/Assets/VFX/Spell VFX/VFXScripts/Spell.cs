using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spell : MonoBehaviour
{
    public GameObject target;
    public GameObject spellVFX;

    public GameObject targetCircle;
    
    public Canvas spellCanvas;

    public GameObject MeteorDamage;

    // Start is called before the first frame update
    void Start()
    {

        //targetCircle.GetComponent<Image>().enabled = false;
        targetCircle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        GetInput();
    }

    void GetInput()
    {
        
        if (Input.GetMouseButtonDown(1))
        {
            SpellCircle();
        }


        if (Input.GetMouseButtonUp(1))
        {
            SpellCast();
        }
        
    }

    void SpellCircle()
    {
        
        targetCircle.SetActive(true);

    }

    void SpellCast()
    {
        Instantiate(spellVFX, target.transform.position, target.transform.rotation);
        Instantiate(MeteorDamage, target.transform.position, target.transform.rotation);
        targetCircle.SetActive(false);

    }    
}
