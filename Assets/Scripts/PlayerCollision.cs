using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public Rigidbody rb;
	public PlayerMovement movement;
	private void OnCollisionEnter(Collision collisionInfo)
	{
		//Verifica se a colisão foi com a tag de obstaculo
		if (collisionInfo.collider.tag == "Obstacle")
		{
			//Desliga o script de movimento do jogador
			movement.enabled = false;
			rb.velocity = Vector3.zero;
		}
	}

}
