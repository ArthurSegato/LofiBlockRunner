using UnityEngine;
using TMPro;

public class InterfaceManagerGame : MonoBehaviour
{
	public GameObject gameManager;
	public GameObject player;
	public GameObject scoreManager;
	//DevModeInterface
	public GameObject interfaceDevMode;
	public TextMeshProUGUI textDevModeBuild;
	public TextMeshProUGUI textDevModeFps;
	public TextMeshProUGUI textDevModeSpeed;
	public TextMeshProUGUI textDevModeForce;
	public TextMeshProUGUI textDevModeCheckPoint;
	public TextMeshProUGUI textDevModePosition;
	//ScoreInterface
	public TextMeshProUGUI textScore;
	//GameOverInterface
	public GameObject interfaceGameOver;
	public TextMeshProUGUI textGameOverScore;
	public TextMeshProUGUI textGameOverHighScore;

	//Garante que so vai ter uma InterfaceManager em cada cena, e se não tiver, então cria uma
	public static InterfaceManagerGame instance;
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
	private void Update()
	{
		if (gameManager.GetComponent<GameManager>().developerMode)
		{
			DeveloperModeInterface();
		}
		else
		{
			interfaceDevMode.SetActive(false);
		}
		ScoreInterface();
	}
	public void DeveloperModeInterface()
	{
		interfaceDevMode.SetActive(true);

		string fpsteste = (1.0 / Time.deltaTime).ToString("0");
		float playerSpeed = player.GetComponent<PlayerMovement>().speed;
		float lateralForce = player.GetComponent<PlayerMovement>().sidewaysForce;
		float checkpointDistance = player.GetComponent<PlayerMovement>().checkpoint;
		string playerPosition = player.transform.position.z.ToString("0");
		
		textDevModeBuild.text = $"Build: {Application.version}";

		textDevModeFps.text = $"Fps: {fpsteste}";

		textDevModeSpeed.text = $"Player_Speed: {playerSpeed}";

		textDevModeForce.text = $"Lateral_Force: {lateralForce}";

		textDevModeCheckPoint.text = $"CheckPoint_Distance: {checkpointDistance}";

		textDevModePosition.text = $"Player_Position: {playerPosition}";
	}
	public void ScoreInterface()
	{
		//Exibe a posição do jogador
		textScore.text = (player.transform.position.z / 10).ToString("0");
	}
	public void GameOverInterface()
	{
		interfaceGameOver.SetActive(true);

		string score = scoreManager.GetComponent<ScoreManager>().score.ToString("0");
		string highScore = scoreManager.GetComponent<ScoreManager>().scoreHigh.ToString("0");

		textGameOverScore.text = score;
		textGameOverHighScore.text = highScore;
	}
}
