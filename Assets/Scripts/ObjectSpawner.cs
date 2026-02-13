using UnityEngine;

public class ObjectSpawner : MonoBehaviour
{
    public GameObject[] objects; 
    public float spawnInterval = 1.5f; 
    public float xRange = 8f; 
    public float ySpawn = 6f; 

    private void Start()
    {
        InvokeRepeating("SpawnObject", 1f, spawnInterval);
    }

    void SpawnObject()
    {
        int index = Random.Range(0, objects.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-xRange, xRange), ySpawn, 0f);
        Instantiate(objects[index], spawnPos, Quaternion.identity);
    }
}