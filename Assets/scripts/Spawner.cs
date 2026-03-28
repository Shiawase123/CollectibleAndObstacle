using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject collectiblePrefab;
    public GameObject obstaclePrefab;

    public float spawnInterval = 1.5f;
    public float spawnRangeY = 4f;

    void Start()
    {
        InvokeRepeating("SpawnObject", 1f, spawnInterval);
    }

    void SpawnObject()
    {
        if (GameManager.Instance != null && GameManager.Instance.isGameOver)
            return;

        GameObject objectToSpawn;

        // 70% chance for collectible, 30% for obstacle
        if (Random.value < 0.7f)
        {
            objectToSpawn = collectiblePrefab;
        }
        else
        {
            objectToSpawn = obstaclePrefab;
        }

        Vector3 spawnPosition = new Vector3(
            -10f, // Left side
            Random.Range(-spawnRangeY, spawnRangeY),
            0
        );

        Instantiate(objectToSpawn, spawnPosition, Quaternion.identity);
    }
}