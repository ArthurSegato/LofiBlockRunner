using System.Collections;
using UnityEngine;

public class PlayerCollision : MonoBehaviour
{
	public GameObject playerOriginal;
	public GameObject playerCracked;
	public AudioSource audioSource;

	[SerializeField]
	private GameObject gameManager;
	[SerializeField]
	private GameObject audioManager;
	[SerializeField]
	private GameObject mainCamera;

	void OnCollisionEnter(Collision collisionInfo)
	{
		if (collisionInfo.collider.CompareTag("Obstacle"))
		{
			// Balança a camera
			mainCamera.GetComponent<CameraShakeController>().StartShake();

			// Quebra o jogador
			BrakePlayer();

			// Toca o som de impacto
			audioSource.Play();

			// Finaliza o jogo
			StartCoroutine(gameManager.GetComponent<GameManager>().EndGame());
		}
	}
	// Troca o modelo do jogador inteiro para o quebrado
	public void BrakePlayer()
	{
		playerOriginal.SetActive(false);
		playerCracked.SetActive(true);
	}
	// Troca o modelo do jogador quebrado para o inteiro
	public void FixPlayer()
	{
		playerCracked.SetActive(false);
		playerOriginal.SetActive(true);
	}
}
