using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

//MAKE SURE ENEMIES HAVE ENEMY TAG
//SPAWNPOINTS ARE THE GAME OBJECTS WHERE ENEMIES WILL SPAWN FROM




public class WaveSpawner : MonoBehaviour
{
	public string LevelName;
	public static int EnemiesAlive = 0;
	public static int EnemiesKilled = 0;
	public Wave[] waves;

	public Transform[] spawnPoint;

	public float timeBetweenWaves = 20f;
	public float countdown = 10f;

	public Text waveCountdownText;

	//public GameManager gameManager;

	public int waveIndex = 0;

	public int wincondition;
	bool fireonce = true;

	public GameObject dragonAttack;
	public GameObject dragonAttackvfx;
	public GameObject AirChimera;
	

	void Start()
    {
		EnemiesKilled = 0;
		EnemiesAlive = 0;

	}

	void Update()
	{
		//Debug.Log(EnemiesAlive);
		//Debug.Log(EnemiesKilled);
		if (EnemiesKilled >= wincondition)
		{
			switch (LevelName)
            {
				case "Bedroom":
					gameObject.SendMessage("winBedroom");
					break;
				case "Attic":
					gameObject.SendMessage("winAttic");
					break;
				case "Backyard":
					gameObject.SendMessage("winBackyard");
					break;
				case "Kitchen":
					gameObject.SendMessage("winKitchen");
					break;
			}
			EnemiesKilled = 0;
			EnemiesAlive = 0;
			SceneManager.LoadScene("Win Screen");
			this.enabled = false;
		}

		if (EnemiesAlive > 0)
		{
			return;
		}

		if (countdown <= 0f)
		{
			StartCoroutine(SpawnWave());
			if (LevelName == "Attic" && fireonce)
            {
				StartCoroutine(spawnAttacks());
				fireonce = false;
			}
			countdown = timeBetweenWaves;
			//Debug.Log("Clock reset");
			return;
		}


		/*if (EnemiesKilled == 5)
		{
			SceneManager.LoadScene("Win Screen");
			this.enabled = false;
		}*/


		countdown -= Time.deltaTime;

		countdown = Mathf.Clamp(countdown, 0f, Mathf.Infinity);

		waveCountdownText.text = string.Format("{0:00.00}", countdown);
	}

	IEnumerator SpawnWave()
	{
		
		PlayerStats.Rounds++;
		

		Wave wave = waves[waveIndex];

		
		for (int j = 0; j < wave.WParts.Length; j++)
        {
			EnemiesAlive = wave.WParts[j].count;
			for (int i = 0; i < wave.WParts[j].count; i++)
			{
				SpawnEnemy(wave.WParts[j].enemy);
				yield return new WaitForSeconds(10f / wave.WParts[j].rate);
			}
		}
		

		waveIndex++;

		if(waveIndex == 2)
        {
			AirChimera.SetActive(false);
		}
	}

	void SpawnEnemy(GameObject enemy)
	{
		int x = Random.Range(0, spawnPoint.Length);
		Instantiate(enemy, spawnPoint[x].position, spawnPoint[x].rotation);
		EnemiesAlive++;
	}
	private IEnumerator spawnAttacks()
    {

		GameObject[] nodes = GameObject.FindGameObjectsWithTag("Node");
		for (int i = 0; i < 12; i++)
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

		yield return new WaitForSeconds(10);
		if (EnemiesKilled <= wincondition/2)
		{
			StartCoroutine(spawnAttacks());
			//AirChimera.SetActive(false);

		}
	}

}
