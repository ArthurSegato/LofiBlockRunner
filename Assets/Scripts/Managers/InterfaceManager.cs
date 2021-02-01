using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class InterfaceManager : MonoBehaviour
{

	public GameObject gameManager;
	public GameObject interfaceGame;
	public GameObject player;
	public GameObject scoreManager;

	//Variaveis da inteface (Developer Mode)
	private VisualElement divDevMode;
	private Label devModeFps;
	private Label devModeBuild;
	private Label devModeSpeed;
	private Label devModeForce;
	private Label devModeCheckPoint;
	private Label devModePlayerPosition;
	//Variaveis da inteface (Score Gameplay)
	private Label scoreGamePlay;
	//Variaveis da inteface (Game Over)
	private VisualElement divGameOver;
	private Label gameOverCurrentScore;
	private Label gameOverHighScore;
	private Button gameOverPlayAgain;
	private Button gameOverMenu;

	//Garante que so vai ter uma InterfaceManager em cada cena, e se não tiver, então cria uma
	public static InterfaceManager instance;
	private void OnEnable()
	{
		//var rootVisualElement = interfaceGame.GetComponent<UIDocument>().rootVisualElement;

		//Developer Mode
		/*
		divDevMode = rootVisualElement.Q<VisualElement>("Div_DevMode");
		devModeFps = rootVisualElement.Q<Label>("Text_DevMode_Fps");
		devModeBuild = rootVisualElement.Q<Label>("Text_DevMode_Build");
		devModeSpeed = rootVisualElement.Q<Label>("Text_DevMode_Speed");
		devModeForce = rootVisualElement.Q<Label>("Text_DevMode_Force");
		devModeCheckPoint = rootVisualElement.Q<Label>("Text_DevMode_CheckPoint");
		devModePlayerPosition = rootVisualElement.Q<Label>("Text_DevMode_PlayerPosition");
		//Score Gameplay
		scoreGamePlay = rootVisualElement.Q<Label>("Text_Score_Gameplay");
		//Game Over
		divGameOver = rootVisualElement.Q<VisualElement>("Div_GameOver");
		gameOverCurrentScore = rootVisualElement.Q<Label>("Text_CurrentScore");
		gameOverHighScore = rootVisualElement.Q<Label>("Text_HighScore");
		gameOverPlayAgain = rootVisualElement.Q<Button>("Button_GameOver_PlayAgain");
		gameOverMenu = rootVisualElement.Q<Button>("Button_GameOver_Menu");

		gameOverPlayAgain.RegisterCallback<PointerDownEvent>(ev => ReiniciaJogo());
		*/
	}
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
			divDevMode.style.display = DisplayStyle.None;
		}
		ScoreInterface();
	}
	/*
	//Finaliza o jogo
	public void ExitGame()
	{
		Application.Quit();
	}
	//Abre o meu github
	public void OpenGithub()
	{
		Application.OpenURL("https://github.com/ArthurSegato");
	}
	//Abre o meu website
	public void OpenWebsite()
	{
		Application.OpenURL("https://arthursegato.com/");
	}
	//Abre o canal do StreamBeats
	public void OpenStreamBeats()
	{
		Application.OpenURL("https://www.youtube.com/c/StreamBeatsbyHarrisHeller/");
	}
	//Toca o som do click do menu
	public void PlaySound()
	{
		//Colocar novo sistema de som pro click
	}
	*/
	public void DeveloperModeInterface()
	{
		float playerSpeed = player.GetComponent<PlayerMovement>().speed;
		float lateralForce = player.GetComponent<PlayerMovement>().sidewaysForce;
		float checkpointDistance = player.GetComponent<PlayerMovement>().checkpoint;
		string playerPosition = player.transform.position.z.ToString("0");
		string fpsteste = (1.0 / Time.deltaTime).ToString("0");

		divDevMode.style.display = DisplayStyle.Flex;

		devModeFps.text = $"Fps: {fpsteste}";
		
		devModeBuild.text = $"Build: {Application.version}";

		devModeSpeed.text = $"Player_Speed: {playerSpeed}";

		devModeForce.text = $"Lateral_Force: {lateralForce}";

		devModeCheckPoint.text = $"CheckPoint_Distance: {checkpointDistance}";
		
		devModePlayerPosition.text = $"Player_Position: {playerPosition}";

	}
	public void ScoreInterface()
	{
		//Exibe a posição do jogador
		scoreGamePlay.text = (player.transform.position.z / 10).ToString("0");
	}
	public void GameOverInterface()
	{
		string score = scoreManager.GetComponent<ScoreManager>().score.ToString("0");
		string highScore = scoreManager.GetComponent<ScoreManager>().scoreHigh.ToString("0");

		divGameOver.style.display = DisplayStyle.Flex;
		gameOverCurrentScore.text = score;
		gameOverHighScore.text = highScore;
	}
	public void ReiniciaJogo()
	{
		Debug.Log("Botao clicado");
	}
}
