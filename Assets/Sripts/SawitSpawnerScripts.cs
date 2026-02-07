using Unity.Mathematics;
using Unity.VisualScripting;
using UnityEngine;

public class SawitSpawnerScripts : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    public GameObject sawit;
    public float spawnInterval = 2f;
    public float xRange = 8f;

    void Start()
    {
        InvokeRepeating("SpawnSawit",1f, spawnInterval);
    }

    void SpawnSawit()
    {
        Vector2 spawnPos = new Vector2(UnityEngine.Random.Range(-xRange, xRange),4f);
        Instantiate(sawit, spawnPos, quaternion.identity);
    }
}
