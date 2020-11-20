using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
	public float gameOverDelay = 0f;
	public GameObject gameOverUI;
	public void EndGame()
	{
		//Desliga o movimento do jogador
		GameObject.Find("Player").GetComponent<PlayerMovement>().enabled = false;

		//Manda a criação de obstáculos pra casa do caralho.
		Destroy(GameObject.Find("Obstacle Manager"));

		//Exibe a tela de GameOver, onde o ojogador pode voltar para o menu ou jogar novamente.
		Invoke("GameOver", gameOverDelay);
	}
	public void GameOver()
	{
		gameOverUI.SetActive(true);
	}
	public void Restart()
	{
		SceneManager.LoadScene("Level");
	}
	public void ShowMenu()
	{
		SceneManager.LoadScene("Home");
	}
}
