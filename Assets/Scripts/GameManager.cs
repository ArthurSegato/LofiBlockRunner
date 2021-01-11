using UnityEngine;
//using TMPro;
public class GameManager : MonoBehaviour
{
	public float gameOverDelay = 0f;
	public GameObject gameOverUI;
	public GameObject developerModeUI;
	//public TextMeshProUGUI fpsText;
	//public TextMeshProUGUI buildText;
	[HideInInspector]
	public bool gameHasEnded = false;
	public bool developerMode = false;

	// Desliga o cursor
	private void Start()
	{
		Cursor.visible = false;
		//GameObject.Find("ScoreManager").GetComponent<ScoreManager>().LoadScore();

		if (developerMode)
		{
			//developerModeUI.SetActive(true);
			//buildText.text = ("BUILD: " + Application.version);
		}
	}
	private void Update()
	{
		var fps = 1.0 / Time.deltaTime;
		//fpsText.text = ("FPS: " + fps.ToString("0"));
	}
	public void EndGame()
	{
		//Desliga o movimento do jogador
		GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;

		//Manda a criação de obstáculos pra casa do caralho.
		GameObject.Find("ObstacleManager").SetActive(false);

		//Exibe a tela de GameOver depois de um tempo determinado
		Invoke("GameOver", gameOverDelay);
	}
	// Torna o cursor visivel novamente e liga a tela de GameOver
	public void GameOver()
	{
		gameHasEnded = true;
		Cursor.visible = true;
		//GameObject.Find("ScoreManager").GetComponent<ScoreManager>().SaveScore();
		//gameOverUI.SetActive(true);
	}
}