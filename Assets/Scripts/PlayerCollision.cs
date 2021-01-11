using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public GameObject destroyedVersion;
	public GameObject originalVersion;
	public PlayerMovement movement;
	public float shakeDuration = 0f;
	public float shakePower = 0f;

	private void OnCollisionEnter(Collision collisionInfo)
	{
		//Verifica se a colisão com o obstaculo, caso tenha ocorrido:
		// Balança a camera
		// Toca o som e muda o modelo inteiro pelo modelo quebrado
		// chama a tela de game over
		if (collisionInfo.collider.CompareTag("Obstacle"))
		{
			FindObjectOfType<CameraShakeController>().StartShake(shakeDuration, shakePower);

			ChangeModel();

			PlayDeathSound();

			FindObjectOfType<GameManager>().EndGame();
		}
	}
	public void ChangeModel()
	{
		originalVersion.SetActive(false);
		destroyedVersion.SetActive(true);
	}
	public void PlayDeathSound()
	{
		
	}
}
