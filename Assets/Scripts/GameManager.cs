using UnityEngine;
public class GameManager : MonoBehaviour
{
	public float gameOverDelay = 0f;
	public GameObject gameOverUI;
	public bool gameHasEnded = false;

	// Desliga o cursor
	private void Start()
	{
		Cursor.visible = false;
		GameObject.Find("ScoreManager").GetComponent<ScoreManager>().LoadScore();
	}
	public void EndGame()
	{
		//Desliga o movimento do jogador
		GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;

		//Manda a criação de obstáculos pra casa do caralho.
		Destroy(GameObject.Find("Obstacle Manager"));

		//Exibe a tela de GameOver depois de um tempo determinado
		Invoke("GameOver", gameOverDelay);
	}
	// Torna o cursor visivel novamente e liga a tela de GameOver
	public void GameOver()
	{
		gameHasEnded = true;
		Cursor.visible = true;
		GameObject.Find("ScoreManager").GetComponent<ScoreManager>().SaveScore();
		gameOverUI.SetActive(true);
	}
}