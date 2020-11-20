using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public PlayerMovement movement;
	private void OnCollisionEnter(Collision collisionInfo)
	{
		//Verifica se a colisão foi com a tag de obstaculo
		if (collisionInfo.collider.tag == "Obstacle")
		{
			//Chama a função de GameOver
			FindObjectOfType<GameManager>().EndGame();
		}
	}

}
