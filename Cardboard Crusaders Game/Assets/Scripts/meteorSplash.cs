using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorSplash : MonoBehaviour
{
    private IEnumerator coroutine;
    bool delay = false;
    int timer = 0;
    // Start is called before the first frame update
    void Start()
    {
        coroutine = timedelay();
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {

        if (delay)
        {
            
                if (timer == 10)
            {
                Destroy(gameObject);
            }
            timer++;


        }
    }
    private void OnTriggerStay(Collider x)
    {
        Debug.Log("a");
        if (x.tag == "Enemy")
        {

                x.SendMessage("TakeDamage", 4);
            

        }
        timer = 10;
    }
    private IEnumerator timedelay()
    {
        yield return new WaitForSeconds(3.0f);
        Collider x = gameObject.GetComponent(typeof(Collider)) as Collider;
        x.enabled = true;
        delay = true;
    }
}
