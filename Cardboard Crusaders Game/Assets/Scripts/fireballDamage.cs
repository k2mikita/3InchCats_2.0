using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballDamage : MonoBehaviour
{

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("expire");
    }

    // Update is called once per frame
    void Update()
    {

    }
    private void OnTriggerEnter(Collider x)
    {
        if (x.tag == "Enemy")
        {

            x.SendMessage("TakeDamage", 3);

            
        }
        if (x.tag != "Player")
        {
            Destroy(gameObject);
        }
    }
    private IEnumerator expire()
    {
        yield return new WaitForSeconds(10);
        Destroy(gameObject);
    }
}
