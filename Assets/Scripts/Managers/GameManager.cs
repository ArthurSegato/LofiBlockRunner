using UnityEngine;
using System.Collections;
public class GameManager : MonoBehaviour
{
	public bool developerMode = false;

	[SerializeField]
	private GameObject obstaclesManager;
	[SerializeField]
	private GameObject scoreManager;
	[SerializeField]
	private GameObject player;
	[SerializeField]
	private GameObject Manager_UI;
	[SerializeField]
	private Vector3 playerPosition;
	[SerializeField]
	private float delayToResetPlayer = 0f;
	[SerializeField]
	private float delayToGameOverScreen = 0f;
	[HideInInspector]
	public bool gameHasEnded = false;
	void Awake()
	{
		// Inicia a UI
		Manager_UI.GetComponent<UIManager>().StartUI();
		// Chama a splash screen
		StartCoroutine(Manager_UI.GetComponent<UIManager>().ShowSplash());
	}
	void Start()
	{
		// Carrega a pontuação
		scoreManager.GetComponent<ScoreManager>().LoadScore();
		playerPosition = player.transform.position;
		// Congela o jogador
		player.GetComponent<PlayerMovement>().enabled = false;
		// Congela os obstáculos
		obstaclesManager.SetActive(false);
	}
	public IEnumerator EndGame()
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

		// Espera um tempo antes de chamar a tela de GameOver
		yield return new WaitForSeconds(delayToGameOverScreen);
		
		//Chama a tela de game Over
		Manager_UI.GetComponent<UIManager>().ChangeGameToGameOver();

		// Reseta o jogador
		StartCoroutine(ResetPlayer());
		yield return null;
	}
	public IEnumerator ResetPlayer()
	{
		// Espera alguns segundos antes de resetar a posição do jogador
		yield return new WaitForSeconds(delayToResetPlayer);
		// Concerta o jogador
		player.GetComponent<PlayerCollision>().FixPlayer();
		// Reseta a posição do jogador
		player.transform.position = playerPosition;
		// Reseta o modelo quebrado do jogador
		player.GetComponent<ResetPlayer>().ResetPlayerModel();
	}
	public void StartGame()
	{
		gameHasEnded = false;
		// Habilita o script de movimento do jogador
		player.GetComponent<PlayerMovement>().enabled = true;
		//Habilita o script de spawn dos obstaculos
		obstaclesManager.SetActive(true);
		//Esconde o cursor
		Cursor.visible = false;
	}
}