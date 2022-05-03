using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpellShoot : MonoBehaviour
{
    public Camera cam;
    private Vector3 destination;
    public Transform firePoint;
    public float projectileSpeed = 10f;
    public LayerMask Ignoreme;
    public GameObject SingleSpellVFX;
    public bool altDown;
    //public GameObject SpellSpawn;

    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        ShootSpell();
        CanShoot();
        
    }


    void ShootSpell()
    {

        Ray ray = cam.ViewportPointToRay(new Vector3(0.5f, 0.5f, 0));

        RaycastHit hit;

        if(Physics.Raycast(ray, out hit, ~Ignoreme))
        {
            destination = hit.point;
        }
        else
        {
            destination = ray.GetPoint(1000);
        }

        if (Input.GetMouseButtonDown(0) && altDown == false)
        {
            InstantiateSpell(firePoint);

            int num = Random.Range(1, 3);
            //play collision sounds
            if (num == 1)
            {
                FindObjectOfType<AudioManager>().Play("Fireball1");
            }
            if (num == 2)
            {
                FindObjectOfType<AudioManager>().Play("Fireball2");
            }
            if (num == 3)
            {
                FindObjectOfType<AudioManager>().Play("Fireball3");
            }
        }

        

       

    }

    void InstantiateSpell(Transform firePoint)
    {
        var projectileObj = Instantiate(SingleSpellVFX, firePoint.position, Quaternion.Euler(new Vector3(0,90,0)));
        projectileObj.GetComponent<Rigidbody>().velocity = (destination - firePoint.position).normalized * projectileSpeed;
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
}
