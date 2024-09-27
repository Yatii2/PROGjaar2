using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
       
    private List<GameObject> enemies = new List<GameObject>();
    private float spawnRate = 1f;
    private float nextSpawnTime = 0f;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.W))
        {
            for (int i = 0; i < 100; i++)
            {
                SpawnEnemy();
            }
        }

        if (Input.GetKeyDown(KeyCode.Q))
        {
            ClearEnemies();
        }

        if (Time.time >= nextSpawnTime)
        {
            nextSpawnTime = Time.time + spawnRate;
            for (int i = 0; i < 3; i++)
            {
                SpawnEnemy();
            }
        }

    }
    private void SpawnEnemy()
    {
        GameObject newEnemy = Instantiate(enemy);
        enemies.Add(newEnemy); 
    }


    private void ClearEnemies()
    {
        foreach (GameObject enemy in enemies)
        {
            Destroy(enemy);
        }
        enemies.Clear();
    }
}


