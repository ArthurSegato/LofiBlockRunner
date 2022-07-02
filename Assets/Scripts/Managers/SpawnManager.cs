using System.Collections;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
	public GameObject[] obstaclePrefabs;
	public float spawnInterval = 0F;
	[SerializeField]
	private GameObject gameManager;
	private float spawnX = 0f;
	private int lastObstacleIndex = 0;

	//Inicia o processo de spawnar os obstáculos em um dado tempo
	void OnEnable()
	{
		StartCoroutine(SpawnObstacle());
	}
	IEnumerator SpawnObstacle()
	{
		for (;;)
		{
			yield return new WaitForSeconds(spawnInterval);
			// Escolhe um obstáculo aleatorio da lista
			int obstacleIndex = Random.Range(0, obstaclePrefabs.Length);

			// Verifica se o obstáculo escolhido e o mesmo da escolha anterior, caso seja, escolhe outro
			while (obstacleIndex == lastObstacleIndex)
			{
				obstacleIndex = Random.Range(0, obstaclePrefabs.Length);
			}
			lastObstacleIndex = obstacleIndex;

			// Define uma posição aleatória para o obstáculo 2
			if (obstacleIndex == 2)
			{
				spawnX = Random.Range(-5f, 5f);
			}
			// Define se o obstáculo 3 vai ficar no lado esquerdo ou direito
			else if (obstacleIndex == 3)
			{
				if (Random.Range(-2f, 2f) >= 0)
				{
					spawnX = 2.5f;
				}
				else
				{
					spawnX = -2.5f;
				}
			}
			else
			{
				spawnX = 0f;
			}

			// Define a posição do obstáculo
			Vector3 spawnPos = new Vector3(spawnX, 1, gameObject.transform.position.z);
			// Spawna o obstáculo
			Instantiate(obstaclePrefabs[obstacleIndex], spawnPos, Quaternion.identity);
		}
	}
}