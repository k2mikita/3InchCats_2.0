using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SpellDragon : MonoBehaviour
{
    public GameObject AOE1;
    public GameObject AOE2;
    public GameObject AOE3;
    public GameObject AOE4;
    public GameObject AOE5;
    
    public GameObject spellVFX;

    

    public GameObject targetCircle;

    public Canvas DragonFireCanvas;
    
    public float nextCastTime = 5.0f;
    public float cast = 10.0f;

    public int randomAOE = 0;

    public bool canCast;
    
  

    // Start is called before the first frame update
    void Start()
    {
        
        randomAOE = Random.Range(1, 6);
        Debug.Log("Lucky Number is " + randomAOE);

        canCast = true;

    }

    // Update is called once per frame
    void Update()
    {

        if(Time.time > nextCastTime)
        {
            
            nextCastTime = Time.time + cast;
            

            if (randomAOE == 1 && canCast == true)
            {

                Instantiate(targetCircle, AOE1.transform.position, AOE1.transform.rotation);
                Debug.Log("spell circle 1 activated");

                Invoke("SpellCast1", 5);
                Debug.Log("Sent to caster 1");
                
                canCast = false;
                Debug.Log("canCast = false");

                return; 
            }
            if (randomAOE == 2 && canCast == true)
            {
                
                Instantiate(targetCircle, AOE2.transform.position, AOE2.transform.rotation);
                Debug.Log("spell circle 2 activated");

                Invoke("SpellCast2", 5);
                Debug.Log("Sent to caster 2");

                canCast = false;
                Debug.Log("canCast = false");
                
                return;
            }
            if (randomAOE == 3 && canCast == true)
            {
                
                Instantiate(targetCircle, AOE3.transform.position, AOE3.transform.rotation);
                Debug.Log("spell circle 3 activated");

                Invoke("SpellCast3", 5);
                Debug.Log("Sent to caster 3");

                canCast = false;
                Debug.Log("canCast = false");

                return;
            }
            if (randomAOE == 4 && canCast == true)
            {
                
                Instantiate(targetCircle, AOE4.transform.position, AOE4.transform.rotation);
                Debug.Log("spell circle 4 activated");

                Invoke("SpellCast4", 5);
                Debug.Log("Sent to caster 4");

                canCast = false;
                Debug.Log("canCast = false");

                return;
            }
            if (randomAOE == 5 && canCast == true)
            {
                
                Instantiate(targetCircle, AOE5.transform.position, AOE5.transform.rotation);
                Debug.Log("spell circle 5 activated");

                Invoke("SpellCast5", 5);
                Debug.Log("Sent to caster 5");

                canCast = false;
                Debug.Log("canCast = false");

                return;
            }

            return;

        }

    }


    void SpellCast1()
    {
        Debug.Log("Dragon FIRE 1 !!!");
        
        Instantiate(spellVFX, AOE1.transform.position, AOE1.transform.rotation);

        targetCircle.SetActive(true);

        Invoke("Randomizer", 15);

    }

    void SpellCast2()
    {
        Debug.Log("Dragon FIRE 2 !!!");

        Instantiate(spellVFX, AOE2.transform.position, AOE2.transform.rotation);
        
        targetCircle.SetActive(true);

        Invoke("Randomizer", 15);

    }

    void SpellCast3()
    {
        Debug.Log("Dragon FIRE 3 !!!");

        Instantiate(spellVFX, AOE3.transform.position, AOE3.transform.rotation);

        targetCircle.SetActive(true);

        Invoke("Randomizer", 15);
    }
    void SpellCast4()
    {
        Debug.Log("Dragon FIRE 4 !!!");

        Instantiate(spellVFX, AOE4.transform.position, AOE4.transform.rotation);

        targetCircle.SetActive(true);

        Invoke("Randomizer", 15);
    }
    void SpellCast5()
    {
        Debug.Log("Dragon FIRE 5 !!!");

        Instantiate(spellVFX, AOE5.transform.position, AOE5.transform.rotation);

        targetCircle.SetActive(true);

        Invoke("Randomizer", 15);

    }

    void Randomizer()
    {
        randomAOE = Random.Range(1, 6);
        Debug.Log("Lucky Number is " + randomAOE);
        canCast = true;
    }

}
