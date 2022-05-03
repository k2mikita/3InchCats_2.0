using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class meteorSplash : MonoBehaviour
{
    private IEnumerator coroutine;
    bool delay = false;
    int timer = 0;

   // float soundTimer = 0.001f;

    // Start is called before the first frame update
    void Start()
    {
        coroutine = timedelay();
        StartCoroutine(coroutine);
    }

    // Update is called once per frame
    void Update()
    {
       /* soundTimer -= Time.deltaTime;
        if(soundTimer <= 0)
        {
            FindObjectOfType<AudioManager>().Play("PlayerMeteor");
        }*/

        if (delay)
        {
            
                if (timer == 3)
            {
                Destroy(gameObject);
            }
            timer++;


        }
    }
    private void OnTriggerStay(Collider x)
    {
        if (x.tag == "Enemy")
        {

                x.SendMessage("TakeDamage", 4);
            

        }
        timer = 3;
    }
    private IEnumerator timedelay()
    {
        yield return new WaitForSeconds(3.0f);
        Collider x = gameObject.GetComponent(typeof(Collider)) as Collider;
        x.enabled = true;
        delay = true;
    }
}
