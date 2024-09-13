using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class TowerSpawner : MonoBehaviour
{
   
    public GameObject towerPrefab;

    public Vector3 minPosition = new Vector3(-5f, 0f, -5f);
    public Vector3 maxPosition = new Vector3(5f, 0f, 5f);

    void Update()
    {
        
        if (Input.GetMouseButtonDown(0)) 
        {
            SpawnTower();
        }
    }

    
    void SpawnTower()
    {
      
        float randomX = Random.Range(minPosition.x, maxPosition.x);
        float randomY = Random.Range(minPosition.y, maxPosition.y);
        float randomZ = Random.Range(minPosition.z, maxPosition.z);

        Vector3 randomPosition = new Vector3(randomX, randomY, randomZ);

      
        Instantiate(towerPrefab, randomPosition, Quaternion.identity);
    }
}

