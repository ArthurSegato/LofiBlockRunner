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
			interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>("DevModeDiv").style.display = DisplayStyle.None;
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

		interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>("DevModeDiv").style.display = DisplayStyle.Flex;

		double fps = 1.0 / Time.deltaTime;
		
		interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<Label>("DevModeFps").text = "Fps: " + fps.ToString("0");

		interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<Label>("DevModeBuild").text = "Build: " + Application.version;

		interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<Label>("DevModeSpeed").text = "Speed: " + player.GetComponent<PlayerMovement>().speed;

		interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<Label>("DevModeForce").text = "Force: " + player.GetComponent<PlayerMovement>().sidewaysForce;

		interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<Label>("DevModeCheckPoint").text = "CheckPoint: " + player.GetComponent<PlayerMovement>().checkpoint;

		interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<Label>("DevModePlayerPosition").text = "PlayerPosition: " + player.transform.position.z.ToString("0");
		
	}
	public void ScoreInterface()
	{
		//Exibe a posição do jogador
		interfaceGame.GetComponent<UIDocument>().rootVisualElement.Q<Label>("ScoreText").text = (player.transform.position.z / 10).ToString("0");
	}
	public void GameOverInterface(int delay)
	{
		Thread.Sleep(delay);
		//Chama tela de game over
	}
}
