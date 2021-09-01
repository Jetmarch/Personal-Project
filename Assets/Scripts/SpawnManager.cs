using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] enemies;
    public GameObject powerup;


    private float zEnemySpawn = 12.0f;
    private float xSpawnRange = 16.0f;
    private float zPowerupRange = 5.0f;

    private float powerupSpawnDelay = 3.0f;
    private float enemySpawnDelay = 1.0f;
    private float powerupSpawnRate = 5.0f;
    private float enemySpawnRate = 1.0f;

    private int maxEnemyOnScene = 10;
    private int maxPowerupOnScene = 5;
    private int currentCountEnemyOnScene = 0;
    private int currentCountPowerupOnScene = 0;
    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnPowerup", powerupSpawnDelay, powerupSpawnRate);
        InvokeRepeating("SpawnEnemy", enemySpawnDelay, enemySpawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnEnemy()
    {
        /*if (currentCountEnemyOnScene >= maxEnemyOnScene)
        {
            return;
        }*/

        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        int randomIndex = Random.Range(0, enemies.Length);

        Vector3 spawnPos = new Vector3(randomX, 0.75f, zEnemySpawn);

        Instantiate(enemies[randomIndex], spawnPos, enemies[randomIndex].gameObject.transform.rotation);

        //currentCountEnemyOnScene++;
    }

    void SpawnPowerup()
    {
       /* if(currentCountPowerupOnScene >= maxPowerupOnScene)
        {
            return;
        }*/

        float randomX = Random.Range(-xSpawnRange, xSpawnRange);
        float randomZ = Random.Range(-zPowerupRange, zPowerupRange);

        Vector3 spawnPos = new Vector3(randomX, 0.75f, randomZ);

        Instantiate(powerup, spawnPos, powerup.gameObject.transform.rotation);

        //currentCountPowerupOnScene++;
    }
}
