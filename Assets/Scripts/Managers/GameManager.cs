using UnityEngine;
using System.Collections;
public class GameManager : MonoBehaviour
{
	public bool developerMode = false;

	private GameObject player;
	private GameObject obstaclesManager;
	private GameObject scoreManager;
	private GameObject interfaceManager;

	private Vector3 playerPosition;

	[HideInInspector]
	public bool gameHasEnded = false;

	private void Start()
	{
		player = GameObject.FindWithTag("Player");
		obstaclesManager = GameObject.Find("Manager_Obstacles");
		scoreManager = GameObject.Find("Manager_Score");
		interfaceManager = GameObject.Find("Ui_Manager");

		scoreManager.GetComponent<ScoreManager>().LoadScore();
		playerPosition = player.transform.position;
	}
	public void EndGame()
	{
		// Encerra o jogo
		gameHasEnded = true;

		// Desliga o movimento do jogador
		player.GetComponent<PlayerMovement>().enabled = false;

		// Manda a criação de obstáculos pra casa do caralho.
		obstaclesManager.SetActive(false);

		// Salva a pontuação atual
		scoreManager.GetComponent<ScoreManager>().SaveScore();

		// Habilita o cursor
		Cursor.visible = true;

		//Chama a tela de game Over
		//interfaceManager.GetComponent<InterfaceManager>().GameOverInterface();
	}
	public IEnumerator ResetPlayer()
	{
		// Espera alguns segundos antes de resetar a posição do jogador
		yield return new WaitForSeconds(1.5f);
		// Concerta o jogador
		player.GetComponent<PlayerCollision>().FixPlayer();
		// Reseta a posição do jogador
		player.transform.position = playerPosition;
	}
	public void StartGame()
	{
		// Habilita o script de movimento do jogador
		player.GetComponent<PlayerMovement>().enabled = true;
		//Esconde o cursor
		Cursor.visible = false;
	}
}