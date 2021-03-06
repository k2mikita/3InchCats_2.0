using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class EnemyBehavior : MonoBehaviour
{
    public float startSpeed = 10f;
    public GameObject ImpactVFX;
    public GameObject DeathVFX;
    public GameObject target;

    [HideInInspector]
    public float speed;

    public float startHealth = 10;
    private float health;

    public float attackDamage = 5;
    public float attackSpeed = 1;
    public float attackCooldown = 0f;
    public bool boom = false;
    public int worth = 50;

    bool slowed;
    public string deathSound;
    UnityEngine.AI.NavMeshAgent x;
    bool stunned = false;
    int timer = 0;
    //public GameObject deathEffect;

    [Header("Unity Stuff")]
   public Image healthBar;

    private bool isDead = false;

    public bool Boss = false;
    int attackNumber = 0;
    public GameObject dragonAttack;
    public GameObject dragonAttackvfx;



    //call Animator
    public Animator anim;


    // Use this for initialization
    void Start()
    {
        speed = startSpeed;
        health = startHealth;
        x = gameObject.GetComponent<UnityEngine.AI.NavMeshAgent>();
        x.speed = speed;

     //   anim = GetComponent<Animator>();
        anim.SetBool("isAttacking", false);
    }

    // Update is called once per frame
    void Update()
    {
        if (stunned)
        {
            timer++;
            if (timer == 300)
            {
                stunned = false;
                x.speed = speed;
                timer = 0;
            }
        }

        if (Boss)
        {
            if ((attackNumber == 5 )&& health < 11)
            {
                spawnAttacks();

            }
            if ((attackNumber == 4) && health < 26)
            {
                spawnAttacks();
                attackNumber++;
            }
            if ((attackNumber == 3) && health < 41)
            {
                spawnAttacks();
                attackNumber++;
            }
            if ((attackNumber == 2) && health < 56)
            {
                spawnAttacks();
                attackNumber++;
            }
            if ((attackNumber == 1) && health < 71)
            {
                spawnAttacks();
                attackNumber++;
            }
            if ((attackNumber == 0) && health < 86){
                spawnAttacks();
                attackNumber++;
            }
        }

    }

    public void TakeDamage(int amount)
    {
        health -= amount;

        healthBar.fillAmount = health / startHealth;
        
        if(health <= 0 && !isDead)
        {
            Die();
        }
    }

    /*public void Slow (float pct)
    {
        speed = startSpeed * (1f - pct);
    }*/

    void Die()
    {
        isDead = true;
        FindObjectOfType<AudioManager>().Play(deathSound);
        PlayerStats.Money += worth;
        WaveSpawner.EnemiesAlive--;
        WaveSpawner.EnemiesAlive--;
        WaveSpawner.EnemiesKilled++;

        Debug.Log("Enemy Dead:" + WaveSpawner.EnemiesKilled);

        // Add Enemy Death VFX here
        Instantiate(DeathVFX, target.transform.position, target.transform.rotation);
        Destroy(gameObject);
    }


    private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.tag.Equals("Castle") == true)
        {
           
            if (attackCooldown <= 0f)
            {

                PlayerStats.Lives -= attackDamage;
                attackCooldown = 1f / attackSpeed;

                //Attack Animation bool
                anim.SetBool("isAttacking", true);
                // Instantiate Castle Impact VFX
                Instantiate(ImpactVFX, target.transform.position, target.transform.rotation);

                int num = Random.Range(1, 13);
                //play collision sounds
                if (num == 1)
                {
                    FindObjectOfType<AudioManager>().Play("CastleDamage1");
                }
                if (num == 2)
                {
                    FindObjectOfType<AudioManager>().Play("CastleDamage2");
                }
                if (num == 3)
                {
                    FindObjectOfType<AudioManager>().Play("CastleDamage3");
                }
                if (num == 4)
                {
                    FindObjectOfType<AudioManager>().Play("CastleDamage4");
                }
                if (num == 5)
                {
                    FindObjectOfType<AudioManager>().Play("CastleDamage5");
                }
                if (num == 6)
                {
                    FindObjectOfType<AudioManager>().Play("CastleDamage6");
                }
                if (num == 7)
                {
                    FindObjectOfType<AudioManager>().Play("CastleDamage7");
                }
                if (num == 8)
                {
                    FindObjectOfType<AudioManager>().Play("CastleDamage8");
                }
                if (num == 9)
                {
                    FindObjectOfType<AudioManager>().Play("CastleDamage9");
                }
                if (num == 10)
                {
                    FindObjectOfType<AudioManager>().Play("CastleDamage10");
                }
                if (num == 11)
                {
                    FindObjectOfType<AudioManager>().Play("CastleDamage11");
                }
                if (num == 12)
                {
                    FindObjectOfType<AudioManager>().Play("CastleDamage12");
                }
                if (num == 13)
                {
                    FindObjectOfType<AudioManager>().Play("CastleDamage13");
                }
                if (boom)
                {
                    FindObjectOfType<AudioManager>().Play("BomberAttack");

                    Die();
                }
            }

            attackCooldown -= Time.deltaTime;
            
             
        }
    }
    public void Stun()
    {
        if (!stunned)
        {
            x.speed = 0;
            stunned = true;
        }
        else
        {
            timer = 0;
        }
        
    }
    private void OnTriggerEnter(Collider y)
    {
        Debug.Log("a");
        if (y.gameObject.tag == "mudZone")
        {
            x.speed = speed/2;
        }
    }
    private void OnTriggerExit(Collider y)
    {
        Debug.Log("b");
        if (y.gameObject.tag == "mudZone")
        {
            x.speed = speed;
        }
    }
    private void spawnAttacks()
    {

        GameObject[] nodes = GameObject.FindGameObjectsWithTag("Node");
        for (int i = 0; i < 24; i++)
        {
            int x = Random.Range(0, nodes.Length);
            Instantiate(dragonAttack, nodes[x].transform.position, nodes[x].transform.rotation);
            Instantiate(dragonAttackvfx, nodes[x].transform.position, nodes[x].transform.rotation);

            int num = Random.Range(1, 3);
            //play collision sounds
            if (num == 1)
            {
                FindObjectOfType<AudioManager>().Play("BossAttack1");
            }
            if (num == 2)
            {
                FindObjectOfType<AudioManager>().Play("BossAttack2");
            }
            if (num == 3)
            {
                FindObjectOfType<AudioManager>().Play("BossAttack3");
            }
        }
    }
}


