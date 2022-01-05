﻿using UnityEngine;
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

	[HideInInspector]
	public bool gameHasEnded = false;
	void Awake()
	{
		// Inicia a UI
		StartCoroutine(Manager_UI.GetComponent<UIManager>().StartUI());
		// Chama a splash screen
		StartCoroutine(Manager_UI.GetComponent<UIManager>().ShowSplash());
	}
	void Start()
	{
		scoreManager.GetComponent<ScoreManager>().LoadScore();
		playerPosition = player.transform.position;

		player.GetComponent<PlayerMovement>().enabled = false;
		obstaclesManager.SetActive(false);
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
		//Manager_UI.GetComponent<Manager_UI>().Open_UI_GameOver();

		// Reseta o jogador
		StartCoroutine(ResetPlayer());
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
		gameHasEnded = false;
		// Habilita o script de movimento do jogador
		player.GetComponent<PlayerMovement>().enabled = true;
		//Habilita o script de spawn dos obstaculos
		obstaclesManager.SetActive(true);
		//Esconde o cursor
		Cursor.visible = false;
	}
}