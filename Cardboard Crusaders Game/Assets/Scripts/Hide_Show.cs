using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hide_Show : MonoBehaviour
{
    public GameObject vfx;
    public bool canAttack;

    // Start is called before the first frame update
    void Start()
    {
        canAttack = true;
        hideIt();
        //StartCoroutine(Waiter());
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown("left alt"))
        {
            canAttack = false;
        }
        if (Input.GetKeyUp("left alt"))
        {
            canAttack = true;
        }
        if (Input.GetMouseButtonDown(0) && canAttack == true)
        {
            showIt();
            Invoke("hideIt", 1);
        }
        
        //if (Input.GetMouseButtonUp(0) && canAttack == true)


    }

    public void showIt()
    {
        vfx.SetActive(true);
        //Waiter();
    }

    public void hideIt()
    {
        vfx.SetActive(false);
    }

    /*IEnumerator Waiter()
    {
        yield return new WaitForSeconds(0.5f);
        hideIt();
        Debug.Log("waited");

    }*/
}
