using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
	//Distroi o objeto ao parar de tocar no chão
	private void OnBecameInvisible()
	{
		Destroy(gameObject);
	}
}