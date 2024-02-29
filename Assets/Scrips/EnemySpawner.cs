using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    [SerializeField] private GameObject enemyprefab;
    [SerializeField] private float minSpawnTime;
    [SerializeField] private float maxSpawnTime;
    private float timeUntilSpawn;

    void Awake()
    {
        SetTimeUnitlSpawn();
    }

    // Update is called once per frame
    void Update()
    {
        timeUntilSpawn -= Time.deltaTime;
        if (timeUntilSpawn <= 0)
        {
            Instantiate(enemyprefab, transform.position, Quaternion.identity);
            SetTimeUnitlSpawn();
        }
    }

    private void SetTimeUnitlSpawn()
    {
        timeUntilSpawn = Random.Range(minSpawnTime, maxSpawnTime);
    }
}
