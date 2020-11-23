using UnityEngine;
using TMPro;
public class ScoreManager : MonoBehaviour
{
    public Transform player;
    public TextMeshProUGUI scoreText;
    public TextMeshProUGUI scoreEndText;
    private float score = 0f;
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
    }
}
