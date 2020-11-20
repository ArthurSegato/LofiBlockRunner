using UnityEngine;

public class SpawnController : MonoBehaviour
{
    public GameObject[] obstaclePrefabs;
    public float startDelay = 1.0f;
    public float spawnIntervalMax = 1.0F;
    public float spawnX;

    void Start()
    {
        float spawnInterval = Random.Range(0.5f, spawnIntervalMax);
        InvokeRepeating("SpawnObstacle", startDelay, spawnInterval);
    }
    void SpawnObstacle()
	{

        int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
        int qtMax = 6;
        int spawnRange = 10;

        if (obstacleIndex == 0)
		{
            qtMax = 4;
            spawnRange = 7;
        }
        if (obstacleIndex == 1)
        {
            qtMax = 1;
            spawnRange = 3;
        }
        if (obstacleIndex == 2)
        {
            qtMax = 2;
            spawnRange = 5;
        }
        for (int i = 0; i < qtMax; i++)
        {
            Vector3 spawnPos = new Vector3(Random.Range(-spawnRange, spawnRange), 1, GameObject.Find("Obstacle Manager").transform.position.z);
            Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, Quaternion.identity);
        }
    }
}
