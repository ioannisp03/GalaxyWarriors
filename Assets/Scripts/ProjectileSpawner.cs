using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    [SerializeField]
    public GameObject enemyProjectile;

    [SerializeField]
    float spawnTimer;

    [SerializeField]
    public float spawnMax = 10;

    [SerializeField]
    public float spawnMin = 2;
    void Start()
    {
        spawnTimer = Random.Range(spawnMin, spawnMax);
    }

    void Update()
    {
        spawnTimer -= Time.deltaTime;
        if (spawnTimer <= 0)
        {
            Instantiate(enemyProjectile, transform.position, Quaternion.identity);
            spawnTimer = Random.Range(spawnMin,spawnMax);
        }
    }
}
