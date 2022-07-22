using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private int _repeatRate = 2;
    [SerializeField] private Enemy[] _enemiesPrefabs;
    [SerializeField] private SpawnerConfig _config;
    
    private void Start()
    {
        StartCoroutine(SpawnEnemyWith(_repeatRate));
    }

    private void SpawnRandomEnemy()
    {
        Debug.Log("Inside Spawn Random Enemy");
        int randomEnemy = Random.Range(0, _enemiesPrefabs.Length);
        int randomYPosition = _config.GetRandomYPosition();
        Vector3 randomPosition = new Vector3(_config.DefaultXPosition, randomYPosition, 0);
        Debug.Log($"Spawned on Y: {randomPosition.y} X: {randomPosition.x}");
        Instantiate(_enemiesPrefabs[randomEnemy], randomPosition, _enemiesPrefabs[randomEnemy].transform.rotation);
    }

    private IEnumerator SpawnEnemyWith(int repeatRate)
    {
        Debug.Log("Coroutine started");
        var waitForSeconds = new WaitForSeconds(repeatRate);
        
        while (true)
        {
            SpawnRandomEnemy();
            yield return waitForSeconds;
        }
    }
}
