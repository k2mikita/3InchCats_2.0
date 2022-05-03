using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class delayBossAttack : MonoBehaviour
{
    public GameObject dragonAttack;
    public GameObject dragonAttackVFX;
    public float delay;
    // Start is called before the first frame update
    void Start()
    {

        StartCoroutine("timedelay");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private IEnumerator timedelay()
    {
        yield return new WaitForSeconds(delay);
        Instantiate(dragonAttack, transform.position, transform.rotation);
        Instantiate(dragonAttackVFX, transform.position, transform.rotation);
    }
}
