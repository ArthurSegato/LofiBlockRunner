using UnityEngine;
//using TMPro;
public class GameManager : MonoBehaviour
{
	public GameObject player;
	public GameObject obstaclesManager;
	public GameObject scoreManager;
	public bool developerMode = false;
	public float gameOverDelay = 0f;
	//public GameObject gameOverUI;
	//public GameObject developerModeUI;
	//public TextMeshProUGUI fpsText;
	//public TextMeshProUGUI buildText;
	[HideInInspector]
	public bool gameHasEnded = false;

	// Desliga o cursor
	private void Start()
	{
		Cursor.visible = false;
		scoreManager.GetComponent<ScoreManager>().LoadScore();

		if (developerMode)
		{
			DeveloperMode();
		}
	}
	private void Update()
	{
		if (developerMode)
		{
			//double fps = 1.0 / Time.deltaTime;
			//fpsText.text = ("FPS: " + fps.ToString("0"));
		}

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

		//Exibe a tela de GameOver depois de um tempo determinado
		Invoke(nameof(GameOver), gameOverDelay);
	}
	// Torna o cursor visivel novamente e liga a tela de GameOver
	public void GameOver()
	{
		Cursor.visible = true;
		//gameOverUI.SetActive(true);
	}
	public void DeveloperMode()
	{
		//developerModeUI.SetActive(true);
		//buildText.text = ("BUILD: " + Application.version);
	}
}