using UnityEngine;
//using TMPro;
public class ScoreManager : MonoBehaviour
{
    public Transform player;
    //public TextMeshProUGUI scoreText;
    //public TextMeshProUGUI scoreEndText;
    //public TextMeshProUGUI scoreEndHighText;
    private float score = 0f;
    public float scoreHigh = 0f;

    //Garante que so vai ter uma UIManager em cada cena, e se não tiver, então cria uma
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
        if (GameObject.Find("GameManager").GetComponent<GameManager>().gameHasEnded == false)
		{
            score = player.position.z / 10;
            //scoreText.text = score.ToString("0");
        }
        //Atualiza a pontuação na tela de game over
        //scoreEndText.text = score.ToString("0");
        //scoreEndHighText.text = scoreHigh.ToString("0");

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
