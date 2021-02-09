using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public GameObject gameManager;
	public GameObject audioManager;
	public GameObject mainCamera;
	public GameObject playerOriginal;
	public GameObject playerCracked;
	public AudioSource audioSource;
	public PlayerMovement playerMovement;

	private void OnCollisionEnter(Collision collisionInfo)
	{
		/*
		 * Ao colidir com um obstaculo:
		 * - Balança a camera
		 * - Troca o bloco original pelo quebrado
		 * - Toca o som de morte
		 * - Chama a finalização do jogo
		 */
		if (collisionInfo.collider.CompareTag("Obstacle"))
		{
			mainCamera.GetComponent<CameraShakeController>().StartShake();

			BrakePlayer();

			audioSource.Play();

			gameManager.GetComponent<GameManager>().EndGame();
		}
	}
	public void BrakePlayer()
	{
		playerOriginal.SetActive(false);
		playerCracked.SetActive(true);
	}
	public void FixPlayer()
	{
		playerCracked.SetActive(false);
		playerOriginal.SetActive(true);
	}
}
