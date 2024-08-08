using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class prefaba : MonoBehaviour
{
    [SerializeField] Transform[] spawnPoints;
    [SerializeField] GameObject enemyPrefab;
    public float spawnInterval = 1f;

    void Start()
    {
        SpawnEnemy();
        InvokeRepeating("SpawnEnemy", 1f, spawnInterval);
    }

    void SpawnEnemy()
    {
        foreach (Transform spawnPoint in spawnPoints)
        {
            if (IsSpawnPointEmpty(spawnPoint))
            {
                Instantiate(enemyPrefab, spawnPoint.position, Quaternion.identity);
            }
        }
    }

    bool IsSpawnPointEmpty(Transform spawnPoint)
    {
        Collider[] colliders = Physics.OverlapSphere(spawnPoint.position, 0.5f);
        foreach (Collider collider in colliders)
        {
            if (collider.CompareTag("Enemy"))
            {
                return false;
            }
        }
        return true; 
    }
}
