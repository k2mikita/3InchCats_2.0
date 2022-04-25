using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class fireballDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerStay(Collider x)
    {
        if (x.tag == "Enemy")
        {

            x.SendMessage("TakeDamage", 3);

            Destroy(gameObject);
        }

    }
}
