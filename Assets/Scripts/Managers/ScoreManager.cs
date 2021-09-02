using UnityEngine;
public class ScoreManager : MonoBehaviour
{
    [HideInInspector]
    public float score = 0f;
    [HideInInspector]
    public float scoreHigh = 0f;
    
    private GameObject gameManager;
    private GameObject player;

    void Start()
    {
        gameManager = GameObject.Find("Manager_Game");
        player = GameObject.FindWithTag("Player");
    }
    
    void Update()
    {
        // Atualiza o placar com a posição atual do jogador no eixo Y / 10.
        if (gameManager.GetComponent<GameManager>().gameHasEnded == false)
		{
            score = player.transform.position.z / 10;
        }
        // Se a pontuação atual for maior que a maior pontuação registrada, então a pontuação atual é registrada como a maior.
        if (score > scoreHigh)
		{
            scoreHigh = score;
		}
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
