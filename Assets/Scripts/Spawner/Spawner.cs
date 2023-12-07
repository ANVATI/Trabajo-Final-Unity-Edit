using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawn : MonoBehaviour
{
    public GameObject[] enemyPrefabs;
    public float minSpawnTime = 12f;
    public float maxSpawnTime = 20f;
    public GameManagerControl gameManager;

    void Start()
    {
        Invoke("Spawner", Random.Range(minSpawnTime, maxSpawnTime));
    }

    void Spawner()
    {
        GameObject randomEnemy = enemyPrefabs[Random.Range(0, enemyPrefabs.Length)];
        GameObject zombie = Instantiate(randomEnemy, transform.position, transform.rotation);
        zombie.GetComponent<HerenciaZombies>().gameManager = gameManager;
        float nextSpawnTime = Random.Range(minSpawnTime, maxSpawnTime);
        Invoke("Spawner", nextSpawnTime);
    }
}

