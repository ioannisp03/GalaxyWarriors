using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    //public GameObject SpawnEnemy;
    public GameObject trackingEnemyPrefab; // Enemies that track player
    float spawnRate = 2f;


    void Start()
    {
        //invokes 
        InvokeRepeating("SpawnTrackingEnemy", spawnRate, spawnRate);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnTrackingEnemy()
    {
        // Calculate the screen boundaries
        Vector2 min = Camera.main.ViewportToWorldPoint(new Vector2(0, 0));
        Vector2 max = Camera.main.ViewportToWorldPoint(new Vector2(1, 1));

        // Instantiate tracking enemy at a random position along the top edge of the screen
        Vector2 spawnPosition = new Vector2(Random.Range(min.x, max.x), max.y);
        Instantiate(trackingEnemyPrefab, spawnPosition, Quaternion.identity);
    }
}
