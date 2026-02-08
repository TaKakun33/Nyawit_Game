using Unity.Mathematics;
using UnityEngine;

public class BombSpawnerScipts : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject Bomb;
    public float spawnInterval = 11f;
    public float xRange = 8f;

    void Start()
    {
        InvokeRepeating("SpawnBomb",10f, spawnInterval);
    }

    void SpawnBomb()
    {
        Vector2 spawnPos = new Vector2(UnityEngine.Random.Range(-xRange, xRange),4f);
        Instantiate(Bomb, spawnPos, quaternion.identity);
    }
}
