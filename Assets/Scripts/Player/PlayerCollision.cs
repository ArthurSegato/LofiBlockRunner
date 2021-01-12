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
	public float shakeDuration = 0f;
	public float shakePower = 0f;

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
			mainCamera.GetComponent<CameraShakeController>().StartShake(shakeDuration, shakePower);

			ChangeModel();

			audioSource.Play();

			gameManager.GetComponent<GameManager>().EndGame();
		}
	}
	public void ChangeModel()
	{
		playerOriginal.SetActive(false);
		playerCracked.SetActive(true);
	}
}
