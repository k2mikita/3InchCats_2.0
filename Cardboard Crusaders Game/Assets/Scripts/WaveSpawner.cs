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
	public static int EnemiesAlive = 0;
	public static int EnemiesKilled = 0;
	public Wave[] waves;

	public Transform[] spawnPoint;

	public float timeBetweenWaves = 20f;
	public float countdown = 10f;

	public Text waveCountdownText;

	//public GameManager gameManager;

	public int waveIndex = 0;



	void Start()
    {
		EnemiesKilled = 0;
		EnemiesAlive = 0;
	}

	void Update()
	{
		//Debug.Log(EnemiesAlive);
		//Debug.Log(EnemiesKilled);
		if (EnemiesKilled == 105)
		{
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
	}

	void SpawnEnemy(GameObject enemy)
	{
		int x = Random.Range(0, spawnPoint.Length);
		Instantiate(enemy, spawnPoint[x].position, spawnPoint[x].rotation);
		EnemiesAlive++;
	}
	

}
