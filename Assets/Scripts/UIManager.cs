using UnityEngine;
using UnityEngine.SceneManagement;

public class UIManager : MonoBehaviour
{
	public static UIManager instance;
	//Garante que so vai ter uma UIManager em cada cena, e se não tiver, então cria uma
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

	//Carrega a fase do jogo
	public void StartGame()
	{
		SceneManager.LoadScene("Game");
	}

	//Carrega o menu sobre
	public void ShowAbout()
	{
		SceneManager.LoadScene("About");
	}

	//Finaliza o jogo
	public void ExitGame()
	{
		Application.Quit();
	}

	//Volta pro menu inicial
	public void BackToHome()
	{
		SceneManager.LoadScene("Home");
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
		FindObjectOfType<AudioManager>().Play("MenuClick");
	}
}
