using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turret : MonoBehaviour
{


    [Header("Attributes")]

    public Transform target;
   public EnemyBehavior targetEnemy;
    public float range = 15f;
    public float fireRate = 1f;
    public float fireCountdown = 0f;
    public bool cleave = false;

    [Header("Unity Setup")]

    public string enemyTag = "Enemy";

    public Transform partToRotate;
    public float turnSpeed = 10f;

    public GameObject bulletPrefab;
    public Transform firePoint;
    public Animator anim;


    List<Transform> cleaveTargets = new List<Transform>();
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("UpdateTarget", 0f, 0.5f);
    }

    public void UpdateTarget ()
    {
        cleaveTargets.Clear();
        //Target Detection
        GameObject[] enemies = GameObject.FindGameObjectsWithTag(enemyTag);
        float shortestDistance = Mathf.Infinity;
        GameObject nearestEnemy = null;
        if (cleave)
        {

            foreach (GameObject enemy in enemies)
            {
                float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
                if (distanceToEnemy <= range )
                {
                    target = enemy.transform;
                    cleaveTargets.Add(target);
                }
            }

        }
        else
        {
            foreach (GameObject enemy in enemies)
            {
                float distanceToEnemy = Vector3.Distance(transform.position, enemy.transform.position);
                if (distanceToEnemy < shortestDistance)
                {
                    shortestDistance = distanceToEnemy;
                    nearestEnemy = enemy;
                }
            }
            if (nearestEnemy != null && shortestDistance <= range)
            {
                target = nearestEnemy.transform;
                targetEnemy = nearestEnemy.GetComponent<EnemyBehavior>();
            }
            else
            {
                target = null;
            }
        }




    }

    // Update is called once per frame
    void Update()
    {
        anim.SetBool("isAttacking", false);
        if (!cleave)
        {
            if (target == null)
                return;
        }
        if (cleave)
        {
            if (cleaveTargets.Count == 0)
                return;
        }
        
        //Target Lock On
        Vector3 dir = target.position - transform.position;
        Quaternion lookRotation = Quaternion.LookRotation(dir);
        Vector3 rotation = Quaternion.Lerp(partToRotate.rotation, lookRotation, Time.deltaTime * turnSpeed).eulerAngles;
        partToRotate.rotation = Quaternion.Euler (0f, rotation.y, 0f);

        
        if (fireCountdown <= 0f)
        {
            anim.SetBool("isAttacking", true);
            Shoot();
            fireCountdown = 1/fireRate;
            

        }

        fireCountdown -= Time.deltaTime;
        
    }
    
    public void Shoot ()
    {
        if (!cleave)
        {
            GameObject bulletGo = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
            Bullet bullet = bulletGo.GetComponent<Bullet>();

            if (bullet != null)
            {
                bullet.Seek(target);
            }
        }
        if (cleave)
        {
            Debug.Log('a');
            foreach(Transform x in cleaveTargets)
            {
                Debug.Log('b');
                GameObject bulletGo = (GameObject)Instantiate(bulletPrefab, firePoint.position, firePoint.rotation);
                Bullet bullet = bulletGo.GetComponent<Bullet>();

                if (bullet != null)
                {
                    bullet.Seek(x);
                }
            }
        }

    }

    void OnDrawGizmosSelected()
    {
        //Showing Range
        Gizmos.color = Color.red;
        Gizmos.DrawWireSphere(transform.position, range);
    }
}
