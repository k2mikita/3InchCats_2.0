using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BashyScript : MonoBehaviour
{
    public int dmg;
    public GameObject player;
    private BasicBehaviour z;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider x)
    {
        if (x.tag == "Enemy")
        {
            z = (player.GetComponent<BasicBehaviour>());
            if (z.bashing)
            {
                x.SendMessage("TakeDamage", dmg);
                x.SendMessage("Stun");
            }

        }
    }
}
