using UnityEngine;

public class ObstacleDestroyer : MonoBehaviour
{
    //Distroi o objeto ao parar de tocar no chão (só para não lagar o editor)
	private void OnCollisionExit(Collision collision)
	{
        if(collision.collider.CompareTag("Ground"))
		{
            Destroy(gameObject);
        }
    }
}
