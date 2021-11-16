using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject obstaclePrefab;
    public Vector3 spawnPos = new Vector3(0, 0, 30);
    public float randomY;
    private float randomRange1 = 10;
    private float randomRange2 = 11;

    void Start()
    {
        // Generación de obstáculos a un tiempo determinado
        InvokeRepeating("SpawnObstacle", 0.5f, 5);
    }

    public void SpawnObstacle()
    {
        // Se generan los obstáculos en un rango
        float RandomY = Random.Range(-randomRange1, randomRange2);
        spawnPos = new Vector3(0, randomY, spawnPos.z + 50);
        Instantiate(obstaclePrefab, spawnPos, obstaclePrefab.transform.rotation);
    }
}
