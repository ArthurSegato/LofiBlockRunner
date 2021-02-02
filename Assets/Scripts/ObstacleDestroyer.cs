using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
	//Distroi o objeto ao parar de tocar no chão
	private void OnCollisionExit(Collision collision)
	{
		if (collision.collider.CompareTag("Ground"))
		{
			Destroy(gameObject);
		}
	}
}
