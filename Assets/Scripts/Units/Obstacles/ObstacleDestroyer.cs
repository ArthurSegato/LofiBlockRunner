using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
	//Destroi o objeto se ele sair da camera
	private void OnBecameInvisible()
	{
		Destroy(transform.parent.gameObject, 1f);
	}
}