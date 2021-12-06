using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] mobPrefabs;
    public float spawnRangeX;
    public float spawnRangeZ;
    private float startDelay = 10f;
    private float spawnInterval = 10f;
    public int spawnLimit;
    private int quantMobs = 0;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }
    void SpawnRandomAnimal()
    {
        if (quantMobs < spawnLimit)
        {
            int mobIndex = Random.Range(0, mobPrefabs.Length);
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 1, Random.Range(-spawnRangeZ, spawnRangeZ));
            Instantiate(mobPrefabs[mobIndex], spawnPos, mobPrefabs[mobIndex].transform.rotation);
            quantMobs++;
        }
    }

    public void Matar()
    {
        quantMobs--;
    }
}
