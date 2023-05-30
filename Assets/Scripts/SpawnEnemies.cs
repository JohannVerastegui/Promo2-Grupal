using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnEnemies : MonoBehaviour
{
    [SerializeField] GameObject enemyPrefab;
    [SerializeField] int totalEnemies;
    [SerializeField] float spawnRadius;
    [SerializeField] float innerRadius;
    int currentEnemies;
    void Start()
    {
        spawnEnemies();
    }

    void Update()
    {

    }

    public void spawnEnemies()
    {
        for (int i = 0; i < totalEnemies; i++)
        {
            var enemy = Instantiate(enemyPrefab, GetRandomPosition(), Quaternion.identity);
            currentEnemies += 1;
        }
    }

    private Vector3 GetRandomPosition()
    {
        Vector3 randomCircle = Random.insideUnitSphere.normalized * (spawnRadius - innerRadius);
        Vector3 randomPosition = new Vector3(randomCircle.x, 0.5f, randomCircle.z) + transform.position;
        return randomPosition;
    }
}