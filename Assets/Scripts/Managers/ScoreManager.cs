using UnityEngine;
using System.Collections;
using System;

public class ScoreManager : MonoBehaviour
{
    [HideInInspector]
    public float score = 0.0f;
    [HideInInspector]
    public float scoreHigh = 0.0f;
    [HideInInspector]
    public string score_string;
    [SerializeField]
    private GameObject gameManager;
    private GameObject UIManager;
    private GameObject player;

    void Start()
    {
        UIManager = GameObject.Find("Ui_Manager");
        player = GameObject.Find("Player");
    }
    
    void Update()
    {
        // Atualiza o placar com a posição atual do jogador no eixo Y / 10.
        if (gameManager.GetComponent<GameManager>().gameHasEnded == false)
		{
            score = player.transform.position.z / 10;
        }else{
            UIManager.GetComponent<UIManager>().SetScore(score, scoreHigh);
        }
        // Se a pontuação atual for maior que a maior pontuação registrada, então a pontuação atual é registrada como a maior.
        if (score > scoreHigh)
		{
            scoreHigh = score;
		}
    }
    public string GetScore()
    {
        return score_string = score.ToString("0");
    }
    // Salva a pontuação
    public void SaveScore()
	{
        SaveSystem.SaveScore(this);
	}
    // Carrega a pontuação
    public void LoadScore()
	{
        PlayerData data = SaveSystem.LoadScore();
        scoreHigh = data.scoreHighSaved;
    }
}
