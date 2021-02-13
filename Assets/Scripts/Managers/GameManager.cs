using UnityEngine;
using System.Collections;
public class GameManager : MonoBehaviour
{
	public GameObject player;
	public GameObject obstaclesManager;
	public GameObject scoreManager;
	public GameObject interfaceManager;
	
	public bool developerMode = false;

	private Vector3 playerPosition;

	[HideInInspector]
	public bool gameHasEnded = false;

	// Desliga o cursor
	private void Start()
	{
		scoreManager.GetComponent<ScoreManager>().LoadScore();
		playerPosition = player.transform.position;
	}
	public void EndGame()
	{
		gameHasEnded = true;

		//Desliga o movimento do jogador
		player.GetComponent<PlayerMovement>().enabled = false;

		//Manda a criação de obstáculos pra casa do caralho.
		obstaclesManager.SetActive(false);

		//Salva a pontuação atual
		scoreManager.GetComponent<ScoreManager>().SaveScore();

		//Habilita o cursor
		Cursor.visible = true;

		//Chama a tela de game Over
		interfaceManager.GetComponent<InterfaceManager>().GameOverInterface();
	}
	public IEnumerator ResetPlayer()
	{
		yield return new WaitForSeconds(1.5f);
		player.GetComponent<PlayerCollision>().FixPlayer();
		player.transform.position = playerPosition;
	}
	public void StartGame()
	{
		player.GetComponent<PlayerMovement>().enabled = true;
		Cursor.visible = false;
	}
}