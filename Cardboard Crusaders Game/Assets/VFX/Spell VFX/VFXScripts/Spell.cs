using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Spell : MonoBehaviour
{
    public GameObject target;
    public GameObject spellVFX;

    public GameObject targetCircle;
    bool offcooldown = true;
    public Canvas spellCanvas;
    float cdtimer = 0;
    public GameObject MeteorDamage;
    public bool altDown;

    

    // Start is called before the first frame update
    void Start()
    {

        //targetCircle.GetComponent<Image>().enabled = false;
        targetCircle.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        

        if (Input.GetMouseButtonDown(1) && altDown == false)
        {
            SpellCircle();
        }


        if (Input.GetMouseButtonUp(1) && offcooldown && altDown == false)
        {
            Debug.Log("a");
            offcooldown = false;
            SpellCast();



            StartCoroutine(Sound());
        }

        CanShoot();
        

            


    }

    void CanShoot()
    {

        if (Input.GetKey(KeyCode.LeftAlt))
        {

            altDown = true;

        }
        else
        {
            altDown = false;
        }


    }

    void SpellCircle()
    {
        
        targetCircle.SetActive(true);

    }

    void SpellCast()
    {
        cdtimer = 20;
        StartCoroutine(Cooldown());
        Instantiate(spellVFX, target.transform.position, target.transform.rotation);
        Instantiate(MeteorDamage, target.transform.position, target.transform.rotation);
        targetCircle.SetActive(false);


        
    }    
    private IEnumerator Cooldown()
    {
        yield return new WaitForSeconds(10);

        offcooldown = true;
    }
    void OnGUI()
    {
        if (!offcooldown)
        {
            GUI.Label(new Rect(Screen.width - 100, Screen.height - 100, 100, 20), Math.Ceiling((cdtimer/2)).ToString());
            cdtimer -= Time.deltaTime;
        }
    }

    IEnumerator Sound()
    {
        yield return new WaitForSeconds(2);

        FindObjectOfType<AudioManager>().Play("PlayerMeteor");
    }
}
