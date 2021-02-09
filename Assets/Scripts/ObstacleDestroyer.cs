using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
	//Destroi o objeto ao parar de tocar no chão
	private void OnBecameInvisible()
	{
		Destroy(this.gameObject);
	}
}