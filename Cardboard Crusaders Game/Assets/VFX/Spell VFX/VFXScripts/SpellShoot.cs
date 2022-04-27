using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellShoot : MonoBehaviour
{
    public Camera cam;
    private Vector3 destination;
    public Transform firePoint;
    public float projectileSpeed = 10f;

    public GameObject SingleSpellVFX;
    //public GameObject SpellSpawn;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootSpell();
        
    }


    void ShootSpell()
    {
        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));
        RaycastHit hit;

        if(Physics.Raycast(ray, out hit))
        {
            destination = hit.point;
        }
        else
        {
            destination = ray.GetPoint(1000);
        }

        if (Input.GetMouseButtonDown(0))
        {
            InstantiateSpell(firePoint);
        }

        

       

    }

    void InstantiateSpell(Transform firePoint)
    {
        var projectileObj = Instantiate(SingleSpellVFX, firePoint.position, Quaternion.Euler(new Vector3(0,90,0)));
        projectileObj.GetComponent<Rigidbody>().velocity = (destination - firePoint.position).normalized * projectileSpeed;
    }
    void GetInput()
    {

        if (Input.GetMouseButtonDown(0))
        {
            
        }


    }
}
