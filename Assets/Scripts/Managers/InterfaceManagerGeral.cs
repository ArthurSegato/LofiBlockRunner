using UnityEngine;
using UnityEngine.SceneManagement;

public class InterfaceManagerGeral : MonoBehaviour
{

	//Garante que so vai ter uma InterfaceManager em cada cena, e se não tiver, então cria uma
	public static InterfaceManagerGeral instance;
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
	public void OpenHome()
	{
		SceneManager.LoadScene(0);
	}
	public void OpenSettings()
	{
		SceneManager.LoadScene(1);
	}
	public void OpenAbout()
	{
		SceneManager.LoadScene(2);
	}
	public void OpenGame()
	{
		SceneManager.LoadScene(3);
	}
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
	public void OpenStore()
	{
		Application.OpenURL("https://arthursegato.itch.io/");
	}
	//Abre o canal do StreamBeats
	public void OpenStreamBeats()
	{
		Application.OpenURL("https://www.youtube.com/c/StreamBeatsbyHarrisHeller/");
	}
	public void GoogleFonts()
	{
		Application.OpenURL("https://fonts.google.com/specimen/Roboto");
	}
}
