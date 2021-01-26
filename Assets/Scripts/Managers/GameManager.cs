using UnityEngine;

public class GameManager : MonoBehaviour
{
	public GameObject player;
	public GameObject obstaclesManager;
	public GameObject scoreManager;
	public GameObject interfaceManager;
	
	public bool developerMode = false;
	public int gameOverDelay = 0;
	
	[HideInInspector]
	public bool gameHasEnded = false;

	// Desliga o cursor
	private void Start()
	{
		Cursor.visible = false;
		//scoreManager.GetComponent<ScoreManager>().LoadScore();
	}
	public void EndGame()
	{
		gameHasEnded = true;

		//Desliga o movimento do jogador
		player.GetComponent<PlayerMovement>().enabled = false;

		//Manda a criação de obstáculos pra casa do caralho.
		Destroy(obstaclesManager);

		//Salva a pontuação atual
		//scoreManager.GetComponent<ScoreManager>().SaveScore();

		//Habilita o cursor
		Cursor.visible = true;

		//Chama a tela de game Over
		interfaceManager.GetComponent<InterfaceManager>().GameOverInterface();
	}
}