using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuMannager : MonoBehaviour
{
	//Carrega a fase do jogo
    public void StartGame()
	{
		SceneManager.LoadScene("Level");
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
}
