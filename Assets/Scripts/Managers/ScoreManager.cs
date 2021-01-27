using UnityEngine;
public class ScoreManager : MonoBehaviour
{
    public GameObject gameManager;
    public GameObject player;
    [HideInInspector]
    public float score = 0f;
    [HideInInspector]
    public float scoreHigh = 0f;

    //Garante que so vai ter uma ScoreManager em cada cena, e se não tiver, então cria uma
    public static ScoreManager instance;
    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
            return;
        }
        DontDestroyOnLoad(gameObject);
    }

    void Update()
    {
        //Atualiza o placar com a posição atual do jogador no eixo Y / 10.
        if (gameManager.GetComponent<GameManager>().gameHasEnded == false)
		{
            score = player.transform.position.z / 10;
        }

        //Se a pontuação atual for maior que a maior pontuação registrada, então a pontuação atual é registrada como a maior.
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
