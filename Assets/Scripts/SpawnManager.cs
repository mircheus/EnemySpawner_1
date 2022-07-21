using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    [SerializeField] private GameObject[] _enemiesPrefabs;
    [SerializeField] private int _repeatRate = 2;
    void Start()
    {
        InvokeRepeating(nameof(SpawnRandomEnemy), 0, _repeatRate);
    }
    
    void SpawnRandomEnemy()
    {
        int lowLevel = -8;
        int middleLevel = -3;
        int highLevel = 2;
        int defaultXPosition = 25;
        int[] yPositions = new[] {highLevel, middleLevel, lowLevel};
        int randomIndex = Random.Range(0, yPositions.Length);
        int randomEnemy = Random.Range(0, _enemiesPrefabs.Length);
        Vector3 randomPosition = new Vector3(defaultXPosition, yPositions[randomIndex], 0);
        Instantiate(_enemiesPrefabs[randomEnemy], randomPosition, _enemiesPrefabs[randomEnemy].transform.rotation);
    }
}
