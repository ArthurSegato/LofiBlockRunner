using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreEndText;
    public TextMeshProUGUI scoreEndHighText;
    private float score = 0f;
    public float scoreHigh = 0f;

	void Update()
    {
		//Atualiza o placar com a posição atual do jogador / 10 no eixo Y
		if (GameObject.Find("Game Manager").GetComponent<GameManager>().gameHasEnded == false)
		{
            score = player.position.z / 10;
            scoreText.text = score.ToString("0");
        }
        //Atualiza a pontuação na tela de game over
        scoreEndText.text = score.ToString("0");
        scoreEndHighText.text = scoreHigh.ToString("0");

        if (score > scoreHigh)
		{
            scoreHigh = score;
		}

    }
    public void SaveScore()
	{
        SaveSystem.SaveScore(this);
	}
    public void LoadScore()
	{
        PlayerData data = SaveSystem.LoadScore();
        scoreHigh = data.scoreHighSaved;
	}
}
