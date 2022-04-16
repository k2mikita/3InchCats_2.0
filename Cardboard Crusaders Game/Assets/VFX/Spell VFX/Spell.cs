using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spell : MonoBehaviour
{
    public GameObject AOE;
    public GameObject spellVFX;

    public Image targetCircle;
    public Image indicatorRangeCircle;
    public Canvas ability2Canvas;

    // Start is called before the first frame update
    void Start()
    {
        targetCircle.GetComponent<Image>().enabled = false;
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


        if (Input.GetMouseButtonDown(0))
        {
            SpellCast();
        }
        
    }

    void SpellCircle()
    {
        indicatorRangeCircle.GetComponent<Image>().enabled = true;
        targetCircle.GetComponent<Image>().enabled = true;

    }

    void SpellCast()
    {
        Instantiate(spellVFX,AOE.transform.position,AOE.transform.rotation);
        indicatorRangeCircle.GetComponent<Image>().enabled = false;
        targetCircle.GetComponent<Image>().enabled = false;
    }
}
