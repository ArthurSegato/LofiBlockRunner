using System.Threading;
using UnityEngine;
using UnityEngine.UIElements;

public class InterfaceManager : MonoBehaviour
{

	public GameObject gameManager;
	public GameObject interfaceGame;
	public GameObject player;

	//Garante que so vai ter uma InterfaceManager em cada cena, e se não tiver, então cria uma
	public static InterfaceManager instance;
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
			interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>("Div_DevMode").style.display = DisplayStyle.None;
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

		interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>("Div_DevMode").style.display = DisplayStyle.Flex;

		double fps = 1.0 / Time.deltaTime;
		
		interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<Label>("Text_DevMode_Fps").text = "Fps: " + fps.ToString("0");

		interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<Label>("Text_DevMode_Build").text = "Build: " + Application.version;

		interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<Label>("Text_DevMode_Speed").text = "Player_Speed: " + player.GetComponent<PlayerMovement>().speed;

		interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<Label>("Text_DevMode_Force").text = "Lateral_Force: " + player.GetComponent<PlayerMovement>().sidewaysForce;

		interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<Label>("Text_DevMode_CheckPoint").text = "CheckPoint_Distance: " + player.GetComponent<PlayerMovement>().checkpoint;

		interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<Label>("Text_DevMode_PlayerPosition").text = "Player_Position: " + player.transform.position.z.ToString("0");
		
	}
	public void ScoreInterface()
	{
		//Exibe a posição do jogador
		interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<Label>("Text_Score_Gameplay").text = (player.transform.position.z / 10).ToString("0");
	}
	public void GameOverInterface()
	{
		interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>("Div_GameOver").style.display = DisplayStyle.Flex;
	}
}
